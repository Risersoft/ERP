Imports System.ComponentModel
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmITMachine
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitForm()
        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_macNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_MacName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents cmb_Location As Infragistics.Win.UltraWinGrid.UltraCombo


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UGridChild = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Speed = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Capacity = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLable4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_pmachineid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_Username = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_StatusOK = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.cmb_MacTypeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_WarrantyUpto = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_BoughtOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.dt_InstalledOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Model = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMake = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Make = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEditChild = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelChild = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddChild = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_Param7 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblr = New System.Windows.Forms.Label()
        Me.txt_Param6 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblq = New System.Windows.Forms.Label()
        Me.txt_Param5 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblp = New System.Windows.Forms.Label()
        Me.txt_Param4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblS = New System.Windows.Forms.Label()
        Me.txt_Param3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.txt_Param2 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblY = New System.Windows.Forms.Label()
        Me.txt_Param1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_MacName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_Location = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_macNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.bgw1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UGridChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        CType(Me.txt_Speed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Capacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_pmachineid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Username, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_MacTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_WarrantyUpto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_BoughtOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_InstalledOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Model, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.txt_Param7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_MacName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_macNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UGridChild)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(899, 595)
        '
        'UGridChild
        '
        Me.UGridChild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGridChild.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UGridChild.Location = New System.Drawing.Point(421, 0)
        Me.UGridChild.Name = "UGridChild"
        Me.UGridChild.Size = New System.Drawing.Size(478, 555)
        Me.UGridChild.TabIndex = 1
        Me.UGridChild.Text = "UltraGrid2"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.UltraLabel9)
        Me.Panel7.Controls.Add(Me.txt_Speed)
        Me.Panel7.Controls.Add(Me.UltraLabel8)
        Me.Panel7.Controls.Add(Me.txt_Capacity)
        Me.Panel7.Controls.Add(Me.UltraLable4)
        Me.Panel7.Controls.Add(Me.txt_descrip)
        Me.Panel7.Controls.Add(Me.UltraLabel6)
        Me.Panel7.Controls.Add(Me.cmb_pmachineid)
        Me.Panel7.Controls.Add(Me.cmb_Username)
        Me.Panel7.Controls.Add(Me.cmb_StatusOK)
        Me.Panel7.Controls.Add(Me.cmb_MacTypeID)
        Me.Panel7.Controls.Add(Me.UltraLabel3)
        Me.Panel7.Controls.Add(Me.UltraLabel12)
        Me.Panel7.Controls.Add(Me.UltraLabel10)
        Me.Panel7.Controls.Add(Me.dt_WarrantyUpto)
        Me.Panel7.Controls.Add(Me.UltraLabel7)
        Me.Panel7.Controls.Add(Me.dt_BoughtOn)
        Me.Panel7.Controls.Add(Me.dt_InstalledOn)
        Me.Panel7.Controls.Add(Me.UltraLabel14)
        Me.Panel7.Controls.Add(Me.UltraLabel5)
        Me.Panel7.Controls.Add(Me.UltraLabel4)
        Me.Panel7.Controls.Add(Me.txt_Model)
        Me.Panel7.Controls.Add(Me.lblMake)
        Me.Panel7.Controls.Add(Me.txt_Make)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(421, 555)
        Me.Panel7.TabIndex = 0
        '
        'UltraLabel9
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance4
        Me.UltraLabel9.Location = New System.Drawing.Point(61, 288)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel9.TabIndex = 20
        Me.UltraLabel9.Text = "Speed"
        '
        'txt_Speed
        '
        Appearance5.FontData.BoldAsString = "False"
        Appearance5.FontData.ItalicAsString = "False"
        Appearance5.FontData.Name = "Arial"
        Appearance5.FontData.SizeInPoints = 8.25!
        Appearance5.FontData.StrikeoutAsString = "False"
        Appearance5.FontData.UnderlineAsString = "False"
        Me.txt_Speed.Appearance = Appearance5
        Me.txt_Speed.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Speed.Location = New System.Drawing.Point(117, 288)
        Me.txt_Speed.Name = "txt_Speed"
        Me.txt_Speed.Size = New System.Drawing.Size(267, 21)
        Me.txt_Speed.TabIndex = 21
        '
        'UltraLabel8
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance1
        Me.UltraLabel8.Location = New System.Drawing.Point(61, 261)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel8.TabIndex = 18
        Me.UltraLabel8.Text = "Capacity"
        '
        'txt_Capacity
        '
        Appearance9.FontData.BoldAsString = "False"
        Appearance9.FontData.ItalicAsString = "False"
        Appearance9.FontData.Name = "Arial"
        Appearance9.FontData.SizeInPoints = 8.25!
        Appearance9.FontData.StrikeoutAsString = "False"
        Appearance9.FontData.UnderlineAsString = "False"
        Me.txt_Capacity.Appearance = Appearance9
        Me.txt_Capacity.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Capacity.Location = New System.Drawing.Point(117, 261)
        Me.txt_Capacity.Name = "txt_Capacity"
        Me.txt_Capacity.Size = New System.Drawing.Size(267, 21)
        Me.txt_Capacity.TabIndex = 19
        '
        'UltraLable4
        '
        Appearance24.TextHAlignAsString = "Right"
        Me.UltraLable4.Appearance = Appearance24
        Me.UltraLable4.Location = New System.Drawing.Point(21, 48)
        Me.UltraLable4.Name = "UltraLable4"
        Me.UltraLable4.Size = New System.Drawing.Size(88, 21)
        Me.UltraLable4.TabIndex = 2
        Me.UltraLable4.Text = "Parent Machine"
        '
        'txt_descrip
        '
        Me.txt_descrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.ItalicAsString = "False"
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 8.25!
        Appearance8.FontData.StrikeoutAsString = "False"
        Appearance8.FontData.UnderlineAsString = "False"
        Me.txt_descrip.Appearance = Appearance8
        Me.txt_descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_descrip.Location = New System.Drawing.Point(117, 315)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(267, 51)
        Me.txt_descrip.TabIndex = 23
        '
        'UltraLabel6
        '
        Appearance23.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance23
        Me.UltraLabel6.Location = New System.Drawing.Point(47, 315)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel6.TabIndex = 22
        Me.UltraLabel6.Text = "Description"
        '
        'cmb_pmachineid
        '
        Me.cmb_pmachineid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_pmachineid.Location = New System.Drawing.Point(117, 47)
        Me.cmb_pmachineid.Name = "cmb_pmachineid"
        Me.cmb_pmachineid.Size = New System.Drawing.Size(267, 22)
        Me.cmb_pmachineid.TabIndex = 3
        '
        'cmb_Username
        '
        Me.cmb_Username.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Username.Location = New System.Drawing.Point(117, 75)
        Me.cmb_Username.Name = "cmb_Username"
        Me.cmb_Username.Size = New System.Drawing.Size(267, 21)
        Me.cmb_Username.TabIndex = 5
        Me.cmb_Username.Text = "UltraComboEditor1"
        '
        'cmb_StatusOK
        '
        Me.cmb_StatusOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_StatusOK.Location = New System.Drawing.Point(117, 234)
        Me.cmb_StatusOK.Name = "cmb_StatusOK"
        Me.cmb_StatusOK.Size = New System.Drawing.Size(267, 21)
        Me.cmb_StatusOK.TabIndex = 17
        Me.cmb_StatusOK.Text = "UltraComboEditor1"
        '
        'cmb_MacTypeID
        '
        Me.cmb_MacTypeID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_MacTypeID.DataMember = "mtype"
        Me.cmb_MacTypeID.DisplayMember = "mactype"
        Me.cmb_MacTypeID.Location = New System.Drawing.Point(117, 19)
        Me.cmb_MacTypeID.Name = "cmb_MacTypeID"
        Me.cmb_MacTypeID.ReadOnly = True
        Me.cmb_MacTypeID.Size = New System.Drawing.Size(267, 22)
        Me.cmb_MacTypeID.TabIndex = 1
        Me.cmb_MacTypeID.ValueMember = "mactypeid"
        '
        'UltraLabel3
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance19
        Me.UltraLabel3.Location = New System.Drawing.Point(23, 19)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(88, 22)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Machine Type"
        '
        'UltraLabel12
        '
        Appearance28.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance28
        Me.UltraLabel12.Location = New System.Drawing.Point(31, 75)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(80, 20)
        Me.UltraLabel12.TabIndex = 4
        Me.UltraLabel12.Text = "User Name"
        '
        'UltraLabel10
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance6
        Me.UltraLabel10.Location = New System.Drawing.Point(63, 234)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(48, 22)
        Me.UltraLabel10.TabIndex = 16
        Me.UltraLabel10.Text = "Status"
        '
        'dt_WarrantyUpto
        '
        Me.dt_WarrantyUpto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance27.FontData.BoldAsString = "False"
        Appearance27.FontData.ItalicAsString = "False"
        Appearance27.FontData.Name = "Arial"
        Appearance27.FontData.SizeInPoints = 8.25!
        Appearance27.FontData.StrikeoutAsString = "False"
        Appearance27.FontData.UnderlineAsString = "False"
        Me.dt_WarrantyUpto.Appearance = Appearance27
        Me.dt_WarrantyUpto.FormatString = "dddd dd MMM yyyy"
        Me.dt_WarrantyUpto.Location = New System.Drawing.Point(117, 207)
        Me.dt_WarrantyUpto.Name = "dt_WarrantyUpto"
        Me.dt_WarrantyUpto.NullText = "Not Defined"
        Me.dt_WarrantyUpto.Size = New System.Drawing.Size(267, 21)
        Me.dt_WarrantyUpto.TabIndex = 15
        Me.dt_WarrantyUpto.Value = Nothing
        '
        'UltraLabel7
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance12
        Me.UltraLabel7.Location = New System.Drawing.Point(23, 207)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(88, 15)
        Me.UltraLabel7.TabIndex = 14
        Me.UltraLabel7.Text = "Warranty Upto"
        '
        'dt_BoughtOn
        '
        Me.dt_BoughtOn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance31.FontData.BoldAsString = "False"
        Appearance31.FontData.ItalicAsString = "False"
        Appearance31.FontData.Name = "Arial"
        Appearance31.FontData.SizeInPoints = 8.25!
        Appearance31.FontData.StrikeoutAsString = "False"
        Appearance31.FontData.UnderlineAsString = "False"
        Me.dt_BoughtOn.Appearance = Appearance31
        Me.dt_BoughtOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_BoughtOn.Location = New System.Drawing.Point(117, 154)
        Me.dt_BoughtOn.Name = "dt_BoughtOn"
        Me.dt_BoughtOn.NullText = "Not Defined"
        Me.dt_BoughtOn.Size = New System.Drawing.Size(267, 21)
        Me.dt_BoughtOn.TabIndex = 11
        Me.dt_BoughtOn.Value = Nothing
        '
        'dt_InstalledOn
        '
        Me.dt_InstalledOn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance13.FontData.BoldAsString = "False"
        Appearance13.FontData.ItalicAsString = "False"
        Appearance13.FontData.Name = "Arial"
        Appearance13.FontData.SizeInPoints = 8.25!
        Appearance13.FontData.StrikeoutAsString = "False"
        Appearance13.FontData.UnderlineAsString = "False"
        Me.dt_InstalledOn.Appearance = Appearance13
        Me.dt_InstalledOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_InstalledOn.Location = New System.Drawing.Point(117, 180)
        Me.dt_InstalledOn.Name = "dt_InstalledOn"
        Me.dt_InstalledOn.NullText = "Not Defined"
        Me.dt_InstalledOn.Size = New System.Drawing.Size(267, 21)
        Me.dt_InstalledOn.TabIndex = 13
        Me.dt_InstalledOn.Value = Nothing
        '
        'UltraLabel14
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance10
        Me.UltraLabel14.Location = New System.Drawing.Point(23, 180)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(88, 21)
        Me.UltraLabel14.TabIndex = 12
        Me.UltraLabel14.Text = "Installed On"
        '
        'UltraLabel5
        '
        Appearance32.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance32
        Me.UltraLabel5.Location = New System.Drawing.Point(47, 154)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(64, 21)
        Me.UltraLabel5.TabIndex = 10
        Me.UltraLabel5.Text = "Bought On"
        '
        'UltraLabel4
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance15
        Me.UltraLabel4.Location = New System.Drawing.Point(63, 127)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(48, 24)
        Me.UltraLabel4.TabIndex = 8
        Me.UltraLabel4.Text = "Model"
        '
        'txt_Model
        '
        Me.txt_Model.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance16.FontData.BoldAsString = "False"
        Appearance16.FontData.ItalicAsString = "False"
        Appearance16.FontData.Name = "Arial"
        Appearance16.FontData.SizeInPoints = 8.25!
        Appearance16.FontData.StrikeoutAsString = "False"
        Appearance16.FontData.UnderlineAsString = "False"
        Me.txt_Model.Appearance = Appearance16
        Me.txt_Model.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Model.Location = New System.Drawing.Point(117, 127)
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.Size = New System.Drawing.Size(267, 21)
        Me.txt_Model.TabIndex = 9
        '
        'lblMake
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.lblMake.Appearance = Appearance17
        Me.lblMake.Location = New System.Drawing.Point(63, 101)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(48, 21)
        Me.lblMake.TabIndex = 6
        Me.lblMake.Text = "Make"
        '
        'txt_Make
        '
        Me.txt_Make.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance18.FontData.BoldAsString = "False"
        Appearance18.FontData.ItalicAsString = "False"
        Appearance18.FontData.Name = "Arial"
        Appearance18.FontData.SizeInPoints = 8.25!
        Appearance18.FontData.StrikeoutAsString = "False"
        Appearance18.FontData.UnderlineAsString = "False"
        Me.txt_Make.Appearance = Appearance18
        Me.txt_Make.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Make.Location = New System.Drawing.Point(117, 101)
        Me.txt_Make.Name = "txt_Make"
        Me.txt_Make.Size = New System.Drawing.Size(267, 21)
        Me.txt_Make.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEditChild)
        Me.Panel2.Controls.Add(Me.btnDelChild)
        Me.Panel2.Controls.Add(Me.btnAddChild)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(0, 555)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 40)
        Me.Panel2.TabIndex = 2
        '
        'btnEditChild
        '
        Me.btnEditChild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditChild.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnEditChild.Location = New System.Drawing.Point(820, 6)
        Me.btnEditChild.Name = "btnEditChild"
        Me.btnEditChild.Size = New System.Drawing.Size(72, 24)
        Me.btnEditChild.TabIndex = 2
        Me.btnEditChild.Text = "&Edit"
        '
        'btnDelChild
        '
        Me.btnDelChild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelChild.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelChild.Location = New System.Drawing.Point(666, 6)
        Me.btnDelChild.Name = "btnDelChild"
        Me.btnDelChild.Size = New System.Drawing.Size(70, 24)
        Me.btnDelChild.TabIndex = 0
        Me.btnDelChild.Text = "&Delete"
        '
        'btnAddChild
        '
        Me.btnAddChild.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddChild.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddChild.Location = New System.Drawing.Point(742, 6)
        Me.btnAddChild.Name = "btnAddChild"
        Me.btnAddChild.Size = New System.Drawing.Size(72, 24)
        Me.btnAddChild.TabIndex = 1
        Me.btnAddChild.Text = "&Add New"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(899, 595)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(899, 555)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelDoc)
        Me.Panel3.Controls.Add(Me.btnAddDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(0, 555)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(899, 40)
        Me.Panel3.TabIndex = 4
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelDoc.Location = New System.Drawing.Point(729, 8)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 2
        Me.btnDelDoc.Text = "&Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddDoc.Location = New System.Drawing.Point(819, 8)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 0
        Me.btnAddDoc.Text = "&Add New"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param7)
        Me.UltraTabPageControl4.Controls.Add(Me.lblr)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param6)
        Me.UltraTabPageControl4.Controls.Add(Me.lblq)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param5)
        Me.UltraTabPageControl4.Controls.Add(Me.lblp)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param4)
        Me.UltraTabPageControl4.Controls.Add(Me.lblS)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param3)
        Me.UltraTabPageControl4.Controls.Add(Me.lblZ)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param2)
        Me.UltraTabPageControl4.Controls.Add(Me.lblY)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Param1)
        Me.UltraTabPageControl4.Controls.Add(Me.lblX)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(899, 595)
        '
        'txt_Param7
        '
        Me.txt_Param7.Location = New System.Drawing.Point(356, 240)
        Me.txt_Param7.Name = "txt_Param7"
        Me.txt_Param7.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param7.TabIndex = 13
        Me.txt_Param7.Text = "UltraTextEditor5"
        '
        'lblr
        '
        Me.lblr.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblr.Location = New System.Drawing.Point(84, 240)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(264, 16)
        Me.lblr.TabIndex = 12
        Me.lblr.Text = "Item Code"
        Me.lblr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param6
        '
        Me.txt_Param6.Location = New System.Drawing.Point(356, 208)
        Me.txt_Param6.Name = "txt_Param6"
        Me.txt_Param6.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param6.TabIndex = 11
        Me.txt_Param6.Text = "UltraTextEditor5"
        '
        'lblq
        '
        Me.lblq.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblq.Location = New System.Drawing.Point(84, 208)
        Me.lblq.Name = "lblq"
        Me.lblq.Size = New System.Drawing.Size(264, 16)
        Me.lblq.TabIndex = 10
        Me.lblq.Text = "Item Code"
        Me.lblq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param5
        '
        Me.txt_Param5.Location = New System.Drawing.Point(356, 176)
        Me.txt_Param5.Name = "txt_Param5"
        Me.txt_Param5.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param5.TabIndex = 9
        Me.txt_Param5.Text = "UltraTextEditor5"
        '
        'lblp
        '
        Me.lblp.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblp.Location = New System.Drawing.Point(84, 176)
        Me.lblp.Name = "lblp"
        Me.lblp.Size = New System.Drawing.Size(264, 16)
        Me.lblp.TabIndex = 8
        Me.lblp.Text = "Item Code"
        Me.lblp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param4
        '
        Me.txt_Param4.Location = New System.Drawing.Point(356, 144)
        Me.txt_Param4.Name = "txt_Param4"
        Me.txt_Param4.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param4.TabIndex = 7
        Me.txt_Param4.Text = "UltraTextEditor5"
        '
        'lblS
        '
        Me.lblS.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblS.Location = New System.Drawing.Point(84, 144)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(264, 16)
        Me.lblS.TabIndex = 6
        Me.lblS.Text = "Item Code"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param3
        '
        Me.txt_Param3.Location = New System.Drawing.Point(356, 112)
        Me.txt_Param3.Name = "txt_Param3"
        Me.txt_Param3.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param3.TabIndex = 5
        Me.txt_Param3.Text = "UltraTextEditor4"
        '
        'lblZ
        '
        Me.lblZ.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblZ.Location = New System.Drawing.Point(84, 112)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(264, 16)
        Me.lblZ.TabIndex = 4
        Me.lblZ.Text = "Item Code"
        Me.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param2
        '
        Me.txt_Param2.Location = New System.Drawing.Point(356, 80)
        Me.txt_Param2.Name = "txt_Param2"
        Me.txt_Param2.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param2.TabIndex = 3
        Me.txt_Param2.Text = "UltraTextEditor3"
        '
        'lblY
        '
        Me.lblY.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblY.Location = New System.Drawing.Point(84, 80)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(264, 16)
        Me.lblY.TabIndex = 2
        Me.lblY.Text = "Item Code"
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param1
        '
        Me.txt_Param1.Location = New System.Drawing.Point(356, 48)
        Me.txt_Param1.Name = "txt_Param1"
        Me.txt_Param1.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param1.TabIndex = 1
        Me.txt_Param1.Text = "UltraTextEditor2"
        '
        'lblX
        '
        Me.lblX.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblX.Location = New System.Drawing.Point(84, 48)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(264, 16)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "Item Code"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 675)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(903, 41)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Appearance7.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance7
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.Location = New System.Drawing.Point(639, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 41)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancel.Location = New System.Drawing.Point(727, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 41)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOK.Location = New System.Drawing.Point(815, 0)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 41)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel11)
        Me.Panel1.Controls.Add(Me.txt_MacName)
        Me.Panel1.Controls.Add(Me.cmb_Location)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.txt_macNum)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 54)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel11
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance11
        Me.UltraLabel11.Location = New System.Drawing.Point(186, 13)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(80, 20)
        Me.UltraLabel11.TabIndex = 2
        Me.UltraLabel11.Text = "Network Name"
        '
        'txt_MacName
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.ItalicAsString = "False"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.FontData.StrikeoutAsString = "False"
        Appearance14.FontData.UnderlineAsString = "False"
        Me.txt_MacName.Appearance = Appearance14
        Me.txt_MacName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_MacName.Location = New System.Drawing.Point(274, 12)
        Me.txt_MacName.Name = "txt_MacName"
        Me.txt_MacName.Size = New System.Drawing.Size(263, 21)
        Me.txt_MacName.TabIndex = 3
        '
        'cmb_Location
        '
        Me.cmb_Location.Location = New System.Drawing.Point(643, 11)
        Me.cmb_Location.Name = "cmb_Location"
        Me.cmb_Location.Size = New System.Drawing.Size(228, 22)
        Me.cmb_Location.TabIndex = 5
        '
        'UltraLabel2
        '
        Appearance22.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance22
        Me.UltraLabel2.Location = New System.Drawing.Point(27, 13)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(61, 20)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Code"
        '
        'txt_macNum
        '
        Appearance26.FontData.BoldAsString = "False"
        Appearance26.FontData.ItalicAsString = "False"
        Appearance26.FontData.Name = "Arial"
        Appearance26.FontData.SizeInPoints = 8.25!
        Appearance26.FontData.StrikeoutAsString = "False"
        Appearance26.FontData.UnderlineAsString = "False"
        Me.txt_macNum.Appearance = Appearance26
        Me.txt_macNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_macNum.Location = New System.Drawing.Point(94, 12)
        Me.txt_macNum.Name = "txt_macNum"
        Me.txt_macNum.Size = New System.Drawing.Size(67, 21)
        Me.txt_macNum.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance20.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance20
        Me.UltraLabel1.Location = New System.Drawing.Point(571, 15)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 19)
        Me.UltraLabel1.TabIndex = 4
        Me.UltraLabel1.Text = "Location"
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 54)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(903, 621)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Configuration"
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Breakdowns"
        UltraTab4.Key = "params"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Parameters"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab2, UltraTab1, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(899, 595)
        '
        'bgw1
        '
        Me.bgw1.WorkerReportsProgress = True
        '
        'frmITMachine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Caption = "Machine"
        Me.ClientSize = New System.Drawing.Size(903, 716)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmITMachine"
        Me.Text = "Machine"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UGridChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.txt_Speed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Capacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_pmachineid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Username, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_MacTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_WarrantyUpto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_BoughtOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_InstalledOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Model, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.txt_Param7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_MacName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_macNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents UGridChild As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txt_descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_Username As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents cmb_StatusOK As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_WarrantyUpto As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_BoughtOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents dt_InstalledOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Model As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblMake As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Make As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents txt_Param6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblq As System.Windows.Forms.Label
    Friend WithEvents txt_Param5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblp As System.Windows.Forms.Label
    Friend WithEvents txt_Param4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents txt_Param3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents txt_Param2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents txt_Param1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents cmb_MacTypeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnEditChild As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLable4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_pmachineid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Speed As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Capacity As Infragistics.Win.UltraWinEditors.UltraTextEditor

#End Region
End Class

