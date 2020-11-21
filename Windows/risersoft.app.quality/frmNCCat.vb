Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform
Public Class frmNCCat
    Inherits frmMax

    Public Sub InitForm()
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel)
        myView.SetGrid(Me.UltraGridCategory)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmNCCatModel = Me.InitData("frmNCCatModel", oview, prepMode, prepIdx, strXML)

        If Me.BindModel(objModel, oview) Then
            For Each gr In myView.mainGrid.myGrid.Rows
                If myUtils.cValTN(gr.Cells("NumCat").Value) > 0 Then
                    gr.Activation = ug.Activation.NoEdit
                    gr.Appearance.BackColor = System.Drawing.Color.Aqua
                End If
            Next

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Category"), btnAddNew)
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False

        If Me.ValidateData() Then
            If Me.SaveModel() Then
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim grow As ug.UltraGridRow = Nothing

        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If myView.ContextRow.Index < myView.mainGrid.myGrid.Rows.Count - 1 Then grow = myView.mainGrid.myGrid.Rows(myView.ContextRow.Index + 1)
            If myUtils.cValTN(myView.ContextRow.CellValue("NumCat")) > 0 Then
                MsgBox("This category has been used and cannot be deleted", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            Else
                myView.ContextRow.Delete(False)
                If Not grow Is Nothing Then myView.mainGrid.myGrid.ActiveRow = grow
            End If

        End If
    End Sub
End Class