Imports System.Windows.Forms
Imports risersoft.app.mxform

Public Class frmInstru
    Inherits frmMax
    Dim myVueUC, myVuePM, myVueBD As New clsWinView
    Dim WithEvents codesys As New clsCodeSystem

    Private Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        myView.SetGrid(Me.UltraGridCH)
        myVueUC.SetGrid(Me.UltraGridUC)
        myVuePM.SetGrid(Me.UltraGridPM)
        myVueBD.SetGrid(Me.UltraGridBD)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmInstruModel = Me.InitData("frmInstruModel", oview, prepMode, prepIdx, strXML)

        If Me.BindModel(objModel, oview) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_matdepid)

            codesys.SetConf(Me.dsCombo.Tables("MacType"), Me.cmb_MacTypeID)
            If frmMode = EnumfrmMode.acEditM OrElse frmMode = EnumfrmMode.acCopyM Then Me.cmb_MacTypeID.Value = CInt(myUtils.cValTN(myRow("mactypeid")))
            Me.codesys.HandleCombo(Me.cmb_MacTypeID, EnumWantEvent.acForceEvent)

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("CH"), Me.btnAddInstru, Me.btnDelInstru)
            myVueUC.PrepEdit(Me.Model.GridViews("UC"), Me.btnAddRange, Me.btnDelRange)
            myVuePM.PrepEdit(Me.Model.GridViews("PM"), Me.btnAddMaint, Me.btnDelMaint)
            myVueBD.PrepEdit(Me.Model.GridViews("BD"), Me.btnAddBD, Me.btnDelBD)

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
        Dim HasDefs As Boolean = False, gRow As Infragistics.Win.UltraWinGrid.UltraGridRow
        Dim lbl As Label, txt1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        If Not Me.cmb_MacTypeID.SelectedRow Is Nothing Then gRow = Me.cmb_MacTypeID.SelectedRow
        If Not gRow Is Nothing Then HasDefs = myUtils.cBoolTN(gRow.Cells("hasparams").Value)
        If HasDefs Then
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
End Class