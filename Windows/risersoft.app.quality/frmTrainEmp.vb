Imports ug = Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform
Public Class frmTrainEmp
    Inherits frmMax
    Dim oDown As ug.UltraDropDown

    Private Sub InitForm()
        Me.myView.SetGrid(Me.UltraGridTraining)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmTrainEmpModel = Me.InitData("frmTrainEmpModel", oView, prepMode, prepIDX, strXML)
        If Me.BindModel(objModel, oView) Then

            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("Training"), Me.btnAddDoc, Me.btnDelDoc)
            oDown = CType(myView.mainGrid.myGrid.DisplayLayout.Bands(0).Columns("EmployeeID").ValueList, ug.UltraDropDown)
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

    Private Sub UltraGrid1_AfterCellUpdate(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridTraining.AfterCellUpdate
        If e.Cell.Column.Key.ToLower = "EmployeeID" AndAlso (Not oDown Is Nothing) Then
            Dim gRow As ug.UltraGridRow = myWinUtils.FindRow(oDown, "EmployeeID", myUtils.cValTN(e.Cell.Value), True)
            If Not gRow Is Nothing Then e.Cell.Row.Cells("DepID").Value = gRow.Cells("DepID").Value
        End If
    End Sub

    Private Sub UltraGrid1_AfterCellListCloseUp(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles UltraGridTraining.AfterCellListCloseUp
        Me.myView.mainGrid.myGrid.Update()
    End Sub
End Class