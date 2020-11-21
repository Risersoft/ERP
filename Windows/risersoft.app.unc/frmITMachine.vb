Imports System.ComponentModel
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.nsa
Imports risersoft.shared.cloud

Public Class frmITMachine
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim myVueChild As New clsWinView, sqltype As String

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim ds As DataSet, dt As DataTable, sql As String, pr As DataRow

        'called from frmMain


        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sqlForm = "Select * from machines where machineid = " & myUtils.cValTN(prepIDX)
        Me.InitData(sqlForm, "pmachineid", oView, prepMode, prepIDX, strXML)

        Me.cmb_MacTypeID.ReadOnly = (frmMode = EnumfrmMode.acEditM)
        sql = "select distinct mactypeid,mactype,hasparams, param1name,param2name,param3name,param4name, param5name, param6name, param7name from mactypes where equiptype='it' order by mactype "
        dt = myUtils.AddTable(Me.dsCombo, SQLHelper.ExecuteDataset(CommandType.Text, sql), "mtype")
        codesys.SetConf(dt, Me.cmb_MacTypeID)

        myView.mainGrid.MainConf("autorowht") = True
        myView.mainGrid.QuickConf("select machineid,macmaintid,BreakOn,Cause,RestartOn,RepairBy,Cost,Details from macmaint  where machineid=" & myUtils.cValTN(frmIDX), True, "1.5-2-1.5-2-1-3", True, "Machine History")
        myView.mainGrid.PrepEdit("<BAND TABLE=""macmaint"" IDFIELD=""macmaintid"" INDEX=""0""><COL KEY=""machineid,cost,breakon,cause,restarton,repairby,details""/></BAND>", Me.btnAddDoc, Me.btnDelDoc)

        sqltype = "select mactypeid, mactype from mactypes"
        myVueChild.mainGrid.MainConf("FORMATXML") = "<COL KEY=""mactypeid"" LOOKUPSQL=""" & sqltype & """ CAPTION=""Type""/>"
        myVueChild.mainGrid.QuickConf("select machineid,pmachineid,mactypeid,MacNum,BoughtOn,WarrantyUpto,Make,Model,Speed,Capacity,StatusOK from machines where pmachineid = " & myUtils.cValTN(frmIDX) & " order by mactypeid", True, "2-1-1-1-1-1-1-1-1", True, "Configuration")
        'myVueChild.mainGrid.PrepEdit("<BAND TABLE=""machines"" IDFIELD=""machineid"" INDEX=""0""><COL KEY=""pmachineid,macnum,boughton,warrantyupto,make,model,speed,capacity""/><COL KEY=""statusOK"" VLIST=""False;Not Good|True;Good""/><COL KEY=""mactypeid"" LOOKUPSQL=""" & sqltype & """ CAPTION=""Type""/></BAND>", Me.btnAddChild, Me.btnDelChild)

        If myUtils.cValTN(myRow("pmachineid")) > 0 Then
            If frmMode = EnumfrmMode.acAddM Then Me.cmb_pmachineid.ReadOnly = True
            pr = myMacs.MachineRow(myRow("pmachineid"))
            myRow("location") = pr("location")
            myRow("username") = pr("username")
            Me.cmb_Location.ReadOnly = True
            Me.cmb_Username.ReadOnly = True
        End If
        Me.cmb_MacTypeID.Value = CInt(myUtils.cValTN(myRow("mactypeid")))
        Me.codesys.HandleCombo(Me.cmb_MacTypeID, EnumWantEvent.acForceEvent)


        PrepForm = True


    End Function
    Private Sub InitForm()


        myView.SetGrid(UltraGrid1)
        myVueChild.SetGrid(Me.UGridChild)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        Me.cmb_StatusOK.Items.Clear()
        Me.cmb_StatusOK.Items.Add(False, "Not Good")
        Me.cmb_StatusOK.Items.Add(True, "Good")

        myWinSQL.AssignCmb(Me.dsCombo, "deps", "select depname,depname from deps", Me.cmb_Location)
        myWinSQL.AssignCmb(Me.dsCombo, "pmac", "select machineid, macinfo from unclistmacs() order by macinfo", Me.cmb_pmachineid)

        Dim oPC As New clsmyPC
        oPC.GetLocalComputerInfo()
        Dim dt As DataTable = WinAdHelper.ListAllADUsers(oPC.DomainName)
        For Each r As DataRow In dt.Select("", "name")
            Me.cmb_Username.Items.Add(r("name"))
        Next

    End Sub
    Public Overrides Function VSave() As Boolean

        Me.InitError()
        If txt_macNum.TextLength = 0 Then WinFormUtils.AddError(txt_macNum, "Enter Machine Num")
        If myUtils.NullNot(Me.cmb_MacTypeID.Value) Then WinFormUtils.AddError(cmb_MacTypeID, "Enter Machine Type")
        If myUtils.NullNot(cmb_Location.SelectedRow) Then WinFormUtils.AddError(cmb_Location, "Enter Location")
        If Me.cmb_StatusOK.SelectedIndex < 0 Then WinFormUtils.AddError(Me.cmb_StatusOK, "Enter Status")
        'Me.myVueChild.mainGrid.CheckValid("StatusOK", , , , Me.eBag)

        If Me.CanSave Then
            cm.EndCurrentEdit()
            SQLHelper.SaveResults(myRow.Row.Table, Me.sqlForm)
            frmIDX = myRow("machineid")
            frmMode = EnumfrmMode.acEditM
            Me.myView.mainGrid.SaveChanges(, "machineid=" & frmIDX)


            VSave = True
        End If
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Dim hasdefs As Boolean = False, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow

        If Not Me.cmb_MacTypeID.SelectedRow Is Nothing Then gRow = Me.cmb_MacTypeID.SelectedRow
        If Not gRow Is Nothing Then hasdefs = myUtils.cBoolTN(gRow.Cells("hasparams").Value)
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

        myVueChild.ContextRow = myVueChild.mainGrid.ActiveRow
        If Not myVueChild.ContextRow Is Nothing Then
            If f.PrepForm(myVueChild, EnumfrmMode.acEditM, myVueChild.ContextRow.CellValue("machineid")) Then
                f.ShowDialog()
                myVueChild.RefreshGrid()
            End If
        End If
    End Sub


    Private Sub btnAddChild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChild.Click
        Dim f As New frmITMachine

        If f.PrepForm(myVueChild, EnumfrmMode.acAddM, "", "<PARAMS PMACHINEID=""" & frmIDX & """/>") Then
            f.ShowDialog()
            myVueChild.RefreshGrid()
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
