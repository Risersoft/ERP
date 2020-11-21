Imports ug = Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform

Public Class frmMacType
    Inherits frmMax
    Dim myViewParam As New clsWinView

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        Me.UltraTabControl1.Tabs(2).Visible = (myUtils.cStrTN(myWinApp.Vars("appcode")).Trim.ToLower = "unc")
        Me.UltraTabControl1.Tabs("sys").Visible = myWinPolice.IsAllowedUser("abhishek.singhal", "")
        Me.myView.SetGrid(Me.UltraGrid1)
        Me.myViewParam.SetGrid(Me.UltraGrid2)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmMacTypeModel = Me.InitData("frmMacTypeModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            myWinSQL.AssignCmb(Me.dsCombo, "Equiptype", "", Me.cmb_EquipType)

            If frmMode = EnumfrmMode.acEditM Then
                If Not myUtils.NullNot(myRow("pic")) Then
                    WinFormUtils.FillPB(Me.pic_PicPerson, myRow("pic"))
                    rePicsize(Me.pic_PicPerson, 0)
                End If
            End If
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("MaintParam"), Me.btnAdd, Me.btnDel)
            myView.mainGrid.myGrid.DisplayLayout.Bands(0).SortedColumns.Add("sortindex", False, False)
            myViewParam.PrepEdit(Me.Model.GridViews("Param"), Me.btnAddParam, Me.btnDelParam)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If Me.ValidateData() Then
            If hasNewImg Then WinFormUtils.FillDSFromPB(myRow.Row, "Pic", Me.pic_PicPerson)
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim gRow1 As ug.UltraGridRow
        myView.ContextRow = myView.mainGrid.ActiveRow
        If (Not myView.ContextRow Is Nothing) AndAlso myView.ContextRow.Index > 0 Then
            gRow1 = myView.mainGrid.myGrid.Rows(myView.ContextRow.Index - 1)
            gRow1.Cells("sortindex").Value = gRow1.Cells("sortindex").Value + 1
            myView.ContextRow.CellValue("sortindex") = myView.ContextRow.CellValue("sortindex") - 1
            gRow1.RefreshSortPosition()
            CType(myView.ContextRow.Row, UltraGridRow).RefreshSortPosition()
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim gRow1 As ug.UltraGridRow
        myView.ContextRow = myView.mainGrid.ActiveRow
        If (Not myView.ContextRow Is Nothing) AndAlso myView.ContextRow.Index < myView.mainGrid.myGrid.Rows.Count - 1 Then
            gRow1 = myView.mainGrid.myGrid.Rows(myView.ContextRow.Index + 1)
            gRow1.Cells("sortindex").Value = gRow1.Cells("sortindex").Value - 1
            myView.ContextRow.CellValue("sortindex") = myView.ContextRow.CellValue("sortindex") + 1
            gRow1.RefreshSortPosition()
            CType(myView.ContextRow.Row, UltraGridRow).RefreshSortPosition()
        End If
    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        Dim gRow1 As ug.UltraGridRow, i As Integer = 0
        For Each gRow1 In myView.mainGrid.myGrid.Rows
            i = i + 1
            gRow1.Cells("sortindex").Value = i
        Next
        myView.mainGrid.myGrid.UpdateData()
        myView.mainGrid.myGrid.Rows.Refresh(ug.RefreshRow.ReloadData)
    End Sub

    Private Sub UltraButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton4.Click
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Me.pic_PicPerson.Image = System.Drawing.Image.FromFile(Me.OpenFileDialog1.FileName)
            hasNewImg = True
            rePicsize(Me.pic_PicPerson, 0)
        End If
    End Sub
End Class
