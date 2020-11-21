Imports Infragistics.Win.UltraWinGrid
Imports risersoft.app.mxform
Imports risersoft.shared.Extensions

Public Class frmNC
    Inherits frmMax
    Friend fItem As frmNCItem
    Dim dvMatDep, dvForMatDep As DataView

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.initForm()
    End Sub

    Public Sub initForm()
        Me.myView.SetGrid(Me.UltraGridItemList)
        WinFormUtils.SetButtonConf(Me.btnOK, Me.btnCancel, Me.btnSave)

        fItem = New frmNCItem
        fItem.AddToPanel(Me.UltraExpandableGroupBoxPanel2, True, System.Windows.Forms.DockStyle.Fill)
        fItem.fMat = Me

        fItem.Enabled = False
    End Sub

    Public Overrides Function PrepForm(oView As clsWinView, ByVal prepMode As EnumfrmMode, ByVal prepIdx As String, Optional ByVal strXML As String = "") As Boolean
        Me.FormPrepared = False
        Dim objModel As frmNCModel = Me.InitData("frmNCModel", oview, prepMode, prepIdx, strXML)
        If Me.BindModel(objModel, oview) Then
            dvMatDep = myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_matdepid,, 2)
            dvForMatDep = myWinSQL.AssignCmb(Me.dsCombo, "Deps", "", Me.cmb_ForMatDepID,, 2)
            myWinSQL.AssignCmb(Me.dsCombo, "Serial", "", Me.cmb_ProdSerialID)
            Me.cmb_raisedby.ValueList = Me.Model.ValueLists("RaisedBy").ComboList
            fItem.BindModel(objModel)

            If myUtils.cValTN(myRow("PidUnitId")) = 0 Then
                Me.cmb_ProdSerialID.Visible = False
                Me.lblPS.Visible = False
                Me.Text = "Non Confirmity - General"
            Else
                Me.Text = "Non Confirmity - Work Order"
            End If
            InitUpLoad()
            HandleDate(myUtils.cDateTN(myRow("NCDate"), DateTime.MinValue))
            Me.FormPrepared = True
        End If
        Return Me.FormPrepared
    End Function

    Public Overrides Function BindModel(NewModel As clsFormDataModel, oView As clsView) As Boolean
        If MyBase.BindModel(NewModel, oView) Then
            myView.PrepEdit(Me.Model.GridViews("ItemList"))
            Return True
        End If
        Return False
    End Function

    Public Overrides Function VSave() As Boolean
        Me.InitError()
        VSave = False
        cm.EndCurrentEdit()
        If (myView.mainGrid.myDS.Tables(0).Select.Length = 0 OrElse fItem.VSave) AndAlso Me.ValidateData() Then
            myRow("PdfOwnerPass") = Me.CtlUpLoad1.EncryptPassword
            myRow("PdfSource") = Me.CtlUpLoad1.FilePath
            If Me.SaveModel() Then
                InitUpLoad()
                Return True
            End If
        Else
            Me.SetError()
        End If
        Me.Refresh()
    End Function

    Private Sub InitUpLoad()
        Me.CtlUpLoad1.InitExt(frmMode, "NC_" & myRow("ProdNCId") & "." & "pdf", myUtils.cStrTN(myRow("PdfSource")), myUtils.cStrTN(myRow("PdfOwnerPass")), "/NC", "pdf", "nc")
    End Sub

    Private Sub UltraGridItemList_AfterRowActivate(sender As Object, e As EventArgs) Handles UltraGridItemList.AfterRowActivate
        Me.InitError()
        myView.mainGrid.myGrid.UpdateData()

        Dim r1 As DataRow = myWinUtils.DataRowFromGridRow(myView.mainGrid.myGrid.ActiveRow)
        If fItem.PrepForm(r1) Then
            fItem.Enabled = True
        End If
    End Sub

    Private Sub UltraGridItemList_BeforeRowDeactivate(sender As Object, e As ComponentModel.CancelEventArgs) Handles UltraGridItemList.BeforeRowDeactivate
        If fItem.VSave Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If myView.mainGrid.myDS.Tables(0).Select.Length = 0 OrElse fItem.VSave Then
            Dim gr As UltraGridRow
            gr = myView.mainGrid.ButtonAction("add")
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        myView.mainGrid.ButtonAction("del")

        If myView.mainGrid.myDS.Tables(0).Select.Length = 0 Then
            fItem.FormPrepared = False

            fItem.Enabled = False
        End If
    End Sub

    Private Sub dt_ncdate_Leave(sender As Object, e As EventArgs) Handles dt_ncdate.Leave, dt_ncdate.AfterCloseUp
        HandleDate(dt_ncdate.Value)
    End Sub

    Private Sub HandleDate(dated As Date)
        dvMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
        dvForMatDep.RowFilter = risersoft.app.mxform.myFuncs.FieldFilter(Me.Controller, Me.fRow, dated, "WODate", "CompletedOn", "MatDepID")
    End Sub
End Class