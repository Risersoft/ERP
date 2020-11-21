Imports ut = Infragistics.Win.UltraWinTree
Imports ug = Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinTree

Public Class myFuncs
    Public DoRefresh As Boolean = False
    Public Sub MacNodes(ByRef xNode As UltraTreeNode, ByVal strPass As String, ByRef VarList As clsConf)
        Dim sql, str1, str2, str3 As String, dt As DataTable, r1 As DataRow
        Dim nodx1 As UltraTreeNode, kConf As clsConf

        If Not VarList("nodesql") Is Nothing Then
            sql = VarList("nodesql")
            dt = SQLHelper.ExecuteDataset(CommandType.Text, sql).Tables(0)
            For Each r1 In myWinData.SelectDistinct(dt, "mactypeid", False).Select("", "mactypenum")
                nodx1 = xNode.AddNode(xNode.Key & "_" & r1("mactypeid"), r1("mctype"))

                str1 = "1-1-0-0-0-0-0-0" & myUtils.ParamWidthString(r1, "param1name", "param2name", "param3name", "param4name", "param5name", "param6name", "param7name")
                str2 = myUtils.ParamFormatXML(r1, New String() {"param1", "param2", "param3", "param4", "param5", "param6", "param7"}, New String() {"param1name", "param2name", "param3name", "param4name", "param5name", "param6name", "param7name"})

                str3 = "<MODROWCOMPLEX><MODROW VIEWKEY=""listmacs""><STRWIDTH>" & str1 & "</STRWIDTH><FORMATXML>" & str2 & "</FORMATXML><STRBAND>Machines</STRBAND></MODROW></MODROWCOMPLEX>"

                kConf = New clsConf
                kConf("stridxml") = "<IDX VALUE=""" & r1("mactypeid") & """ /><FILTER KEY=""mactype""><VALUE VALUE1=""" & r1("mactypeid") & """/></FILTER>" & str3
                nodx1.Tag = kConf
                nodx1.DataKey = "viewmactype"
            Next

        End If
    End Sub
End Class






