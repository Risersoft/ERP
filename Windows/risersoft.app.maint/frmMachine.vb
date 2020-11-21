Imports System.Windows.Forms
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmMachine
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem
    Dim myViewSpare, MyViewMaint As New clsWinView
    Dim dvMatDep As DataView

    Private Sub InitForm()
        myView.SetGrid(UltraGrid1)
        myViewSpare.SetGrid(Me.UltraGrid2)
        MyViewMaint.SetGrid(Me.UltraGrid3)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMachineModel = Me.InitData("frmMachineModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            If frmMode = EnumfrmMode.acEditM OrElse frmMode = EnumfrmMode.acCopyM Then Me.cmb_MacTypeID.Value = CInt(myUtils.cValTN(myRow("mactypeid")))
            Me.codesys.HandleCombo(Me.cmb_MacTypeID, EnumWantEvent.acForceEvent)

            HandleDate(myUtils.cDateTN(myRow("InstalledOn"), DateTime.MinValue))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Machine"), Me.btnAddDoc, Me.btnDelDoc)
            MyViewMaint.PrepEdit(Me.Model.GridViews("Maint"), Me.btnAddMaint, Me.btnDelMaint)
            myViewSpare.PrepEdit(Me.Model.GridViews("Spare"), , Me.btnDelSpare)

            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "DepsMat", "", Me.cmb_matdepid,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "AssetClass", "", Me.cmb_AssetClass)
            myWinSQL.AssignCmb(Me.dsCombo, "CapRes", "", Me.cmb_PlnCapResID)
            Me.cmb_StatusOK.ValueList = Me.Model.ValueLists("StatusOK").ComboList

            myWinSQL.AssignCmb(Me.dsCombo, "Shift", "", Me.cmb_shiftid)
            codesys.SetConf(Me.dsCombo.Tables("MType"), Me.cmb_MacTypeID)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Dim hasdefs As Boolean = False, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim lbl As Label, txt1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        If Not Me.cmb_MacTypeID.SelectedRow Is Nothing Then gRow = Me.cmb_MacTypeID.SelectedRow
        If Not gRow Is Nothing Then hasdefs = myUtils.cBoolTN(gRow.Cells("hasparams").Value)
        If hasdefs Then
            Me.UltraTabControl1.Tabs("params").Visible = True
            For i As Integer = 1 To 10
                lbl = New Label() {lblX, lblY, lblZ, lblS, lblp, lblq, lblr, lbla, lblb, lblc}(i - 1)
                txt1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor() {txt_Param1, txt_Param2, txt_Param3, txt_Param4, txt_Param5, txt_Param6, txt_Param7, txt_Param8, txt_Param9, txt_Param10}(i - 1)
                lbl.Text = myUtils.cStrTN(gRow.Cells("param" & i & "name").Value).Trim
                If lbl.Text.Length > 0 Then
                    lbl.Visible = True
                    txt1.Visible = True
                Else
                    lbl.Visible = False
                    txt1.Visible = False
                End If
            Next
        Else
            Me.UltraTabControl1.Tabs("params").Visible = False
            For i As Integer = 1 To 10
                myRow("param" & i) = DBNull.Value
            Next
        End If
    End Sub

    Private Sub btnAddSpare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSpare.Click
        Dim f As frmMacSpare = New frmMacSpare
        If f.PrepForm(Me.myViewSpare, EnumfrmMode.acAddM, "") Then f.ShowDialog()
    End Sub

    Private Sub btnEditSpare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditSpare.Click
        Dim f As frmMacSpare = New frmMacSpare
        If f.PrepForm(Me.myViewSpare, EnumfrmMode.acEditM, "") Then f.ShowDialog()
    End Sub

    Private Sub dt_InstalledOn_Leave(sender As Object, e As EventArgs) Handles dt_InstalledOn.Leave, dt_InstalledOn.AfterCloseUp
        HandleDate(dt_InstalledOn.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class

