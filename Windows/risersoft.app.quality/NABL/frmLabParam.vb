Imports ug = Infragistics.Win.UltraWinGrid
Public Class frmLabParam
    Inherits frmMax

    Public Sub initForm()

        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)
        mywinsql.AssignCmb(Me.dsCombo, "test", "select typetestid, testname from typetestmaster order by testname", Me.cmb_typetestid)
        mywinsql.AssignCmb(Me.dsCombo, "depsmat", "select matdepid,depname from depsmat where haslab=1 order by depname", Me.cmb_matdepid)
        mywinsql.AssignCmb(Me.dsCombo, "pp", "select physicalpropid, propertyname from physicalprop order by propertyname", Me.cmb_PhysicalPropID)

    End Sub
    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Dim sql, str1 As String, dt As DataTable

        If prepMode = EnumfrmMode.acAddM Then prepIDX = 0
        sql = "select * from testmeasparam where testmeasparamid = " & prepIDX
        Me.InitData(sql, "matdepid", oView, prepMode, prepIDX, strXML)

        sql = "select testmpinstruid,uncertnum, accunum, resolnum, testmeasparamid,Range, AccuRdg, AccuRange, UncertCalib, Resolution, InstrumentID, InstrumentID as InstruName, InstrumentID as Descrip  from testmpinstru  where testmeasparamid = " & frmIDX
        myView.mainGrid.QuickConf(sql, True, "1-3-3", True, "Instruments Used")
        str1 = "<BAND INDEX=""0"" TABLE=""testmpinstru"" IDFIELD=""testmpinstruID""><COL NOEDIT=""True"" CAPTION=""Code"" KEY=""Instrumentid"" LOOKUPSQL=""select instrumentid, codenum from Instruments where matdepid = " & myUtils.cValTN(myRow("matdepid")) & """/><COL KEY=""accurdg"" CAPTION=""Accuracy Reading""/><COL KEY=""accurange"" CAPTION=""Accuracy Range""/><COL KEY=""uncertcalib"" CAPTION=""Uncertainity of Calibration""/><COL KEY=""Range,Resolution,testmeasparamid,uncertnum,accunum,resolnum""/></BAND>"

        sql = "select instrumentid, Codenum,Instruname,Descrip from Instruments where matdepid=38 or matdepid = " & myUtils.cValTN(myRow("matdepid"))
        dtInstru = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)

        myView.mainGrid.SetColLookup("instrumentid", dtInstru, "", , "Code", "codenum", "instrumentid")
        myView.mainGrid.SetColLookup("instruname", dtInstru, "", , "Name", "instruname", "instrumentid")
        myView.mainGrid.SetColLookup("descrip", dtInstru, "", , "Description", "descrip", "instrumentid")

        myView.mainGrid.PrepEdit(str1, , Me.btnDelInstru)

        PrepForm = True

    End Function

    Public Overrides Function VSave() As Boolean
        Dim i As Integer, sql As String, dt As DataTable, UC As Decimal
        Dim rr(), nr As DataRow

        Me.InitError()
        If myUtils.NullNot(Me.cmb_PhysicalPropID.Value) Then WinFormUtils.AddError(Me.cmb_PhysicalPropID, "Select Measurement parameter")
        If myUtils.NullNot(Me.cmb_typetestid.Value) Then WinFormUtils.AddError(Me.cmb_typetestid, "Select Test")

        myView.mainGrid.CheckValid("instrumentid")

        If Me.CanSave Then
            cm.EndCurrentEdit()
            SQLHelper.SaveResults(myRow.Row.Table, sqlForm)
            frmMode = EnumfrmMode.acEditM
            frmIDX = myRow("testmeasparamid")

            myView.mainGrid.SaveChanges(, "testmeasparamid=" & frmIDX)

            VSave = True
        End If

    End Function


    Private Sub btnAddInstru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInstru.Click
        Dim f As New frmGrid, rr(), nr As DataRow

        f.myView.mainGrid.BindView(dtInstru.DataSet)
        f.myView.mainGrid.QuickConf("", True, "1-3-3", , "Instruments")
        If f.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            rr = myView.mainGrid.myDS.Tables(0).Select("instrumentid=" & f.myView.ContextRow.CellValue("instrumentid"))
            If rr.Length = 0 Then
                nr = myUtils.CopyOneRow(myUtils.DataRowFromGridRow(f.myView.ContextRow), myView.mainGrid.myDS.Tables(0))
                nr("instruname") = nr("instrumentid")
                nr("Descrip") = nr("instrumentid")
            Else
                MsgBox("Instrument already added.", MsgBoxStyle.Information, myWinApp.Vars("appname"))
            End If
        End If
    End Sub
End Class
