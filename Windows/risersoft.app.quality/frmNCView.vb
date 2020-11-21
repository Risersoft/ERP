Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmNCView
    Inherits frmMax
    Public Sub initForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmNCViewModel = Me.InitData("frmNCViewModel", oview, prepMode, prepIdx, strXML)

        If Me.BindModel(objModel, oview) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_matdepid)
            Me.cmb_raisedby.ValueList = Me.Model.ValueLists("RaisedBy").ComboList
            Me.cmb_WorkBy.ValueList = Me.Model.ValueLists("WorkBy").ComboList
            Me.cmb_rectifyBy.ValueList = Me.Model.ValueLists("RectifyBy").ComboList
            myWinSQL.AssignCmb(Me.dsCombo, "Serial", "", Me.cmb_ProdSerialID)


            Dim r1 As DataRow = Me.Model.SelectedRow("PidUnitId")
            If (Not r1 Is Nothing) Then
                Me.Text = myUtils.cStrTN(r1("PidInfo"))
                Me.textParty.Text = myUtils.cStrTN(r1("PartyName"))
                Me.textRating.Text = myUtils.cStrTN(r1("DescripWO"))
                PrepForm = True
            End If

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If (Not Me.pView.mainGrid.myGrid.ActiveRow Is Nothing) AndAlso pView.mainGrid.myGrid.Rows.Count > pView.mainGrid.myGrid.ActiveRow.Index + 1 Then
            pView.mainGrid.myGrid.ActiveRow = pView.mainGrid.myGrid.Rows(pView.mainGrid.myGrid.ActiveRow.Index + 1)
            Me.PrepForm(pView, EnumfrmMode.acEditM, pView.mainGrid.myGrid.ActiveRow.Cells("ProdNCItemId").Value)
        ElseIf pView.mainGrid.myGrid.Rows.Count > 0 Then
            pView.mainGrid.myGrid.ActiveRow = pView.mainGrid.myGrid.Rows(0)
            Me.PrepForm(pView, EnumfrmMode.acEditM, pView.mainGrid.myGrid.ActiveRow.Cells("ProdNCItemId").Value)
        End If
        pView.mainGrid.myGrid.ActiveRow.Selected = True
        pView.fParentWin.Refresh()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        If (Not Me.pView.mainGrid.myGrid.ActiveRow Is Nothing) AndAlso pView.mainGrid.myGrid.ActiveRow.Index > 0 Then
            pView.mainGrid.myGrid.ActiveRow = pView.mainGrid.myGrid.Rows(pView.mainGrid.myGrid.ActiveRow.Index - 1)
            Me.PrepForm(pView, EnumfrmMode.acEditM, pView.mainGrid.myGrid.ActiveRow.Cells("ProdNCItemId").Value)
        ElseIf pView.mainGrid.myGrid.Rows.Count > 0 Then
            pView.mainGrid.myGrid.ActiveRow = pView.mainGrid.myGrid.Rows(pView.mainGrid.myGrid.Rows.Count - 1)
            Me.PrepForm(pView, EnumfrmMode.acEditM, pView.mainGrid.myGrid.ActiveRow.Cells("ProdNCItemId").Value)
        End If
        pView.mainGrid.myGrid.ActiveRow.Selected = True
        pView.fParentWin.Refresh()
    End Sub
End Class