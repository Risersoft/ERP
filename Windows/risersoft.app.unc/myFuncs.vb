Imports risersoft.app.nsa
Imports risersoft.shared.cloud

Public Class myFuncs
    Public DoRefresh As Boolean = False
    Public Sub fncMac(ByRef oView As clsWinView, ByVal MachineID As Integer, ByVal fRow As DataRow, ByVal fMode As EnumfrmMode)
        Dim f As frmMax, str1 As String

        str1 = myUtils.cStrTN(oView.ContextRow.CellValue("mactype"))
        Select Case str1.Trim.ToLower
            Case "computer"
                f = New frmPC
            Case Else
                f = New frmITMachine
        End Select
        If f.PrepForm(oView, fMode, MachineID) Then WinFormUtils.CentreForm(f, oView.fParentWin)

    End Sub
    Public Sub fncAD(ByRef oView As clsWinView)
        Dim f As frmGrid, str1 As String, dt As DataTable
        Dim myWMI As New clsmyPC

        myWMI.GetLocalComputerInfo()
        dt = WinAdHelper.ListAllADComputers(myWMI.DomainName)

        f = New frmGrid
        f.myView.mainGrid.BindView(myUtils.MakeDSfromTable(dt, False))
        f.myView.mainGrid.MainConf("showrownumber") = True
        f.myView.mainGrid.QuickConf("", True, "1-1-1-1-1-1", , "List of Computers in AD")
        WinFormUtils.CentreForm(f, oView.fParentWin)

    End Sub
End Class
