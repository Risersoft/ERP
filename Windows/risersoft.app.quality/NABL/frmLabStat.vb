Imports ug = Infragistics.Win.UltraWinGrid
Public Class frmLabStat
    Inherits frmMax
    Dim myVueInstru As New clsWinView, strPrep As String

    Public Sub initForm()
        Dim sql, str1, str2, arr() As String, r As DataRow

        myView.SetGrid(Me.UltraGrid1)
        myVueInstru.SetGrid(Me.UltraGrid2)

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, sql2, str1 As String, dt As DataTable

        If prepMode = EnumfrmMode.acEditM Then
            sql = "select *, depname + ' Testing Lab' as labname from depsmat where matdepid = " & prepIDX
            Me.InitData(sql, "", oView, prepMode, prepIDX, strXML)

            myView.myCMain("sortcolsasc") = "typetestid,physicalpropid,instrusetnum"
            myView.myCMain("allowmerge") = True
            myView.mainGrid.QuickConf("select testmeasparamid, MatDepID, TypeTestID,PhysicalPropID,InstruSetNum,UOM from TestMeasParam where matdepid = " & frmIDX, True, "2-2-1-1", True)
            strPrep = "<BAND INDEX=""0""><COL KEY=""typetestid"" LOOKUPSQL=""select typetestid, testname from typetestmaster"" NOEDIT=""True"" CAPTION=""Test""/><COL KEY=""UOM"" CAPTION=""Unit"" NOEDIT=""True""/><COL NOEDIT=""True"" CAPTION=""Physical Property"" KEY=""PhysicalPropID"" LOOKUPSQL=""select physicalpropid,propertyname from physicalprop order by propertyname""/><COL KEY=""InstruSetNum"" CAPTION=""Instrument Set""/></BAND>"
            myView.mainGrid.PrepEdit(strPrep)

            myVueInstru.ProcessTag("<VIEW KEY=""listinstru""><FILTER KEY=""matdep""><VALUE VALUE1=""" & myUtils.cValTN(frmIDX) & """/></FILTER></VIEW>")

            PrepForm = True

        End If
    End Function
    Public Overrides Function VSave() As Boolean

        Me.InitError()
        If Me.CanSave Then
            cm.EndCurrentEdit()
            VSave = True
        End If

    End Function

    Private Sub btnAddRat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRat.Click
        Dim f As New frmLabParam

        If f.PrepForm(myView, EnumfrmMode.acAddM, "", "<PARAMS MATDEPID=""" & myUtils.cValTN(myRow("matdepid")) & """/>") Then
            If f.ShowDialog = DialogResult.OK Then
                myView.RefreshGrid()
                myView.mainGrid.PrepEdit(strPrep)
            End If
        End If
    End Sub


    Private Sub btnEditRat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRat.Click
        Dim f As New frmLabParam

        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            If f.PrepForm(myView, EnumfrmMode.acEditM, myUtils.cValTN(myView.ContextRow.CellValue("testmeasparamid"))) Then
                If f.ShowDialog = DialogResult.OK Then
                    myView.RefreshGrid()
                    myView.mainGrid.PrepEdit(strPrep)
                End If
            End If
        End If


    End Sub

    Private Sub UltraButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UltraButton1.Click
        myView.ContextRow = myView.mainGrid.ActiveRow
        If Not myView.ContextRow Is Nothing Then
            SQLHelper.ExecuteNonQuery(CommandType.Text, "delete from testmeasparam where testmeasparamid = " & myUtils.cValTN(myView.ContextRow.CellValue("testmeasparamid")))
            myView.RefreshGrid()
            myView.mainGrid.PrepEdit(strPrep)
        End If

    End Sub

    Private Sub btnAddInstru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInstru.Click
        Dim f As New frmInstru

        If f.PrepForm(myVueInstru, EnumfrmMode.acAddM, "", "<PARAMS MATDEPID=""" & myUtils.cValTN(myRow("matdepid")) & """/>") Then
            If f.ShowDialog = DialogResult.OK Then
                myVueInstru.RefreshGrid()
            End If
        End If
    End Sub


    Private Sub btnEditInstru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditInstru.Click
        Dim f As New frmInstru

        myVueInstru.ContextRow = myVueInstru.mainGrid.ActiveRow
        If Not myVueInstru.ContextRow Is Nothing Then
            If f.PrepForm(myView, EnumfrmMode.acEditM, myUtils.cValTN(myVueInstru.ContextRow.CellValue("instrumentid"))) Then
                If f.ShowDialog = DialogResult.OK Then
                    myVueInstru.RefreshGrid()
                End If
            End If
        End If

    End Sub

End Class
