Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.dataporter
Imports risersoft.app.nsa
Imports risersoft.shared.cloud

Public Class frmPC
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim myVueChild As New clsWinView, myVueShare As New clsWinView, myVueSW As New clsWinView, sqltype As String
    Dim f As New frmPCInfo, oPC As clsmyPC, CapacityParam As String = ""

    Public Overloads Function PrepForm(ByVal r As DataRow, ByVal dsmaint As DataSet) As Boolean
        Dim dt As DataTable, ds As DataSet

        'called from computer browser
        Me.BindData(r)
        Me.cmb_MacTypeID.ReadOnly = True

        If myView.mainGrid.myDv Is Nothing Then
            myView.mainGrid.BindView(dsmaint, , 0)
            myView.mainGrid.QuickConf("", True, "1.5-2-1.5-2-1-3", True, "Machine History")
        End If
        myView.mainGrid.myDv.RowFilter = "machineid=" & myRow("machineid")

        If myVueChild.mainGrid.myDv Is Nothing Then
            myVueChild.myCMain("CONSUMEHIDECOLSWIDTH") = False
            myVueChild.myCMain("complexview") = True
            myVueChild.myCMain("HIDECOLS") = myWinData.GenColList(myWinData.SelectCols(r.Table, "", "*"), "MacType,MacNum,BoughtOn,WarrantyUpto,Make,Model,Speed,Capacity,Status")
            myVueChild.mainGrid.QuickConf("", True, "1-1-1-1-1-1-1-1-1", True, "", False)
            myVueChild.mainGrid.GenMiscComplex(r.Table.DataSet, New DataTable() {r.Table}, New clsBandConf() {myVueChild.myCMain}, True)
            'myVueChild.mainGrid.BindView(r.Table.DataSet, , True)
        End If


        myVueChild.mainGrid.myDv.RowFilter = "pmachineid=" & myRow("machineid")
        Me.Panel4.Visible = False

        'Me.DoPropGrid(r.Table.DataSet)
        If Not myUtils.NullNot(myRow("pcdata")) Then
            ds = myUtils.dataSetFromXML(myZip.ExpandString(myRow("pcdata")))
            If ds.Tables.Count > 0 Then f.LoadFromDataSet(ds)
        End If

        Return True

    End Function
    Public Sub DoPropGrid(ByVal ds As DataSet)
        Dim dt As DataTable

        dt = Me.Controller.Data.LeftJoin(ds.Tables("mactypeparams"), ds.Tables("macparams"), "mactypeparamid")
        Me.PopulatePropertyGrid(dt)
    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim ds As DataSet, dt As DataTable, sql As String

        'called from frmMain

        If prepMode = EnumfrmMode.acAddM Then prepIdx = 0
        sqlForm = "Select * from machines where machineid = " & myUtils.cValTN(prepIdx)
        Me.InitData(sqlForm, "pmachineid", oView, prepMode, prepIdx, strXML)

        sql = "select distinct mactypeid,mactype,hasparams, param1name,param2name,param3name,param4name, param5name, param6name, param7name from mactypes where equiptype='it' order by mactype "
        dt = myUtils.AddTable(Me.dsCombo, SQLHelper.ExecuteDataset(CommandType.Text, sql), "mtype")
        codesys.SetConf(dt, Me.cmb_MacTypeID)

        myView.myCMain("autorowht") = True
        myView.mainGrid.QuickConf("select machineid,macmaintid,BreakOn,Cause,RestartOn,RepairBy,Cost,Details from macmaint  where machineid=" & myUtils.cValTN(frmIDX), True, "1.5-2-1.5-2-1-3", True, "Machine History")
        myView.mainGrid.PrepEdit("<BAND TABLE=""macmaint"" IDFIELD=""macmaintid"" INDEX=""0""><COL KEY=""machineid,cost,breakon,cause,restarton,repairby,details""/></BAND>", Me.btnAddDoc, Me.btnDelDoc)

        sqltype = "select mactypeid, mactype from mactypes"
        myVueChild.myCMain("FORMATXML") = "<COL KEY=""mactypeid"" LOOKUPSQL=""" & sqltype & """ CAPTION=""Type""/>"
        myVueChild.mainGrid.QuickConf("select machineid,pmachineid,MacTypeid,MacNum,BoughtOn,WarrantyUpto,Make,Model,Speed,Capacity,StatusOK from machines where pmachineid = " & myUtils.cValTN(frmIDX) & " order by mactypeid", True, "2-1-1-1-1-1-1-1-1", True, "Configuration")
        'myVueChild.mainGrid.PrepEdit("<BAND TABLE=""machines"" IDFIELD=""machineid"" INDEX=""0""><COL KEY=""pmachineid,macnum,boughton,warrantyupto,make,model,speed,capacity""/><COL KEY=""statusOK"" VLIST=""False;Not Good|True;Good""/><COL KEY=""mactypeid"" LOOKUPSQL=""" & sqltype & """ CAPTION=""Type""/></BAND>", Me.btnAddChild, Me.btnDelChild)

        myVueShare.mainGrid.QuickConf("select pcshareid,machineid,ShareName, Path, Permissions from PCShares where machineid = " & myUtils.cValTN(frmIDX), True, "1-2-3", True, "Shares")
        myVueShare.mainGrid.PrepEdit("<BAND TABLE=""pcshares"" IDFIELD=""pcshareid"" INDEX=""0""><COL KEY=""machineid,ShareName, Path, Permissions""/></BAND>", , , , EnumEditType.acCommandOnly)

        myVueSW.mainGrid.QuickConf("select pcsoftwareid,machineid,Publisher,SWName,Version from PCSoftware where machineid = " & myUtils.cValTN(frmIDX), True, "3-1", True, "Software")
        myVueSW.mainGrid.PrepEdit("<BAND TABLE=""pcsoftware"" IDFIELD=""pcsoftwareid"" INDEX=""0""><COL KEY=""machineid,publisher,SWName,Version""/></BAND>", , , , EnumEditType.acCommandOnly)

        If frmMode = EnumfrmMode.acEditM Then
            Me.DoPropGrid(myMacs.MachineDataSet(myRow("machineid")))
        ElseIf frmMode = EnumfrmMode.acCopyM Then
            Me.DoPropGrid(myMacs.MachineDataSet(Me.CopyIDX))
        Else
            myRow("mactypeid") = myWinUtils.FindRow(Me.cmb_MacTypeID, "mactype", "computer").Cells("mactypeid").Value
            If myUtils.cValTN(myRow("pmachineid")) > 0 Then Me.cmb_pmachineid.ReadOnly = True
        End If

        If Not myUtils.NullNot(myRow("pcdata")) Then
            ds = myUtils.dataSetFromXML(myZip.ExpandString(myRow("pcdata")))
            If ds.Tables.Count > 0 Then f.LoadFromDataSet(ds)
        End If

        Me.cmb_MacTypeID.Value = CInt(myUtils.cValTN(myRow("mactypeid")))
        Me.codesys.HandleCombo(Me.cmb_MacTypeID, EnumWantEvent.acForceEvent)


        PrepForm = True


    End Function
    Public Sub PopulatePropertyGrid(ByVal dt As DataTable)
        Dim r1 As DataRow, bag3 As PropertyTable

        bag3 = New PropertyTable()
        For Each r1 In dt.Select("machineid=" & myRow("machineid"))
            Dim ps As New PropertySpec(r1("paramcode"), GetType(String), r1("paramgroup"), r1("paramname"), "")
            ps.Attributes = New Attribute() {ReadOnlyAttribute.Yes}
            bag3.Properties.Add(ps)
            bag3(r1("paramcode")) = r1("paramvalue")
            ' Assign values to the properties above.
            'bag3("Fruit") = Fruit.Apple
            'bag3("Picture") = Nothing
            'bag3("Typeface") = New Font("Times New Roman", 12.0F)
            'bag3("Some Boolean") = True
            'bag3("Number") = 1234567890L

        Next
        Me.PropertyGrid1.SelectedObjects = New PropertyBag() {bag3}
        'bag3.Properties.Add(New PropertySpec("Fruit", GetType(Fruit), Nothing, Nothing, Fruit.Orange))
        'bag3.Properties.Add(New PropertySpec("Picture", GetType(Image), "Some Category", "This is a sample description."))
        'bag3.Properties.Add(New PropertySpec("Typeface", GetType(Font), "Another Category", Nothing, New Font("Tahoma", 8.25F)))
        'bag3.Properties.Add(New PropertySpec("Some Boolean", "System.Boolean", "Some Category", Nothing, False))
        'bag3.Properties.Add(New PropertySpec("Number", "System.Int64", Nothing, "A big number.", 1234567890L))

        ' Create a property that uses additional attributes.

    End Sub
    Private Sub InitForm()


        oPC = New clsmyPC
        f.AddtoTab(Me.UltraTabControl1, "sysinfo", True)


        myView.SetGrid(UltraGrid1)
        myVueChild.SetGrid(Me.UGridChild)
        myVueShare.SetGrid(Me.UltraGrid2)
        myVueSW.SetGrid(Me.UltraGrid3)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        Me.cmb_StatusOK.Items.Clear()
        Me.cmb_StatusOK.Items.Add(False, "Not Good")
        Me.cmb_StatusOK.Items.Add(True, "Good")

        myWinSQL.AssignCmb(Me.dsCombo, "deps", "select depname,depname from deps", Me.cmb_Location)

        oPC.GetLocalComputerInfo()
        Dim dt As DataTable = WinAdHelper.ListAllADUsers(oPC.DomainName)
        For Each r As DataRow In dt.Select("", "name")
            Me.cmb_Username.Items.Add(r("name"))
        Next
        Me.UltraTabControl1.Tabs("sys").Visible = myWinPolice.IsAllowedUser("abhishek.singhal", "")

    End Sub
    Public Overrides Function VSave() As Boolean

        Me.InitError()
        If txt_macNum.TextLength = 0 Then WinFormUtils.AddError(txt_macNum, "Enter Machine Num")
        If myUtils.NullNot(Me.cmb_MacTypeID.Value) Then WinFormUtils.AddError(cmb_MacTypeID, "Enter Machine Type")
        If myUtils.NullNot(cmb_Location.SelectedRow) Then WinFormUtils.AddError(cmb_Location, "Enter Location")
        If Me.cmb_StatusOK.SelectedIndex < 0 Then WinFormUtils.AddError(Me.cmb_StatusOK, "Enter Status")
        If Me.cmb_Username.Text.Trim.Length > 0 AndAlso (Me.cmb_Username.SelectedItem Is Nothing) Then WinFormUtils.AddError(Me.cmb_Username, "Select User or leave empty")

        If Me.CanSave Then
            cm.EndCurrentEdit()
            If CapacityParam.Trim.Length > 0 Then myRow("capacity") = myRow(CapacityParam) Else myRow("capacity") = "-"
            SQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
            frmIDX = myRow("machineid")
            frmMode = EnumfrmMode.acEditM
            Me.myView.mainGrid.SaveChanges(, "machineid=" & frmIDX)
            Me.myVueShare.mainGrid.SaveChanges(, "machineid=" & frmIDX)
            Me.myVueSW.mainGrid.SaveChanges(, "machineid=" & frmIDX)

            VSave = True
        End If
    End Function

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ds As DataSet

        If Me.VSave Then
            ds = myMacs.MachineDataSet(myRow("machineid"))
            Using oWMI As clsWMI = New clsWMI(ds.Tables(0), Me.txt_MacName.Text.Trim, Nothing)
                oWMI.Populate(True)
                oWMI.AlterDS(ds)
            End Using
            SQLHelper.SaveResults(ds.Tables(0), "select machineid, mactypeid, pmachineid, make, model, speed, capacity,username from machines")
            SQLHelper.SaveResults(ds.Tables(1), "select * from macparams")
            SQLHelper.SaveResults(ds.Tables("shares"), "select * from pcshares")
            SQLHelper.SaveResults(ds.Tables("sw"), "select * from pcsoftware")
            Try
                Me.PrepForm(pView, frmMode, frmIDX)
            Catch ex As Exception
                MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            End Try

        Else
            If Me.txt_MacName.Text.Trim.Length > 0 Then
                Dim f As frmSysInfo = New frmSysInfo
                If f.PrepForm(myView, EnumfrmMode.acEditM, Me.txt_MacName.Text) Then
                    f.ShowDialog()
                End If

            End If
        End If

    End Sub

    Private Sub bgw1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgw1.DoWork
        Dim nr As DataRow

        f.mds = oPC.GetPCDataSet(Me.txt_MacName.Text, bgw1, e)
        myRow("pcdata") = myZip.CompressString(myUtils.XMLFromDataSet(f.mds))

        myUtils.DeleteRows(myVueShare.mainGrid.myDS.Tables(0).Select)
        For Each r1 As DataRow In f.mds.Tables("WIn32_Share").Select
            nr = myUtils.CopyOneRow(r1, myVueShare.mainGrid.myDS.Tables(0))
            nr("sharename") = r1("Caption")
        Next

        myUtils.DeleteRows(myVueSW.mainGrid.myDS.Tables(0).Select)
        For Each r1 As DataRow In f.mds.Tables("WIn32_Software").Select
            nr = myUtils.CopyOneRow(r1, myVueSW.mainGrid.myDS.Tables(0))
            nr("swname") = r1("name")
        Next

    End Sub

    Private Sub bgw1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bgw1.ProgressChanged
        Dim dicres As clsCollecString(Of String) = e.UserState

        If e.ProgressPercentage < Me.UltraProgressBar1.Maximum Then
            Me.UltraProgressBar1.Value = e.ProgressPercentage
        Else
            Me.UltraProgressBar1.Value = Me.UltraProgressBar1.Maximum
        End If
        Me.UltraProgressBar1.Text = dicres("pcprog") & " ([Formatted])"

    End Sub
    Private Sub bgw1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw1.RunWorkerCompleted
        Me.UltraProgressBar1.Visible = False
        f.LoadFromDataSet(f.mds)
    End Sub
    Private Sub btnViewWMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewWMI.Click
        Me.UltraTextEditor1.Text = myWMISecurity.ViewSecurity(Me.txt_MacName.Text, "root\cimv2", True)
    End Sub

    Private Sub btnCreatePerm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreatePerm.Click
        Me.UltraTextEditor1.Text = myWMISecurity.ModSecurity(Me.txt_MacName.Text, "root\cimv2", True, "KANOHAR\MIS", "REMOTEACCESS", True)
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        If Me.txt_MacName.Text.Trim.Length > 0 Then
            Me.UltraProgressBar1.Value = 0
            Me.UltraProgressBar1.Text = "[Formatted]"
            Me.UltraProgressBar1.Visible = True
            bgw1.RunWorkerAsync()
        Else
            MsgBox("Machine Name not Entered!", MsgBoxStyle.Information, myWinApp.Vars("appname"))
        End If
    End Sub
    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Dim hasdefs As Boolean = False, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        If Not Me.cmb_MacTypeID.SelectedRow Is Nothing Then gRow = Me.cmb_MacTypeID.SelectedRow
        If Not gRow Is Nothing Then hasdefs = myUtils.cBoolTN(gRow.Cells("hasparams").Value)
        CapacityParam = ""
        If hasdefs Then
            Me.UltraTabControl1.Tabs("params").Visible = True
            Me.lblX.Text = myUtils.cStrTN(gRow.Cells("param1name").Value).Trim
            Me.lblY.Text = myUtils.cStrTN(gRow.Cells("param2name").Value).Trim
            Me.lblZ.Text = myUtils.cStrTN(gRow.Cells("param3name").Value).Trim
            Me.lblS.Text = myUtils.cStrTN(gRow.Cells("param4name").Value).Trim
            Me.lblp.Text = myUtils.cStrTN(gRow.Cells("param5name").Value).Trim
            Me.lblq.Text = myUtils.cStrTN(gRow.Cells("param6name").Value).Trim
            Me.lblr.Text = myUtils.cStrTN(gRow.Cells("param7name").Value).Trim
            If Me.lblX.Text.Length > 0 Then Me.lblX.Visible = True : Me.txt_Param1.Visible = True Else Me.lblX.Visible = False : Me.txt_Param1.Visible = False
            If Me.lblY.Text.Length > 0 Then Me.lblY.Visible = True : Me.txt_Param2.Visible = True Else Me.lblY.Visible = False : Me.txt_Param2.Visible = False
            If Me.lblZ.Text.Length > 0 Then Me.lblZ.Visible = True : Me.txt_Param3.Visible = True Else Me.lblZ.Visible = False : Me.txt_Param3.Visible = False
            If Me.lblS.Text.Length > 0 Then Me.lblS.Visible = True : Me.txt_Param4.Visible = True Else Me.lblS.Visible = False : Me.txt_Param4.Visible = False
            If Me.lblp.Text.Length > 0 Then Me.lblp.Visible = True : Me.txt_Param5.Visible = True Else Me.lblp.Visible = False : Me.txt_Param5.Visible = False
            If Me.lblq.Text.Length > 0 Then Me.lblq.Visible = True : Me.txt_Param6.Visible = True Else Me.lblq.Visible = False : Me.txt_Param6.Visible = False
            If Me.lblr.Text.Length > 0 Then Me.lblr.Visible = True : Me.txt_Param7.Visible = True Else Me.lblr.Visible = False : Me.txt_Param7.Visible = False
            For i As Integer = 1 To 7
                If myUtils.InStrList(myUtils.cStrTN(gRow.Cells("param" & i & "name").Value), "hdd") Then
                    CapacityParam = "param" & i
                    Exit For
                End If
            Next
        Else
            Me.UltraTabControl1.Tabs("params").Visible = False
            myRow("param1") = DBNull.Value
            myRow("param2") = DBNull.Value
            myRow("param3") = DBNull.Value
            myRow("param4") = DBNull.Value
            myRow("param5") = DBNull.Value
            myRow("param6") = DBNull.Value
            myRow("param7") = DBNull.Value
        End If

    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditChild.Click
        Dim f As New frmITMachine

        If Me.VSave Then
            myVueChild.ContextRow = myVueChild.mainGrid.ActiveRow
            If Not myVueChild.ContextRow Is Nothing Then
                If f.PrepForm(myVueChild, EnumfrmMode.acEditM, myVueChild.ContextRow.CellValue("machineid")) Then
                    f.ShowDialog()
                    myVueChild.RefreshGrid()
                End If
            End If
        End If
    End Sub


    Private Sub btnAddChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChild.Click
        Dim f As New frmITMachine

        If Me.VSave Then
            If f.PrepForm(myVueChild, EnumfrmMode.acAddM, "", "<PARAMS PMACHINEID=""" & frmIDX & """/>") Then
                f.ShowDialog()
                myVueChild.RefreshGrid()
            End If
        End If
    End Sub

    Private Sub btnDelChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelChild.Click
        Dim sql As String

        myVueChild.ContextRow = myVueChild.mainGrid.ActiveRow
        If Not myVueChild.ContextRow Is Nothing Then
            sql = "Delete from machines where machineid = " & myUtils.cValTN(myVueChild.ContextRow.CellValue("machineid"))
            If MsgBox("Are you sure?", MsgBoxStyle.YesNo, myWinApp.Vars("appname")) = MsgBoxResult.Yes Then
                SQLHelper.ExecuteNonQuery(CommandType.Text, sql)
                myVueChild.RefreshGrid()
            End If
        End If
    End Sub
End Class
