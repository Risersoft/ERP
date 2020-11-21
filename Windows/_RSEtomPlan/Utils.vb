Imports System.Data.SqlClient
Imports System.Xml
Imports Newtonsoft.Json
Imports risersoft.API.GSTN
Imports risersoft.app.dataporter
Imports risersoft.app.mxengg
Imports risersoft.app.mxent
Imports risersoft.app.mxform
Imports risersoft.app2.shared
Imports risersoft.shared
Imports risersoft.shared.dal
Imports risersoft.shared.portable.Model
Imports risersoft.shared.portable.Models.Config
Imports risersoft.shared.win
Imports risersoft.shared.dotnetfx
Imports risersoft.app.mxform.hrm
Imports risersoft.shared.cloud

Public Class Utils
    Public Shared Sub Main(ByVal args() As String)
        myApp = New clsRSWinCloudApp(New clsExtendAppMxEnt)
        myWinApp.CheckInitConsole(args)
        Dim fMain As frmMax = AppStarter.StartWinFormApp(args)
        If Not fMain Is Nothing Then

            Application.Run(fMain)
        End If
    End Sub
    Private Shared Sub SaveForm12BBdata()

        Dim str1 As String = My.Computer.FileSystem.ReadAllText("C:\form12bb.json")
        Dim ds = JsonConvert.DeserializeObject(Of DataSet)(str1)

        Dim dic As New clsCollecString(Of String)
        dic.Add("form12bb", "select * from form12bb")
        dic.Add("form12bbitem", "select * from form12bbitem")
        dic.Add("emp", "select employeeid, empcode from employees where onrolls=1")
        Dim ds2 = SQLHelper.ExecuteDataset(CommandType.Text, dic)
        myWinApp.Controller.Tables.SetAuto(ds2.Tables("form12bb"), ds2.Tables("form12bbitem"), "form12bbid")

        For Each rForm As DataRow In ds.Tables("form12bb").Select
            Dim rrEmp = ds2.Tables("emp").Select("empcode='" & rForm("empcode") & "'")
            If rrEmp.Length > 0 Then
                Dim rr = ds2.Tables("form12bb").Select("employeeid=" & rrEmp(0)("employeeid"))
                If rr.Length = 0 Then
                    Dim nr = myUtils.CopyOneRow(rForm, ds2.Tables("form12bb"),, False)
                    nr("employeeid") = rrEmp(0)("employeeid")
                    nr("finyearid") = myWinApp.objAppExtender.GenerateParamValue(myWinApp.Controller, "currfinid")
                    For Each rItem As DataRow In ds.Tables("form12bbitem").Select("form12bbid=" & rForm("form12bbid"))
                        Dim nr2 = myUtils.CopyOneRow(rItem, ds2.Tables("form12bbitem"),, False, "form12bbid", nr("form12bbid"))
                    Next
                End If
            End If
        Next

        myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("form12bb"), dic("form12bb"))
        myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("form12bbitem"), dic("form12bbitem"))

    End Sub
    Private Shared Function TestConverter()
        Dim settings = New JsonSerializerSettings()
        settings.Converters.Add(New CustomDataTableConverter())
        settings.Converters.Add(New CustomDataSetConverter())

        Dim str1 As String = JsonConvert.SerializeObject(myWinApp.Model, settings)
        Dim result = JsonConvert.DeserializeObject(Of clsAppModel)(str1, settings)

    End Function
    Private Shared Sub CalcLM()

        Dim sql As String = "select employeeid,empcode,joindate,fullname from hrplistemp() where joindate>'1-Jan-2017' and joindate<'1-may-2017' and (leavedate is null or leavedate>'1-jan-2018')"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        For Each r1 As DataRow In dt1.Select
            Trace.WriteLine(r1("empcode") & ":" & r1("fullname"))
            Dim objProc As New clsLeaveBase(myWinApp.Controller)
            Dim oRet = objProc.CalculateELBalanceEmp(r1("employeeid"))
        Next
    End Sub
    Private Shared Sub TestHTML()
        Dim provider As New clsViewModelProvider(myWinApp.Controller.DataProvider, False)
        Dim Model As New clsViewModel(myWinApp.Controller.DataProvider)
        provider.GenerateViewModel(Model, "dashhcm1", "", portable.EnumViewCallType.acNormal)

        Dim provider2 As New risersoft.shared.web.HTMLGenerator(myWinApp.Controller)
        Dim str1 = provider2.GenerateModelHTML(Model).ToString()
        Dim str2 = provider2.GenerateViewHTML(Model)
    End Sub
    Private Shared Sub AssignDivision(IDField As String, DocType As String)

        Dim strf1 As String = "doctype in ('" & DocType & "') and divisionid is null"
        Dim dic As New clsCollecString(Of String)
        dic.Add("py", "select * from payment where " & strf1)
        dic.Add("pi", "select paymentid, invoiceid, (select divisionid from invoice where invoice.invoiceid = paymentitem.invoiceid) as divisionid from paymentitem where paymentid in (select paymentid from payment where " & strf1 & ")")

        Dim ds As DataSet = SQLHelper.ExecuteDataset(CommandType.Text, dic)

        For Each rPY As DataRow In ds.Tables("py").Select
            If ds.Tables("pi").Select("paymentid=" & rPY("paymentid")).Length > 0 Then
                rPY("divisionid") = ds.Tables("pi").Select("paymentid=" & rPY("paymentid"), "divisionid")(0)("divisionid")
            Else
                Dim sql As String
                sql = "select * from invoice where " & IDField & " = " & rPY(IDField) & " and amounttot=" & myUtils.cValTN(rPY("amounttotpay"))
                Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                If dt1.Rows.Count > 0 Then
                    rPY("divisionid") = dt1.Rows(0)("divisionid")
                Else
                    sql = "select distinct divisionid from invoice where " & IDField & " = " & rPY(IDField)
                    Dim dt2 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                    If dt2.Rows.Count = 1 Then
                        rPY("divisionid") = dt2.Rows(0)("divisionid")
                    End If

                End If
            End If
        Next
        SQLHelper.SaveResults(ds.Tables("py"), "select paymentid,divisionid from payment where 0=0")
    End Sub
    Private Shared Sub TestData()
        Dim sql As String = "select itemid,subcatid, itemschedid, itemcode, itemname, subcatname, schedname, unitname from invlistitems()"
        Dim ds As DataSet = SQLHelper.ExecuteDataset(CommandType.Text, sql)

        'Dim ds2 As DataSet = ChannelProxyFactory.RoundTripModel(ds)
        Dim str2 As String = JsonConvert.SerializeObject(ds, New JsonSerializerSettings With {.NullValueHandling = NullValueHandling.Ignore})
        Debug.WriteLine(str2.Length)


        Dim ds3 As New FlexibleDataset(ds, False)
        Dim ds4 = ChannelProxyFactory.RoundTripModel(ds3)

    End Sub
    Private Shared Sub RoundOffAccvouchItem()
        Dim sql As String = "select * from accvouchitem where round(amount,2)<>amount"
        Dim ds As DataSet = SQLHelper.ExecuteDataset(CommandType.Text, sql)

        For Each r1 As DataRow In ds.Tables(0).Select
            Dim rr() As DataRow = ds.Tables(0).Select("accvouchid=" & r1("accvouchid") & " and accvouchitemid<>" & r1("accvouchitemid"))
            If rr.Length = 1 Then
                r1("amount") = Math.Round(r1("amount"), 2)
                rr(0)("amount") = Math.Round(rr(0)("amount"), 2)
            End If
        Next
        SQLHelper.SaveResults(ds.Tables(0), sql)


    End Sub
    Private Shared Sub CalculateInvHRCAmount()

        Dim oMasterData As New clsMasterDataHRP(myWinApp.Controller)

        For Each rPP As DataRow In oMasterData.dtPayPeriod.Select("sdate>='1-Apr-2017' and sdate<'1-Jan-2018'")
            Dim oProc As New clsPayPeriodBase(myWinApp.Controller)
            Dim dsp As DataSet = oProc.LoadPayPeriodData(rPP)

            'oProc.CalculateVouchContractor(rPP, rPP("edate"), dsp, "SA", "PP", "Payperiodid")
            SQLHelper.SaveResults(dsp.Tables("hpav"), "select paymenthrvouchid,totalamount from paymenthrvouch",, "payduetype='I'")
        Next


    End Sub
    Private Shared Sub TransferFileStore()

        Dim dic As New clsCollecString(Of String)
        dic.Add("store", "select * from filestore")
        dic.Add("wk", "select * from workspace")

        Dim ds As DataSet = SQLHelper.ExecuteDataset(CommandType.Text, dic)
        For Each rStore As DataRow In ds.Tables(0).Select
            Dim strf1 As String = "fileshareid=" & rStore("filestoreid")
            Dim dic2 As New clsCollecString(Of String)
            dic2.Add("global", "select * from fileshare where " & strf1)
            dic2.Add("local", "select * from localshare where " & strf1)
            Dim ds1 As DataSet = SQLHelper.ExecuteDataset(CommandType.Text, dic2)
            Dim dt1 As DataTable = myWinApp.Controller.Data.outerJoin(ds1, "share")
            If dt1.Rows.Count > 0 Then
                Dim rNew As DataRow = dt1.Rows(0)

                myUtils.MergeDataRow(rStore, rNew)
                Dim rr() As DataRow = ds.Tables("wk").Select("servername='" & rStore("indexservername") & "'")
                rNew("sharetype") = "LAN"
                rNew("backupshareid") = rStore("backupstoreid")
                rNew("windowsuser") = rStore("username")
                rNew("sharepathunc") = rStore("uncpath")
                rNew("sharepathlocal") = rStore("localpath")
                If rr.Length > 0 Then rNew("workspaceid") = rr(0)("workspaceid")
                myWinApp.Controller.Data.SaveMulti(dic2, rNew, rStore("filestoreid"))
            End If
        Next
    End Sub
    Private Shared Sub TransferEmployeeUser()
        Dim dic As New clsCollecString(Of String)
        dic.Add("docempid", "select prodocuid, docempid,docuserid from ProDocu where docempid is not null and docuserid is null")
        dic.Add("PrepByID", "select prodocuid,prepbyempid,prepbyid from ProDocu where prepbyempid is not null and prepbyid is null")
        dic.Add("PrepByID2", "select prodocuid,prepbyempid2,prepbyid2 from ProDocu where prepbyempid2 is not null and prepbyid2 is null")
        dic.Add("ChkByID", "select prodocuid,chkbyempid,chkbyid from ProDocu where chkbyempid is not null and chkbyid is null")
        dic.Add("AppByID", "select prodocuid,appbyempid,appbyid from ProDocu where appbyempid is not null and appbyid is null")
        dic.Add("stddrg", "select stddrgid,desempid,desuserid from stddrg where desempid is not null and desuserid is null")
        dic.Add("pidunit", "select pidunitid, desempid,desuserid from pidunit where desempid is not null and desuserid is null")
        dic.Add("tasks", "select taskid, desempid,desuserid from tasks where desempid is not null and desuserid is null")
        dic.Add("repairunit", "select repairunitid, attendedbyempid,attendedbyid from repairunit where attendedbyempid is not null and attendedbyid is null")
        dic.Add("fieldreport", "select fieldreportid, attendedbyempid,attendedbyid from fieldreport where attendedbyempid is not null and attendedbyid is null")
        dic.Add("soperson", "select sopersonid, attendedbyempid,attendedbyid from soperson where attendedbyempid is not null and attendedbyid is null")
        dic.Add("salesenq", "select salesenqid, employeeid,handledbyid from salesenq where employeeid is not null and handledbyid is null")
        dic.Add("salesorder", "select salesorderid, employeeid,handledbyid from salesorder where employeeid is not null and handledbyid is null")
        dic.Add("empcontactid", "select odnoteid, empcontactid,contactuserid from odnote where empcontactid is not null and contactuserid is null")
        dic.Add("checkedbyid", "select odnoteid, checkedbyempid,checkedbyid from odnote where checkedbyempid is not null and checkedbyid is null")
        dic.Add("bookedbyid", "select odnoteid, bookedbyempid,bookedbyid from odnote where bookedbyempid is not null and bookedbyid is null")
        dic.Add("customer", "select customerid, regemployeeid,reguserid from customer where regemployeeid is not null and reguserid is null")

        Dim ds As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)
        For Each dt1 As DataTable In ds.Tables
            Dim EmployeeIDCSV As String = myUtils.MakeCSV(dt1.Select(), dt1.Columns(1).ColumnName)
            Dim dic2 As New clsCollecString(Of String)
            dic2.Add("emp", "select * from hrpListAllEmp() where employeeid in (" & EmployeeIDCSV & ")")
            dic2.Add("user", "select * from users")
            Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)
            For Each r1 As DataRow In dt1.Select
                For Each rEmp As DataRow In ds2.Tables("emp").Select("employeeid=" & r1(1))
                    If myUtils.NullNot(rEmp("userid")) Then
                        Dim nr As DataRow = myWinApp.Controller.Tables.AddNewRow(ds2.Tables("user"))
                        nr("userid") = System.Guid.NewGuid.ToString
                        nr("username") = rEmp("firstname") & "." & rEmp("lastname")
                        If Not myUtils.NullNot(rEmp("leavedate")) Then
                            nr("isdeleted") = True
                            nr("deletedonutc") = rEmp("leavedate")
                            nr("deletedbyuserid") = myWinApp.Controller.Police.UniqueUserID
                        End If
                        nr("roleid") = 2
                        nr("createdonutc") = rEmp("joindate")
                        nr("createdbyuserid") = myWinApp.Controller.Police.UniqueUserID
                        rEmp("userid") = nr("userid")
                    End If
                    r1(2) = rEmp("userid")
                Next
            Next
            myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("emp"), "select employeeid,userid from employees")
            myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("user"), "select * from users")
            myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(dt1, dic(dt1.TableName))

        Next
    End Sub
    Private Shared Sub RebuildBalances()
        Dim strf1 As String = "accvouchid in (select
            accvouchid from

            (select * ,
            (select top 1 accvouchid from accvouch where accvouchid in (
            select accvouchid from acclistvouchitem() as t2 where t1.GLAccountID=t2.GLAccountID and t1.SLIDValue=t2.SLIDValue
            and t1.SubLedgerType=t2.SubLedgerType) order by vouchdate) as accvouchid
            
            from

            (select distinct glaccountid, subledgertype, slidvalue
             from acclistvouchitem()) as t1) as t3)"

        Dim dic As New clsCollecString(Of String)
        dic.Add("av", "select * From accvouch where " & strf1 & " order by vouchdate")
        Dim ds As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)

        For Each r1 As DataRow In ds.Tables("av").Select
            Dim oProc As New clsAVProc(myWinApp.Controller)
            oProc.LoadVouch(r1("accvouchid"))
            oProc.UpdateBalances()
            Trace.WriteLine("End Voucher: " & r1("vouchernum") & " Dt: " & r1("vouchdate"))
        Next

    End Sub
    Private Shared Sub RebuildBalances2()
        Dim strf1 As String = "accvouchid in (select
            accvouchid from

            (select * ,
            (select top 1 accvouchid from accvouch where accvouchid in (
            select accvouchid from acclistvouchitem() as t2 where t1.GLAccountID=t2.GLAccountID) order by vouchdate) as accvouchid
            
            from

            (select distinct glaccountid,acccode, accname from accListGLAccountBal() where round(balance,2)<>Balance) 
                as t1) as t3)"

        Dim dic As New clsCollecString(Of String)
        dic.Add("av", "select * From accvouch where " & strf1 & " order by vouchdate")
        Dim ds As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)

        For Each r1 As DataRow In ds.Tables("av").Select
            Dim oProc As New clsAVProc(myWinApp.Controller)
            oProc.LoadVouch(r1("accvouchid"))
            oProc.UpdateBalances()
            Trace.WriteLine("End Voucher: " & r1("vouchernum") & " Dt: " & r1("vouchdate"))
        Next

    End Sub
    Private Shared Sub AssignSubLedgerCampus()
        Dim oMap As New clsAccountMap(myWinApp.Controller)
        Dim strf1 As String = "campusid is null and glaccountid in (select glaccountid from glaccount where subledgertype='A')"
        Dim dic As New clsCollecString(Of String)
        dic.Add("av", "select * From accvouch where accvouchid in (select accvouchid from accvouchitem where " & strf1 & ")")
        dic.Add("avi", "select * From accvouchitem where " & strf1)
        Dim ds As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)

        For Each rAV As DataRow In ds.Tables("av").Select
            Dim CampusID As Integer = 1
            Dim sql As String = ""
            Select Case myUtils.cStrTN(rAV("accvouchtype")).Trim.ToUpper
                Case "IP"
                    sql = "select * from invoice where invoiceid = " & myUtils.cValTN(rAV("invoiceid"))
                Case "IS"
                    sql = "select * from invoice where invoiceid = " & myUtils.cValTN(rAV("invoiceid"))
                Case "PPU"
                    sql = "select * from payment where paymentid = " & myUtils.cValTN(rAV("paymentid"))
                Case "PSA"
                    sql = "select * from payment where paymentid = " & myUtils.cValTN(rAV("paymentid"))
                Case "TV"
                    sql = "select * from tourvouch where tourvouchid = " & myUtils.cValTN(rAV("tourvouchid"))
                Case "FF"
                    sql = "select * from employees where employeeid = " & myUtils.cValTN(rAV("employeeid"))
                Case "MV"
                    'do nothing as will have to be done manually
                    CampusID = 0
                Case Else
                    'PV/PC/PHR/PP/AV/PCO/AV
            End Select
            For Each rAVI As DataRow In ds.Tables("avi").Select("accvouchid =" & rAV("accvouchid"))
                If Not String.IsNullOrEmpty(sql) Then
                    Dim AccountKey As String = ""
                    Dim dt1 As DataTable = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
                    For Each rGL As DataRow In oMap.getAccountMapDataset(False).Tables("acc").Select("glaccountid=" & rAVI("glaccountid"))
                        Dim rr() As DataRow = oMap.getAccountMapDataset(False).Tables("map2").Select("glaccountcode='" & rGL("acccode") & "'")
                        If rr.Length > 0 Then AccountKey = rr(0)("accountkey")
                        CampusID = oMap.FindCampusID(AccountKey, dt1.Rows(0), Nothing, "")

                    Next
                End If
                If CampusID > 0 AndAlso myUtils.NullNot(rAVI("campusid")) Then rAVI("campusid") = CampusID
                If CampusID > 1 Then Debug.WriteLine(myUtils.RowValuesText(rAVI))
            Next
        Next
        myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds.Tables("avi"), "select accvouchitemid,campusid From accvouchitem")

    End Sub
    Private Shared Sub TransferCampus()
        Dim conn As SqlConnection = MxEntDBConn()
        Dim exec As New clsMSSQLExecutor

        Dim dic As New clsCollecString(Of String)
        dic.Add("campus", "select campusid, campuscode, geoarealist from campus")

        Dim dsSource As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)
        Dim dsTarget As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)


        For Each r1 As DataRow In dsSource.Tables("campus").Select("geoarealist Is Not null")
            Dim rr() As DataRow = dsTarget.Tables("campus").Select("campuscode='" & myUtils.cStrTN(r1("campuscode")).Trim & "'")
            If rr.Length > 0 Then
                rr(0)("geoarealist") = r1("geoarealist")
            End If
        Next

        For Each kvp In dic
            myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(dsTarget.Tables(kvp.Key), kvp.Value, True)
        Next



    End Sub

    Private Shared Sub TransferPunchData()
        Dim conn As SqlConnection = MxEntDBConn()
        Dim exec As New clsMSSQLExecutor

        Dim dic As New clsCollecString(Of String)
        dic.Add("emp", "select employeeid,empcode,userid,companyemail from employees where onrolls=1")
        dic.Add("device", "select * from empdevice")
        dic.Add("app", "select * from leaveapp where statuscode=0")
        dic.Add("punch", "select * from punchdata where punchdate>'30-Sep-2017'")

        Dim dsSource As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)
        Dim dsTarget As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic)


        For Each rEmp As DataRow In dsSource.Tables("emp").Select("userid is not null")
            Dim rr() As DataRow = dsTarget.Tables("emp").Select("empcode='" & rEmp("empcode") & "'")
            If rr.Length > 0 Then
                For Each r2 As DataRow In dsSource.Tables("device").Select("employeeid=" & rEmp("employeeid"))
                    Dim nr As DataRow = myUtils.CopyOneRow(r2, dsTarget.Tables("device"))
                    If myUtils.InStrList(nr("deviceid"), "zy223") Then
                        Debugger.Break()
                    End If
                    nr("employeeid") = rr(0)("employeeid")
                Next

                rr(0)("userid") = rEmp("userid")
                rr(0)("companyemail") = rEmp("companyemail")

                For Each r2 As DataRow In dsSource.Tables("app").Select("employeeid=" & rEmp("employeeid"))
                    Dim nr As DataRow = myUtils.CopyOneRow(r2, dsTarget.Tables("app"))
                    nr("employeeid") = rr(0)("employeeid")
                Next

                For Each r2 As DataRow In dsSource.Tables("punch").Select("employeeid=" & rEmp("employeeid"))
                    Dim nr As DataRow = myUtils.CopyOneRow(r2, dsTarget.Tables("punch"))
                    nr("employeeid") = rr(0)("employeeid")
                Next

            End If
        Next
        For Each kvp In dic
            myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(dsTarget.Tables(kvp.Key), kvp.Value, True)
        Next



    End Sub

    Private Shared Sub CreateGanttConf()
        Dim obj As New clsGanttConf With {.StartTimeField = "startdate", .FinishTimeField = "finishdate", .IsCompletedField = "Iscompleted"}
        obj.Levels.Add(New clsGanttConfLevel With {.IDField = "PIDUnitID", .NameField = "WOInfo,DescripWO"})
        obj.Levels.Add(New clsGanttConfLevel With {.IDField = "ProdLotID", .NameField = "LotInfo"})
        obj.Levels.Add(New clsGanttConfLevel With {.IDField = "ProdLotRouteID", .NameField = "SeqProcName"})
        Dim strXML As String = myUtils.Serialize(obj)

    End Sub
    Private Shared Function FindCampusDistance()
        Dim sql As String = "select * from campus"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        For Each rCampus As DataRow In dt1.Select("campusid=1081")
            Try
                Dim location As New GeoCoordinate(29.7162, 77.4265)
                Dim result = JsonConvert.DeserializeObject(Of List(Of CampusAreaInfo))(rCampus("geoarealist"))
                Dim dist = SpatialLibrary.DistanceToCampus(result, location)
                Debug.WriteLine(dist)
            Catch ex As Exception
                Trace.WriteLine(ex.Message)
            End Try
        Next
    End Function
    Private Shared Function FindDistance() As Decimal
        Dim v1 As New bdccGeo(30.210452, 75.0881776)
        Dim v2 As New bdccGeo(30.3353, 76.3942)

        Dim d = v1.distance(v2) * 6378137.0 / 1000
        Return d
    End Function
    Private Shared Sub FindBalanceSubMismatch(IDField As String)
        Dim oBS As New clsAccBS(myWinApp.Controller)
        Dim dt1 As DataTable = oBS.TrialBalance2(1, Now.Date, "2017-Apr-1", "", IDField, True, False)
        Dim dt4 As DataTable = oBS.TrialBalance2(1, Now.Date, New Date(Now.Year, Now.Month, 1), "", IDField, True, False)

        Dim RowList4, RowList1 As New List(Of DataRow)
        For Each r1 As DataRow In dt4.Select
            Dim strf1 As String = myWinSQL2.GenerateSQLWhere(r1, "glaccountid," & IDField)
            Dim rr() As DataRow = dt1.Select(strf1)
            If rr.Length > 0 AndAlso myUtils.cValTN(rr(0)("balance")) = myUtils.cValTN(r1("balance")) Then
                RowList1.Add(rr(0))
                RowList4.Add(r1)
            End If
        Next
        myUtils.RemoveRows(RowList1.ToArray)
        myUtils.RemoveRows(RowList4.ToArray)

    End Sub
    Private Shared Sub FindBalanceMismatch()
        Dim oBS As New clsAccBS(myWinApp.Controller)
        Dim dt1 As DataTable = oBS.TrialBalance2(1, Now.Date, "2017-Apr-1", "", "", True, False)
        Dim dt4 As DataTable = oBS.TrialBalance2(1, Now.Date, New Date(Now.Year, Now.Month, 1), "", "", True, False)

        Dim RowList4, RowList1 As New List(Of DataRow)
        For Each r1 As DataRow In dt4.Select
            Dim rr() As DataRow = dt1.Select("glaccountid = " & r1("glaccountid"))
            If rr.Length > 0 AndAlso myUtils.cValTN(rr(0)("balance")) = myUtils.cValTN(r1("balance")) Then
                RowList1.Add(rr(0))
                RowList4.Add(r1)
            End If
        Next
        myUtils.RemoveRows(RowList1.ToArray)
        myUtils.RemoveRows(RowList4.ToArray)

    End Sub
    Private Shared Sub SetMailingAddress()
        Dim sql As String = "select * from persons"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        For Each r1 As DataRow In dt1.Select
            r1("prmailingaddress") = myUtils.MakeCSV(vbCrLf, myUtils.cStrTN(r1("praddress")), myUtils.MakeCSV(", ", myUtils.cStrTN(r1("prcity")), myUtils.cStrTN(r1("prstate"))), myUtils.MakeCSV(" - ", myUtils.cStrTN(r1("prcountry")), myUtils.cStrTN(r1("prpincode"))))
            r1("pmmailingaddress") = myUtils.MakeCSV(vbCrLf, myUtils.cStrTN(r1("pmaddress")), myUtils.MakeCSV(", ", myUtils.cStrTN(r1("pmcity")), myUtils.cStrTN(r1("pmstate"))), myUtils.MakeCSV(" - ", myUtils.cStrTN(r1("pmcountry")), myUtils.cStrTN(r1("pmpincode"))))
        Next
        SQLHelper.SaveResults(dt1, sql)
    End Sub
    Private Shared Async Sub TestSyncBackup()
        Dim oRet = Await myBackup.BackupStoreFullAsync(myWinApp.Controller, "\\boston\store\sfra", "E:\backup", "abhishek.singhal@kanohar.com", "", "", True)

    End Sub
    Private Shared Sub FindMismatchTB()
        Dim oBS1 As New clsAccBS(myWinApp.Controller)
        Dim dt1 As DataTable = oBS1.TrialBalance2(1, Now.Date, "2017-Apr-01", "", "", True, False)

        Dim oBS2 As New clsAccBS(myWinApp.Controller)
        Dim dt2 As DataTable = oBS2.TrialBalance(1, Now.Date, "", "", True)

        For Each r1 As DataRow In dt1.Select
            Dim rr() As DataRow = dt2.Select("GLAccountid=" & r1("Glaccountid"))
            If rr.Length = 0 Then
                Debug.WriteLine("ACCount not found")
            Else
                If Not myUtils.MatchRowCols(r1, rr(0), "debitbalance", "creditbalance") Then
                    Debug.WriteLine("Balance mismatch")
                End If
            End If
        Next

    End Sub
    Private Shared Sub CalcMatVouchNum()
        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("mv", "select distinct matvouchid,vouchtypecode,vouchnum,matdepid,VouchDate,docsysnum from invlistmatvouch() where docsysnum is null")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)
        For Each rMV As DataRow In ds2.Tables("mv").Select
            rMV("vouchnum") = DBNull.Value
            Dim oProc As New clsVoucherNum(myWinApp.Controller)
            oProc.GetNewSerialNo("matvouchid", rMV("vouchtypecode"), rMV)
            SQLHelper.SaveResults(ds2.Tables("mv"), "SELECT matvouchid, vouchnum, docsysnum FROM matvouch", True, "0=0")
        Next

    End Sub

    Private Shared Sub Transfer201617Bonus()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("bme", " Select employeeid,sum(salrate),sum(pda) As totpda, sum(Case When salrate>21000 Then 0 Else bonus End) As totamountbonus,
sum(case when salrate>21000 then bonus else 0 end) As totamountgrat
 From hrplistbonus() Where bonusmasterid = 17 Group By employeeid")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("bme", "select * from bonusmasteremp where bonusmasterid = 17")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)

        For Each rBME As DataRow In ds.Tables("bme").Select
            Dim rr() As DataRow = ds2.Tables("bme").Select("employeeid=" & rBME("employeeid"))
            If rr.Length = 0 Then
                Dim nr = myUtils.CopyOneRow(rBME, ds2.Tables("bme"))
                nr("bonusmasterid") = 17
                nr("entrytype") = "BM"
                nr("netpaid") = nr("totamountbonus") + nr("totamountgrat")
                myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("bme"), "SELECT * FROM bonusmasteremp", True, "0=0")
                Debug.WriteLine("done for employeeid: " & rBME("employeeid"))
            End If
        Next


    End Sub



    Private Shared Sub CalcSalaryRateCalc()
        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("emp", "Select * from employees")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)
        For Each rEmp As DataRow In ds2.Tables("emp").Select("", "employeeid")
            Debug.WriteLine("Start for empcode:" & rEmp("empcode"))
            Dim oProc As New clsEmpSalaryBase(myWinApp.Controller)
            oProc.LoadData(rEmp("employeeid"), False)
            For Each rES As DataRow In oProc.dsEmpSal.Tables("es").Select
                oProc.GenerateEmpSalRateCalc(rES, oProc.dsEmpSal)
            Next
            oProc.SaveEmpSalRate(oProc.dsEmpSal.Tables("esrc"), oProc.dsEmpSal.Tables("esrcc"))
            Debug.WriteLine("done for empcode:" & rEmp("empcode"))
        Next
    End Sub
    Private Shared Sub TransferLoanComp()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("ps", "select * from loan where markpaid=1")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("ps", "select * from emploan where completedon is null")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)

        For Each rPS As DataRow In ds.Tables("ps").Select
            Dim rr() As DataRow = ds2.Tables("ps").Select("emploanid=" & rPS("loanid"))
            If rr.Length > 0 Then
                rr(0)("completedon") = "2017-Mar-31"
                myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("ps"), "SELECT * FROM emploan", True, "0=0")
                Debug.WriteLine("done for emploanid:" & rPS("loanid"))
            End If
        Next
    End Sub
    Private Shared Sub TransferMarchLoans()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("ps", "select * from loanwo where payperiodid = 218")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("ps", "select * from emploanpayback where payperiodid = 218")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)

        For Each rPS As DataRow In ds.Tables("ps").Select
            Dim rr() As DataRow = ds2.Tables("ps").Select("emploanid=" & rPS("loanid") & " and payperiodid = " & rPS("payperiodid"))
            If rr.Length = 0 Then
                Dim nr As DataRow = myUtils.CopyOneRow(rPS, ds2.Tables("ps"))
                nr("deductfrompp") = "S"
                nr("emploanid") = rPS("loanid")
                myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("ps"), "SELECT * FROM emploanpayback", True, "0=0")
                Debug.WriteLine("done for emploanid:" & rPS("loanid"))
            End If
        Next
    End Sub
    Private Shared Sub TransferPayslip2017()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("ps", "select * from payslip where payperiodid in (216,217,218)")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("ps", "Select * from payslip")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)

        For Each rPS As DataRow In ds.Tables("ps").Select
            Dim rr() As DataRow = ds2.Tables("ps").Select("employeeid=" & rPS("employeeid") & " and payperiodid = " & rPS("payperiodid"))
            If rr.Length = 0 Then
                Dim nr As DataRow = myUtils.CopyOneRow(rPS, ds2.Tables("ps"))
                myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("ps"), "SELECT * FROM payslip", True, "0=0")
                Debug.WriteLine("done for payslip:" & rPS("payslipid"))
            End If
        Next


    End Sub

    Private Shared Sub TransferSalaryMaster()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("sm", "select *,dbo.fnccalcgross(45,salarymasterid,0,9) as Total from salarymaster")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("emp", "Select * from employees")
        dic2.Add("sc", "select * from salcomponent")
        dic2.Add("sm", "select * from empsalary")
        dic2.Add("smc", "select * from empsalcomp")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)
        myWinApp.Controller.Tables.SetAuto(ds2.Tables("sm"), ds2.Tables("smc"), "empsalaryid")
        For Each rEmp As DataRow In ds2.Tables("emp").Select
            If ds2.Tables("sm").Select("employeeid=" & rEmp("employeeid")).Length = 0 Then
                For Each rSM As DataRow In ds.Tables("sm").Select("employeeid=" & rEmp("employeeid"))
                    Dim nr As DataRow = myUtils.CopyOneRow(rSM, ds2.Tables("sm"))
                    nr("skilltext") = rSM("skill")
                    nr("salstructureid") = 1
                    nr("pertdsnorm") = If(rSM("total") > 0, myUtils.RoundM(myUtils.cValTN(rSM("tdsnorm")) / rSM("total"), 5, 1) * 100, 0)
                    For Each rSC As DataRow In ds2.Tables("sc").Select
                        If rSM.Table.Columns.Contains(rSC("componentcode")) Then
                            Dim nr2 As DataRow = myUtils.CopyOneRow(rSC, ds2.Tables("smc"))
                            nr2("empsalaryid") = nr("empsalaryid")
                            nr2("amount") = rSM(rSC("componentcode"))
                        End If

                    Next
                Next
                myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("sm"), "SELECT * FROM empsalary", True, "0=0")
                myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("smc"), "SELECT * FROM empsalcomp", True, "0=0")
                Debug.WriteLine("done for empcode:" & rEmp("empcode"))
            End If
        Next



    End Sub


    Private Shared Sub ProcessAttendance()
        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("emp", "Select * from employees")
        dic2.Add("att", "select * from attendance where dated>='2017-1-1'")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)
        Dim oProc As New clsAttendanceCalc(myWinApp.Controller)
        For Each rEmp As DataRow In ds2.Tables("emp").Select
            For Each rAtt As DataRow In ds2.Tables("att").Select("employeeid=" & rEmp("employeeid"))
                rAtt("isholiday") = oProc.IsHoliday(rAtt("dated"), rEmp("campusid"))
                oProc.SetAttendanceStats(rAtt)
            Next
            myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("att"), dic2("att"), True, "0=0")
            Debug.WriteLine("Done for " & rEmp("empcode"))
        Next

    End Sub
    Private Shared Sub TransferLMAttendance()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("att", "select * from attendance where dated>='2017-Jan-01' and dated<='2017-Mar-31'")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("emp", "Select * from employees")
        dic2.Add("att", "select * from attendance where dated>='2017-Jan-01' and dated<='2017-Mar-31'")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)

        Dim oProc As New clsAttendanceCalc(myWinApp.Controller)
        For Each rEmp As DataRow In ds2.Tables("emp").Select
            For Each r1 As DataRow In ds.Tables("att").Select("employeeid=" & rEmp("employeeid"))
                Dim rr() As DataRow = ds2.Tables("att").Select("employeeid=" & rEmp("employeeid") & " and dated='" & Format(r1("dated"), "dd-MMM-yyyy") & "'")
                Dim nr As DataRow
                If rr.Length > 0 Then
                    nr = rr(0)
                    myUtils.MergeDataRow(r1, nr,,, "attendid")
                Else
                    nr = myUtils.CopyOneRow(r1, ds2.Tables("att"))
                End If
                nr("isholiday") = oProc.IsHoliday(nr("dated"), rEmp("campusid"))
                oProc.SetAttendanceStats(nr)
            Next
        Next

        myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(ds2.Tables("att"), "SELECT * FROM attendance", True, "0=0")

    End Sub

    Private Shared Sub ProcessPunch()

        Dim oProc As New CLSProcessPunch(myWinApp.Controller)
        For i As Integer = 1 To 31
            oProc.processPunchDay(New Date(2017, 10, i))
        Next


    End Sub
    Private Shared Sub TransferAprilPunch()
        Dim conn As SqlConnection = MaxDBConn()
        Dim exec As New clsMSSQLExecutor
        Dim dic As New clsCollecString(Of String)
        dic.Add("punch", "select * from punchdata where punchdate>='2017-Apr-02'")
        dic.Add("machine", "select * from machineinfo")
        Dim ds As DataSet = exec.ExecuteDataset(conn, Nothing, CommandType.Text, dic)


        Dim dic2 As New clsCollecString(Of String)
        dic2.Add("emp", "Select employeeid, empcode,cardnum From employees where onrolls=1")
        dic2.Add("campus", "select * from campus")
        Dim ds2 As DataSet = myWinApp.Controller.DataProvider.objSQLHelper.ExecuteDataset(CommandType.Text, dic2)

        Dim dsTarget As DataSet = ds.Clone
        dsTarget.Tables(0).Columns.Add("EMPLOYEEID", GetType(Integer))
        dsTarget.Tables(0).Columns.Add("campusid", GetType(Integer))
        dsTarget.Tables(0).Columns.Add("location", GetType(String))
        For Each r1 As DataRow In ds.Tables(0).Select("", "empcode,punchdate,punchtime")
            Try
                Dim rr() As DataRow = ds2.Tables("emp").Select(String.Format("empcode='{0}' or cardnum='{0}'", myUtils.cStrTN(r1("empcode"))))
                Dim rr2() As DataRow = ds.Tables("machine").Select("srno=" & myUtils.cValTN(r1("machineid")) & "")

                If rr.Length > 0 AndAlso rr2.Length > 0 Then
                    Dim nr As DataRow = myUtils.CopyOneRow(r1, dsTarget.Tables(0))
                    nr("employeeid") = myUtils.cValTN(rr(0)("employeeid"))
                    nr("location") = myUtils.cStrTN(rr2(0)("location"))
                Else
                    Debug.WriteLine("why")
                End If
            Catch ex As Exception
                Trace.WriteLine(ex.Message & vbCrLf & myUtils.RowValuesText(r1))
            End Try
        Next
        myWinApp.Controller.DataProvider.objSQLHelper.SaveResults(dsTarget.Tables(0), "SELECT EmployeeID,PUNCHDATE,PUNCHTIME ,INOUT,campusid,location FROM PunchData", True, "0=0")

    End Sub
    Private Shared Sub StripItems()
        Dim sql As String = "select itemid,subcatid, itemcode, itemname from invlistitems() where isnull(orderqtynumreq,0)=1"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        Dim ds As DataSet = myFuncsBase.AttributedItemsTable(myWinApp.Controller, dt1, Nothing)
    End Sub
    Private Shared Sub HandlePIDUv2()
        Dim sql As String = "Select * from pidunit where woinfo is not null"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        For Each r1 As DataRow In dt1.Select
            r1("wonumeto") = myUtils.ExtractContent(r1("woinfo"))
        Next
        SQLHelper.SaveResults(dt1, sql)
    End Sub
    Private Shared Sub TestCSV()
        Dim gstin = "05BDIPA7164F1ZT"
        Dim ret_period = "072016"
        Dim userid = "risersoft.tn.1"
        Dim client As New GSTNAuthClient(gstin, userid, "GSTN", "Test", GSTNConstants.publicip)
        Dim result = client.RequestOTP()
        Dim result2 = client.RequestToken("")

        Dim model As New GSTR1.GSTR1Total
        Dim client2 As New GSTR1ApiClient(client, gstin, userid, ret_period)
        model = client2.GetSection("B2B").Data

        Dim oProc As New clsPOCOConverter(myWinApp.Controller)
        Dim dt As DataTable = oProc.GenerateTable(Of GSTR1.B2bOutward)(model.b2b)

        Dim oMap As New clsMap(myWinApp.Controller)
        oMap.TargetSchema.LoadDataSet(dt.DataSet)
        Dim oProc2 As New clsTCAsciiDelimited(myWinApp.Controller)
        oMap.TargetConnection = oProc2
        oProc2.Init(oMap)
        oProc2.Properties("Header") = True
        Dim str1 As String = oProc2.GenerateString(oMap.TargetSchema.RecordTypes(dt.TableName), dt)

        Dim oProc3 As New clsSCASCIIDelimited(myWinApp.Controller)
        oMap.SourceConnection = oProc3
        oMap.SourceSchema.LoadDataSet(dt.DataSet)
        oProc3.Init(oMap)
        oProc3.Properties("Header") = True
        Dim ds As DataSet = oProc3.ReadDataSet(str1, oMap.SourceSchema)


        Dim lst = oProc.GenerateObject(Of GSTR1.B2bOutward)(dt)
    End Sub
    Private Shared Sub TestCrossNum()
        Dim sql As String = "Select FittingName, fittingreq.SalesEnqItemID, SalesEnqID from FittingMaster " &
                            "Inner Join FittingReq On FittingMaster.FittingId=fittingReq.FittingId " &
                            "Inner Join SalesEnqItem On  FittingReq.SalesEnqItemID = SalesEnqItem.SalesEnqItemID " &
                            "where salesenqid = 2173"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        Dim dt2 As DataTable = myTables.Crossnum(dt1, "salesenqitemid", "fittingname", 2)
    End Sub
    Private Shared Sub TestIDNote()
        Dim oNote As New clsIDNoteProc(myWinApp.Controller)


        Dim dtni As DataTable = oNote.LoadVouch(2)
        Dim dtn As DataTable = dtni.DataSet.Tables(0)

        oNote.GenerateVoucherDelta(dtn, dtni)
        oNote.UpdateBalance()


    End Sub
    Private Shared Sub TestSalCal()
        Dim oPP As New clsPayPeriodBase(myWinApp.Controller)

        'Dim nr As DataRow = myWinTables.AddNewRow(r1.Table)
        'nr("sdate") = "01-Jan-2015"
        'nr("edate") = "31-Jan-2015"
        'nr("Ratemasterid") = oPP.oMasterData.rRateMaster(1, nr("sdate"))("Ratemasterid")


        oPP.CalculatePayPeriodSal(203)
    End Sub
    Private Shared Sub TestFullFinalRecall()
        Dim oPP As New clsFullFinalBase(myWinApp.Controller)
        oPP.ReinstateFullFinal(2160)
    End Sub
    Private Shared Sub TestFullFinal()
        Dim oPP As New clsFullFinalBase(myWinApp.Controller)
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from hrplistemp() where employeeid = 1811").Tables(0)
        dt1.Rows(0)("leavedate") = "31-Dec-2014"
        oPP.CalculateFullFinal(dt1.Rows(0))
    End Sub
    Private Shared Sub TestSalBenefit()
        Dim oProc As New clsSalBenefitBase(myWinApp.Controller)
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from salbenefit where salbenefitid = 27").Tables(0)

        Dim nr As DataRow = dt1.Rows(0)


        nr("behave") = "PN"


        oProc.TrySave(nr, Nothing)


    End Sub

    Private Shared Sub TestSalBenefitComp()
        Dim oProc As New clsSalBenefitCompBase(myWinApp.Controller)
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from salbenefitcomp where salbenefitid = 27").Tables(0)
        Dim dt2 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from salbenefitrate where salbenefitid = 27").Tables(0)

        Dim nr As DataRow = dt1.Rows(0)

        nr = myTables.AddNewRow(dt1)
        nr("salbenefitid") = 27
        nr("companyid") = 1
        nr("startdate") = "2014-Jan-1"

        oProc.TrySave(nr, dt2)


    End Sub
    Private Shared Sub TestEmpSal()
        'Dim oProc As New clsPaymentCustomer
        'Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from paymentcustomer where paymentcustomerid = 7").Tables(0)
        'oProc.SetBalance(dt1.Rows(0))
        'oProc.GenerateVouchList(dt1.NewRow, 1, 2395, New DataTable, New DataTable, "")


        Dim oProc As New clsEmpSalaryBase(myWinApp.Controller)
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from empsalary where empsalaryid = 4459").Tables(0)
        Dim dt2 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from empsalcomp where empsalaryid = 4459").Tables(0)
        Dim nr As DataRow = dt1.Rows(0)

        'nr = myWinTables.AddNewRow(dt1)
        'nr("employeeid") = 1783
        'nr("salstructureid") = 1
        'nr("dated") = "2014-Oct-1"

        oProc.TrySave(nr, dt2)


        'Dim oProc As New clsHRProcBase
        'Dim date2 As DateTime = oProc.EndDate(Now.Date, "H")
        'fMain.myView.PrintingPress.SpecPrintReport("crpanform3a", 200)

    End Sub
    'Private Shared Sub TestAttribTable()
    '    Dim sql As String = "Select * from prodbasic"
    '    Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
    '    Dim dt2 As DataTable = myAttribBase.dtAttribTable(myWinApp, "PPR", "plnprocid", 1, "prodbasicid", dt1, "")
    '    Dim str1 As String = myAttribBase.ParamFormatXML(myWinApp, dt2)
    '    Dim str2 As String = myAttribBase.ParamWidthString(myWinApp, dt2, "plnprocid", 1)
    '    Debug.WriteLine("done")
    'End Sub
    Private Shared Sub TestPunch()
        Dim oPunch As New clsProcessPunchBase(myWinApp.Controller)
        Dim dated As DateTime = "2014-10-27"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from employees where employeeid = 1811").Tables(0)
        Dim dt2 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from ratemaster where ratemasterid = 131").Tables(0)
        Dim rShift As DataRow = oPunch.ShiftRow(oPunch.ShiftsTable(dated), dt1.Rows(0)("shiftid"))
        Dim dt3 As DataTable = oPunch.PunchTableFromDateShift(dt1.Rows(0), dt2.Rows(0), rShift, rShift)
        oPunch.LoadAttendanceData(dated, "employeeid=" & dt1.Rows(0)("employeeid"))
        Dim rAttend As DataRow = oPunch.AttendanceRow(dt1.Rows(0), dated, True)
        Dim rRate As DataRow = oPunch.oMasterData.rRateMaster(myWinApp.Controller.CommonData.GetCompanyIDFromCampus(dt1.Rows(0)("campusid")), dated)
        oPunch.PreProcessTable(rAttend, dt3)
        Dim oPut As clsPunchOutput = oPunch.ProcessRate(dt1.Rows(0), rAttend, dt3, rShift, rRate)

        Debug.WriteLine(oPunch.IsHoliday(dated, dt1.Rows(0)("campusid")))

    End Sub
    Private Shared Sub TestHoliday()
        Dim oMaster As New clsMasterDataHRP(myWinApp.Controller), oPunch As New clsProcessPunchBase(myWinApp.Controller)
        Dim dated As DateTime = "2014-Jul-1"
        Dim rRate As DataRow = oMaster.rRateMasterID(132)
        oPunch.IsHoliday(dated, rRate, 1)

    End Sub
    Private Shared Sub TestGLBal()
        Dim sql As String = "Select * from AccVouch"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        For Each r1 As DataRow In dt1.Select("", "vouchdate")
            Dim oAV As New clsAVProc(myWinApp.Controller)
            oAV.oMasterData.GetPostPeriodID("2014-Jul-01")
            oAV.LoadVouch(r1("accvouchid"))
            oAV.VSave()

        Next
    End Sub
    Private Shared Sub TestRateMaster()
        Dim sql As String = "Select * from ratemaster order by dated desc; Select * from salbenefitrate"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

        Dim nr As DataRow = myUtils.CopyOneRow(dt1.Rows(0), dt1.Clone)
        nr("dated") = "01-Dec-2014"
        Dim oCalc As New clsRateMasterBase(myWinApp.Controller)
        oCalc.TrySave(nr, dt1.DataSet.Tables(1).Clone)


    End Sub
    Private Shared Sub TestBonusMaster()
        'Dim oMaster As New clsMasterDataFICO
        'oMaster.GetPostPeriodID(1, Now.Date)

        Dim oMaster As New clsMasterDataHRP(myWinApp.Controller)
        Dim rBM As DataRow = oMaster.rBonusMasterID(13)
        Dim oLM As New clsBonusBase(myWinApp.Controller)
        oLM.CalculateBonus(rBM)
    End Sub

    Private Shared Sub TestLeaveMaster()
        'Dim oMaster As New clsMasterDataFICO
        'oMaster.GetPostPeriodID(1, Now.Date)

        Dim oMaster As New clsMasterDataHRP(myWinApp.Controller)
        Dim rLM As DataRow = oMaster.rLeaveMasterID(18)
        Dim oLM As New clsLeaveBase(myWinApp.Controller)
        oLM.CalculateLeaveBalanceLM(rLM)
    End Sub
    Private Shared Sub TestMVProcAccAss()
        'where matvouchid in (select matvouchid from matvouchitem where itemid = 14905)
        Dim sql As String = "Select * from matvouch  order by vouchdate"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        Dim oMV3 As New clsMVProcAccAss(myWinApp.Controller)
        For Each r1 As DataRow In dt1.Select
            Debug.WriteLine("Start Proc: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            Dim ds As DataSet = oMV3.SimulateLoadVouch(r1("matvouchid"))
            oMV3.LoadVouch(r1("matvouchid"))
            oMV3.GenerateVoucherDelta(ds.Tables(1), ds.Tables(0))
            oMV3.CheckBalance()
            Debug.WriteLine("Start Update: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            oMV3.UpdateBalance()
            Debug.WriteLine("End: " & r1("matvouchid") & ", " & Now.ToLocalTime)
        Next
    End Sub
    Private Shared Sub TestMVProcRes()
        'where matvouchid in (select matvouchid from matvouchitem where itemid = 14905)
        Dim sql As String = "select * from matvouch  order by vouchdate"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        Dim oMV3 As New clsMVProcQtyRes(myWinApp.Controller), oMV4 As New clsMVProcPlnRes(myWinApp.Controller)
        For Each r1 As DataRow In dt1.Select
            Debug.WriteLine("Start Proc: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            Dim ds As DataSet = oMV3.SimulateLoadVouch(r1("matvouchid"))
            oMV3.LoadVouch(r1("matvouchid"))
            oMV3.GenerateVoucherDelta(ds.Tables(1), ds.Tables(0))
            oMV3.CheckBalance()
            Dim oRet As clsProcOutput = oMV4.CheckBalance(ds.Tables(0))
            Debug.WriteLine("Start Update: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            oMV4.UpdateBalance()
            oMV3.UpdateBalance()
            Debug.WriteLine("End: " & r1("matvouchid") & ", " & Now.ToLocalTime)
        Next
    End Sub
    Private Shared Sub TestMVProcValue()
        'where matvouchid in (select matvouchid from matvouchitem where itemid = 14905)
        Dim sql As String = "select * from matvouch  order by vouchdate"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        Dim oMV1 As New clsMVProcValue(myWinApp.Controller)
        For Each r1 As DataRow In dt1.Select
            Debug.WriteLine("Start Proc: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            Dim ds As DataSet = oMV1.SimulateLoadVouch(r1("matvouchid"))
            oMV1.LoadVouch(r1("matvouchid"))
            oMV1.GenerateVoucherDelta(ds.Tables(1), ds.Tables(0))
            Dim dt2 As DataTable = oMV1.GenerateStockDelta(ds.Tables(0))
            Debug.WriteLine("Start Update: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            oMV1.UpdateBalance(dt2)
            Debug.WriteLine("End: " & r1("matvouchid") & ", " & Now.ToLocalTime)
        Next
    End Sub
    Private Shared Sub TestMVProcQtyCampus()
        'where matvouchid in (select matvouchid from matvouchitem where itemid = 14905)
        Dim sql As String = "select * from matvouch  order by vouchdate"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

        Dim oMV2 As New clsMVProcQtyCampus(myWinApp.Controller)
        For Each r1 As DataRow In dt1.Select
            Debug.WriteLine("Start Proc: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            Dim ds As DataSet = oMV2.SimulateLoadVouch(r1("matvouchid"))
            oMV2.LoadVouch(r1("matvouchid"))
            oMV2.GenerateVoucherDelta(ds.Tables(1), ds.Tables(0))
            oMV2.CheckBalance()
            Debug.WriteLine("Start Update: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            oMV2.UpdateBalance()
            Debug.WriteLine("End: " & r1("matvouchid") & ", " & Now.ToLocalTime)
        Next

    End Sub

    Private Shared Sub TestMVProcQtyDep()
        'where matvouchid in (select matvouchid from matvouchitem where itemid = 14905)
        Dim sql As String = "select * from matvouch  order by vouchdate"
        Dim dt1 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
        Dim oMV3 As New clsMVProcQtyDep(myWinApp.Controller)

        For Each r1 As DataRow In dt1.Select
            Debug.WriteLine("Start Proc: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            Dim ds As DataSet = oMV3.SimulateLoadVouch(r1("matvouchid"))
            oMV3.LoadVouch(r1("matvouchid"))
            oMV3.GenerateVoucherDelta(ds.Tables(1), ds.Tables(0))
            oMV3.CheckBalance()
            Debug.WriteLine("Start Update: " & r1("matvouchid") & ", " & Now.ToLocalTime)
            oMV3.UpdateBalance()
            Debug.WriteLine("End: " & r1("matvouchid") & ", " & Now.ToLocalTime)
        Next
    End Sub
    Private Shared Sub TransferPlnProcShop()
        Dim conn As SqlClient.SqlConnection = MaxDBConn()
        Dim dt1 As DataTable = CType(SQLHelper.Executor, clsMSSQLExecutor).ExecuteDataset(conn, Nothing, CommandType.Text, "Select * from mmlistprocess()").Tables(0)


        Dim dtPlnProc As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from plnproc").Tables(0)
        Dim dtProcShop As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from plnprocshop").Tables(0)
        For Each r1 As DataRow In dt1.Select
            Dim rr1() As DataRow = dtPlnProc.Select("proctypeidold=" & r1("proctypeid"))
            If rr1.Length > 0 Then
                Dim rr2() As DataRow = dtProcShop.Select("plnprocid=" & rr1(0)("plnprocid") & " and matdepid=" & r1("matdepid"))
                If rr2.Length = 0 Then
                    Dim nr As DataRow = myTables.AddNewRow(dtProcShop)
                    nr("matdepid") = r1("matdepid")
                    nr("plnprocid") = rr1(0)("plnprocid")

                End If
            End If
        Next
        SQLHelper.SaveResults(dtProcShop, "select * from plnprocshop")
    End Sub
    Private Shared Sub TransferIncType()
        Dim conn As SqlClient.SqlConnection = MaxDBConn()
        Dim dt1 As DataTable = CType(SQLHelper.Executor, clsMSSQLExecutor).ExecuteDataset(conn, Nothing, CommandType.Text, "Select * from procdata").Tables(0)
        Dim dt2 As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, myFuncsBase.CodeWordSQL("incentive", "inctype", "")).Tables(0)

        Dim dtPlnProc As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from plnproc").Tables(0)
        Dim dtProcIncType As DataTable = SQLHelper.ExecuteDataset(CommandType.Text, "Select * from plnprocinctype").Tables(0)
        For Each r1 As DataRow In dt1.Select
            Dim rr1() As DataRow = dtPlnProc.Select("proctypeidold=" & r1("proctypeid"))
            If rr1.Length > 0 Then
                Dim rr2() As DataRow = dtProcIncType.Select("plnprocid=" & rr1(0)("plnprocid") & " and dated='" & Format(r1("sdate"), "dd-MMM-yyyy") & "'")
                If rr2.Length = 0 Then
                    Dim nr As DataRow = myTables.AddNewRow(dtProcIncType)
                    nr("dated") = r1("sdate")
                    nr("plnprocid") = rr1(0)("plnprocid")
                    nr("separateshifts") = r1("sepshiftb")
                    Dim rr3() As DataRow = dt2.Select("tag='" & r1("prodinctypeid") & "'")
                    nr("prodinctype") = rr3(0)("codeword")
                End If
            End If
        Next
        SQLHelper.SaveResults(dtProcIncType, "select * from plnprocinctype")
    End Sub
    Private Shared Function MxEntDBConn() As SqlConnection
        Dim conn As SqlClient.SqlConnection

        'TODO: Remove ForceMaxDB parameter. Done because no database with attribute and desparam at dev time

        Dim str1 As String = "Server=TFS\SQLEXPRESS;Database=MxEntDB;Integrated Security=True;MultipleActiveResultSets=True"
        conn = New SqlClient.SqlConnection
        conn.ConnectionString = str1
        conn.Open()
        Return conn
    End Function
    Private Shared Function MaxDBConn() As SqlConnection
        Dim conn As SqlClient.SqlConnection

        'TODO: Remove ForceMaxDB parameter. Done because no database with attribute and desparam at dev time

        Dim str1 As String = "Server=BOXER\SQLOLD;Database=MaxDB;Integrated Security=True;MultipleActiveResultSets=True"
        conn = New SqlClient.SqlConnection
        conn.ConnectionString = str1
        conn.Open()
        Return conn
    End Function
    Private Shared Function TransferRoutingData()
        Dim dic As New clsCollecString(Of String)
        dic.Add("seq", "select * from plnstdseq")
        dic.Add("seqproc", "select * from plnstdseqproc")
        dic.Add("routing", "select * from plnrouting")
        dic.Add("op", "select * from plnop")
        dic.Add("opreq", "select *, plnresourceid as plnresourceid, plnresourcegroupid as plnresourcegroupid from plnopreq where plnopid is not null")
        Dim dsSource As DataSet = CType(SQLHelper.Executor, clsMSSQLExecutor).ExecuteDataset(MaxDBConn(), Nothing, CommandType.Text, dic)
        Dim obj As New clsPIDURouteBase(myWinApp.Controller)
        Dim dsTarget As DataSet = obj.dsPln

        'set autonumber=false for destination plnstdseq, plnstdseqproc, plnrouting, plnop before proceeding.

        For Each str1 As String In New String() {"seq", "seqproc", "op", "opreq", "routing"}
            myUtils.DeleteRows(dsTarget.Tables(str1).Select)
            SQLHelper.SaveResults(dsTarget.Tables(str1), dic(str1), , True)
            dsTarget.Tables(str1).AcceptChanges()
        Next

        For Each str1 As String In New String() {"seq", "seqproc", "op", "opreq", "routing"}
            myUtils.CopyRows(dsSource.Tables(str1).Select, dsTarget.Tables(str1))
        Next
        myUtils.CopyRows(dsSource.Tables("seqproc").Select, dsTarget.Tables("seqseqproc"))

        For Each str1 As String In New String() {"seq", "seqproc", "routing", "op", "opreq"}
            SQLHelper.SaveResults(dsTarget.Tables(str1), dic(str1))

        Next
        SQLHelper.SaveResults(dsTarget.Tables("seqseqproc"), "select * from plnstdseqseqproc where plnstdseqid=0")


    End Function
    Private Shared Function TestIVProcSD()
        Dim oProc As New clsIVProcSD(myWinApp.Controller, "IS")
        Dim ds As DataSet = oProc.SimulateLoadVouch(25)
        oProc.LoadVouch(25)
        oProc.GenerateVoucherDelta(ds.Tables(0), ds.Tables("invoiceitem"))
        oProc.CheckBalance()
        oProc.CheckSOBalance(ds.Tables(0).Rows(0), ds.Tables("invoiceitem"))
        oProc.UpdateBalance()

    End Function
    Private Shared Function GenerateCSVFile()
        Dim ofd As New OpenFileDialog
        Dim str1 As String = ""
        If ofd.ShowDialog = DialogResult.OK Then
            Dim myXML As New XmlDocument
            myXML.Load(ofd.FileName)
            For Each oNode As XmlNode In myXML.SelectNodes("/table/tbody/tr")
                Dim dic As New List(Of String)
                For Each XNode As XmlNode In oNode.SelectNodes("td/input")
                    Dim attr As XmlAttribute = XNode.Attributes.GetNamedItem("value")
                    dic.Add(attr.Value)
                Next
                str1 = str1 & vbCrLf & myUtils.MakeCSV(dic, ",")
            Next
        End If
        My.Computer.FileSystem.WriteAllText("c:\users2.csv", str1, False)
    End Function
    Private Shared Function MakeScore()
        Dim sql As String = "select * from accountmap"
        Dim ds As DataSet = SQLHelper.ExecuteDataset(CommandType.Text, sql)
        Dim oMap As New clsAccountMap(myWinApp.Controller)
        For Each r1 As DataRow In ds.Tables(0).Select
            r1("zscore") = oMap.CalculateScore(r1)
        Next

        SQLHelper.SaveResults(ds.Tables(0), "select * from accountmap")


    End Function
End Class
