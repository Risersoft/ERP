Public Class frmMacSpare
    Inherits frmMax
    Dim WithEvents codesys As New clsCodeSystem

    Public Sub initForm()
        WinFormUtils.SetButtonConf(btnOK, btnCancel)
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        If Me.GetSoftData(oview, prepmode, prepIDX) Then
            If Me.BindModel(Me.pView.fParent.Model) Then
                If prepmode = EnumfrmMode.acEditM Then
                    CtlItemVMS1.ItemVMSID = myUtils.cValTN(myRow("ItemVMSId"))
                    combo_ItemId.Value = Me.CtlItemVMS1.myParentID
                End If
                Me.codesys.HandleCombo(Me.combo_ItemId, IIf(frmMode = EnumfrmMode.acAddM, EnumWantEvent.acForceEvent, EnumWantEvent.acNoEvent))
                FormPrepared = True
            End If
        End If
        Return Me.FormPrepared
    End Function

    Public Overloads Function BindModel(NewModel As clsFormDataModel) As Boolean
        Me.codesys.SetConf(NewModel.dsCombo.Tables("Items"), Me.combo_ItemId, Me.combo_ItemName, Me.combo_ItemUnit)
        Return True
    End Function

    Private Sub codesys_ItemChanged() Handles codesys.ItemChanged
        Me.CtlItemVMS1.InitVMS(myUtils.cValTN(combo_ItemId.Value), , EnumWantEvent.acForceEvent)
    End Sub

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        If myUtils.NullNot(combo_ItemId.Value) Then WinFormUtils.AddError(combo_ItemId, "Select Item Code")
        If Me.CtlItemVMS1.ItemVMSID = 0 Then WinFormUtils.AddError(Me.CtlItemVMS1, "Select Item Specification")
        If Me.CanSave Then
            cm.EndCurrentEdit()
            myRow("ItemVMSId") = Me.CtlItemVMS1.ItemVMSID
            myRow("ItemName") = Me.combo_ItemName.Text
            myRow("ItemCode") = Me.combo_ItemId.Text & " - " & Me.CtlItemVMS1.SpecWrite
            Me.SaveSoftData()
            VSave = True
        End If
    End Function
End Class
