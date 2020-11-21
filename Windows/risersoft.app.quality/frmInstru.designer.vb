<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmInstru
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
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CodeNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_location As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_InstruName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridCH As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelInstru As Infragistics.Win.Misc.UltraButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_ForProcess As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_GradeAccu As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ManuSerial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_BoughtOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Model As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblMake As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Make As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelRange As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRange As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_CalibFreq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_CalibDueOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraGridUC As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents chk_UseScaleFac As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents chk_NotinUse As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridPM As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnDelMaint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddMaint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddInstru As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_MacTypeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents txt_Param10 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param9 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblb As System.Windows.Forms.Label
    Friend WithEvents txt_Param8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbla As System.Windows.Forms.Label
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

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridCH = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelInstru = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddInstru = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridUC = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_UseScaleFac = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelRange = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddRange = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridBD = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnDelBD = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddBD = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGridPM = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnDelMaint = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddMaint = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.lblc = New System.Windows.Forms.Label()
        Me.txt_Param10 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Param9 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblb = New System.Windows.Forms.Label()
        Me.txt_Param8 = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lbla = New System.Windows.Forms.Label()
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
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_MacTypeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.chk_NotinUse = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CalibFreq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_CalibDueOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.chk_ForProcess = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_GradeAccu = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ManuSerial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_BoughtOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Model = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMake = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Make = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_CodeNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_location = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_InstruName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGridCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGridUC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.chk_UseScaleFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.UltraGridBD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGridPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.UltraTabPageControl4.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.txt_Param10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_MacTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_NotinUse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txt_CalibFreq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_CalibDueOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chk_ForProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GradeAccu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ManuSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_BoughtOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Model, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CodeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_InstruName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGridCH)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(841, 269)
        '
        'UltraGridCH
        '
        Me.UltraGridCH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridCH.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGridCH.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridCH.Name = "UltraGridCH"
        Me.UltraGridCH.Size = New System.Drawing.Size(841, 229)
        Me.UltraGridCH.TabIndex = 0
        Me.UltraGridCH.Text = "Calibration History"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelInstru)
        Me.Panel3.Controls.Add(Me.btnAddInstru)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(0, 229)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(841, 40)
        Me.Panel3.TabIndex = 1
        '
        'btnDelInstru
        '
        Me.btnDelInstru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelInstru.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelInstru.Location = New System.Drawing.Point(671, 8)
        Me.btnDelInstru.Name = "btnDelInstru"
        Me.btnDelInstru.Size = New System.Drawing.Size(70, 24)
        Me.btnDelInstru.TabIndex = 0
        Me.btnDelInstru.Text = "&Delete"
        '
        'btnAddInstru
        '
        Me.btnAddInstru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddInstru.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddInstru.Location = New System.Drawing.Point(761, 8)
        Me.btnAddInstru.Name = "btnAddInstru"
        Me.btnAddInstru.Size = New System.Drawing.Size(72, 24)
        Me.btnAddInstru.TabIndex = 1
        Me.btnAddInstru.Text = "&Add New"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGridUC)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(841, 269)
        '
        'UltraGridUC
        '
        Me.UltraGridUC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridUC.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGridUC.Location = New System.Drawing.Point(0, 58)
        Me.UltraGridUC.Name = "UltraGridUC"
        Me.UltraGridUC.Size = New System.Drawing.Size(841, 171)
        Me.UltraGridUC.TabIndex = 1
        Me.UltraGridUC.Text = "Uc Data"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.UltraLabel13)
        Me.Panel5.Controls.Add(Me.chk_UseScaleFac)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(841, 58)
        Me.Panel5.TabIndex = 0
        '
        'UltraLabel13
        '
        Appearance1.TextHAlignAsString = "Left"
        Me.UltraLabel13.Appearance = Appearance1
        Me.UltraLabel13.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel13.Location = New System.Drawing.Point(133, 33)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(471, 18)
        Me.UltraLabel13.TabIndex = 1
        Me.UltraLabel13.Text = "Leave the Uncertainity of Calibration Base column empty if Uncertainity is alread" &
    "y in %"
        '
        'chk_UseScaleFac
        '
        Me.chk_UseScaleFac.Location = New System.Drawing.Point(133, 3)
        Me.chk_UseScaleFac.Name = "chk_UseScaleFac"
        Me.chk_UseScaleFac.Size = New System.Drawing.Size(403, 24)
        Me.chk_UseScaleFac.TabIndex = 0
        Me.chk_UseScaleFac.Text = "Use scale factor while determining range during calculation of uncertainity"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDelRange)
        Me.Panel2.Controls.Add(Me.btnAddRange)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(0, 229)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(841, 40)
        Me.Panel2.TabIndex = 2
        '
        'btnDelRange
        '
        Me.btnDelRange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelRange.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelRange.Location = New System.Drawing.Point(671, 8)
        Me.btnDelRange.Name = "btnDelRange"
        Me.btnDelRange.Size = New System.Drawing.Size(70, 24)
        Me.btnDelRange.TabIndex = 0
        Me.btnDelRange.Text = "&Delete"
        '
        'btnAddRange
        '
        Me.btnAddRange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddRange.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddRange.Location = New System.Drawing.Point(761, 8)
        Me.btnAddRange.Name = "btnAddRange"
        Me.btnAddRange.Size = New System.Drawing.Size(72, 24)
        Me.btnAddRange.TabIndex = 1
        Me.btnAddRange.Text = "&Add New"
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.UltraGridBD)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(841, 269)
        '
        'UltraGridBD
        '
        Me.UltraGridBD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridBD.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGridBD.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridBD.Name = "UltraGridBD"
        Me.UltraGridBD.Size = New System.Drawing.Size(841, 229)
        Me.UltraGridBD.TabIndex = 0
        Me.UltraGridBD.Text = "UltraGrid4"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDelBD)
        Me.Panel7.Controls.Add(Me.btnAddBD)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel7.Location = New System.Drawing.Point(0, 229)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(841, 40)
        Me.Panel7.TabIndex = 1
        '
        'btnDelBD
        '
        Me.btnDelBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelBD.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelBD.Location = New System.Drawing.Point(671, 8)
        Me.btnDelBD.Name = "btnDelBD"
        Me.btnDelBD.Size = New System.Drawing.Size(70, 24)
        Me.btnDelBD.TabIndex = 0
        Me.btnDelBD.Text = "&Delete"
        '
        'btnAddBD
        '
        Me.btnAddBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddBD.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddBD.Location = New System.Drawing.Point(761, 8)
        Me.btnAddBD.Name = "btnAddBD"
        Me.btnAddBD.Size = New System.Drawing.Size(72, 24)
        Me.btnAddBD.TabIndex = 1
        Me.btnAddBD.Text = "&Add New"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGridPM)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel6)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(841, 269)
        '
        'UltraGridPM
        '
        Me.UltraGridPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridPM.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGridPM.Location = New System.Drawing.Point(0, 0)
        Me.UltraGridPM.Name = "UltraGridPM"
        Me.UltraGridPM.Size = New System.Drawing.Size(841, 229)
        Me.UltraGridPM.TabIndex = 0
        Me.UltraGridPM.Text = "UltraGrid3"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnDelMaint)
        Me.Panel6.Controls.Add(Me.btnAddMaint)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel6.Location = New System.Drawing.Point(0, 229)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(841, 40)
        Me.Panel6.TabIndex = 1
        '
        'btnDelMaint
        '
        Me.btnDelMaint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelMaint.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelMaint.Location = New System.Drawing.Point(671, 8)
        Me.btnDelMaint.Name = "btnDelMaint"
        Me.btnDelMaint.Size = New System.Drawing.Size(70, 24)
        Me.btnDelMaint.TabIndex = 0
        Me.btnDelMaint.Text = "&Delete"
        '
        'btnAddMaint
        '
        Me.btnAddMaint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddMaint.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddMaint.Location = New System.Drawing.Point(761, 8)
        Me.btnAddMaint.Name = "btnAddMaint"
        Me.btnAddMaint.Size = New System.Drawing.Size(72, 24)
        Me.btnAddMaint.TabIndex = 1
        Me.btnAddMaint.Text = "&Add New"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.UltraPanel1)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(841, 269)
        '
        'UltraPanel1
        '
        Me.UltraPanel1.AutoScroll = True
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblc)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param10)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param9)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblb)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param8)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lbla)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param7)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblr)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param6)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblq)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param5)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblp)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param4)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblS)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param3)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblZ)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param2)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblY)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.txt_Param1)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.lblX)
        Me.UltraPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraPanel1.Location = New System.Drawing.Point(0, 0)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraPanel1.Size = New System.Drawing.Size(841, 269)
        Me.UltraPanel1.TabIndex = 0
        '
        'lblc
        '
        Me.lblc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblc.Location = New System.Drawing.Point(40, 295)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(264, 16)
        Me.lblc.TabIndex = 18
        Me.lblc.Text = "Item Code"
        Me.lblc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param10
        '
        Me.txt_Param10.Location = New System.Drawing.Point(312, 292)
        Me.txt_Param10.Name = "txt_Param10"
        Me.txt_Param10.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param10.TabIndex = 19
        Me.txt_Param10.Text = "UltraTextEditor5"
        '
        'txt_Param9
        '
        Me.txt_Param9.Location = New System.Drawing.Point(312, 265)
        Me.txt_Param9.Name = "txt_Param9"
        Me.txt_Param9.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param9.TabIndex = 17
        Me.txt_Param9.Text = "UltraTextEditor5"
        '
        'lblb
        '
        Me.lblb.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblb.Location = New System.Drawing.Point(40, 265)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(264, 16)
        Me.lblb.TabIndex = 16
        Me.lblb.Text = "Item Code"
        Me.lblb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param8
        '
        Me.txt_Param8.Location = New System.Drawing.Point(312, 238)
        Me.txt_Param8.Name = "txt_Param8"
        Me.txt_Param8.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param8.TabIndex = 15
        Me.txt_Param8.Text = "UltraTextEditor5"
        '
        'lbla
        '
        Me.lbla.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lbla.Location = New System.Drawing.Point(40, 238)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(264, 16)
        Me.lbla.TabIndex = 14
        Me.lbla.Text = "Item Code"
        Me.lbla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param7
        '
        Me.txt_Param7.Location = New System.Drawing.Point(312, 211)
        Me.txt_Param7.Name = "txt_Param7"
        Me.txt_Param7.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param7.TabIndex = 13
        Me.txt_Param7.Text = "UltraTextEditor5"
        '
        'lblr
        '
        Me.lblr.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblr.Location = New System.Drawing.Point(40, 211)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(264, 16)
        Me.lblr.TabIndex = 12
        Me.lblr.Text = "Item Code"
        Me.lblr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param6
        '
        Me.txt_Param6.Location = New System.Drawing.Point(312, 179)
        Me.txt_Param6.Name = "txt_Param6"
        Me.txt_Param6.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param6.TabIndex = 11
        Me.txt_Param6.Text = "UltraTextEditor5"
        '
        'lblq
        '
        Me.lblq.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblq.Location = New System.Drawing.Point(40, 179)
        Me.lblq.Name = "lblq"
        Me.lblq.Size = New System.Drawing.Size(264, 16)
        Me.lblq.TabIndex = 10
        Me.lblq.Text = "Item Code"
        Me.lblq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param5
        '
        Me.txt_Param5.Location = New System.Drawing.Point(312, 147)
        Me.txt_Param5.Name = "txt_Param5"
        Me.txt_Param5.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param5.TabIndex = 9
        Me.txt_Param5.Text = "UltraTextEditor5"
        '
        'lblp
        '
        Me.lblp.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblp.Location = New System.Drawing.Point(40, 147)
        Me.lblp.Name = "lblp"
        Me.lblp.Size = New System.Drawing.Size(264, 16)
        Me.lblp.TabIndex = 8
        Me.lblp.Text = "Item Code"
        Me.lblp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param4
        '
        Me.txt_Param4.Location = New System.Drawing.Point(312, 115)
        Me.txt_Param4.Name = "txt_Param4"
        Me.txt_Param4.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param4.TabIndex = 7
        Me.txt_Param4.Text = "UltraTextEditor5"
        '
        'lblS
        '
        Me.lblS.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblS.Location = New System.Drawing.Point(40, 115)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(264, 16)
        Me.lblS.TabIndex = 6
        Me.lblS.Text = "Item Code"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param3
        '
        Me.txt_Param3.Location = New System.Drawing.Point(312, 83)
        Me.txt_Param3.Name = "txt_Param3"
        Me.txt_Param3.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param3.TabIndex = 5
        Me.txt_Param3.Text = "UltraTextEditor4"
        '
        'lblZ
        '
        Me.lblZ.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblZ.Location = New System.Drawing.Point(40, 83)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(264, 16)
        Me.lblZ.TabIndex = 4
        Me.lblZ.Text = "Item Code"
        Me.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param2
        '
        Me.txt_Param2.Location = New System.Drawing.Point(312, 51)
        Me.txt_Param2.Name = "txt_Param2"
        Me.txt_Param2.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param2.TabIndex = 3
        Me.txt_Param2.Text = "UltraTextEditor3"
        '
        'lblY
        '
        Me.lblY.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblY.Location = New System.Drawing.Point(40, 51)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(264, 16)
        Me.lblY.TabIndex = 2
        Me.lblY.Text = "Item Code"
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param1
        '
        Me.txt_Param1.Location = New System.Drawing.Point(312, 19)
        Me.txt_Param1.Name = "txt_Param1"
        Me.txt_Param1.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param1.TabIndex = 1
        Me.txt_Param1.Text = "UltraTextEditor2"
        '
        'lblX
        '
        Me.lblX.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblX.Location = New System.Drawing.Point(40, 19)
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
        Me.Panel4.Location = New System.Drawing.Point(0, 572)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(845, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance2
        Me.btnSave.Location = New System.Drawing.Point(557, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance3
        Me.btnCancel.Location = New System.Drawing.Point(653, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance4
        Me.btnOK.Location = New System.Drawing.Point(749, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel14)
        Me.Panel1.Controls.Add(Me.cmb_MacTypeID)
        Me.Panel1.Controls.Add(Me.chk_NotinUse)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cmb_matdepid)
        Me.Panel1.Controls.Add(Me.UltraLabel12)
        Me.Panel1.Controls.Add(Me.UltraLabel7)
        Me.Panel1.Controls.Add(Me.txt_CodeNum)
        Me.Panel1.Controls.Add(Me.UltraLabel10)
        Me.Panel1.Controls.Add(Me.txt_Remark)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.txt_location)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.txt_descrip)
        Me.Panel1.Controls.Add(Me.txt_InstruName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 277)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel14
        '
        Appearance5.FontData.SizeInPoints = 8.0!
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance5
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel14.Location = New System.Drawing.Point(14, 85)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(128, 14)
        Me.UltraLabel14.TabIndex = 4
        Me.UltraLabel14.Text = "Instrument/Machine Type"
        '
        'cmb_MacTypeID
        '
        Appearance6.FontData.BoldAsString = "True"
        Appearance6.FontData.SizeInPoints = 9.0!
        Me.cmb_MacTypeID.Appearance = Appearance6
        Me.cmb_MacTypeID.DataMember = "mtype"
        Me.cmb_MacTypeID.DisplayMember = "mactype"
        Me.cmb_MacTypeID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_MacTypeID.Location = New System.Drawing.Point(145, 81)
        Me.cmb_MacTypeID.Name = "cmb_MacTypeID"
        Me.cmb_MacTypeID.Size = New System.Drawing.Size(264, 23)
        Me.cmb_MacTypeID.TabIndex = 5
        Me.cmb_MacTypeID.ValueMember = "mactypeid"
        '
        'chk_NotinUse
        '
        Me.chk_NotinUse.AutoSize = True
        Me.chk_NotinUse.Location = New System.Drawing.Point(144, 252)
        Me.chk_NotinUse.Name = "chk_NotinUse"
        Me.chk_NotinUse.Size = New System.Drawing.Size(163, 17)
        Me.chk_NotinUse.TabIndex = 14
        Me.chk_NotinUse.Text = "This Instrument is not in use"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UltraLabel8)
        Me.GroupBox1.Controls.Add(Me.txt_CalibFreq)
        Me.GroupBox1.Controls.Add(Me.dt_CalibDueOn)
        Me.GroupBox1.Controls.Add(Me.UltraLabel3)
        Me.GroupBox1.Controls.Add(Me.chk_ForProcess)
        Me.GroupBox1.Controls.Add(Me.UltraLabel11)
        Me.GroupBox1.Controls.Add(Me.txt_GradeAccu)
        Me.GroupBox1.Controls.Add(Me.UltraLabel9)
        Me.GroupBox1.Controls.Add(Me.txt_ManuSerial)
        Me.GroupBox1.Controls.Add(Me.dt_BoughtOn)
        Me.GroupBox1.Controls.Add(Me.UltraLabel5)
        Me.GroupBox1.Controls.Add(Me.UltraLabel4)
        Me.GroupBox1.Controls.Add(Me.txt_Model)
        Me.GroupBox1.Controls.Add(Me.lblMake)
        Me.GroupBox1.Controls.Add(Me.txt_Make)
        Me.GroupBox1.Location = New System.Drawing.Point(452, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 248)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Instrument Information"
        '
        'UltraLabel8
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance7
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel8.Location = New System.Drawing.Point(43, 167)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(115, 14)
        Me.UltraLabel8.TabIndex = 10
        Me.UltraLabel8.Text = "Calibration Frequency"
        '
        'txt_CalibFreq
        '
        Appearance8.FontData.BoldAsString = "False"
        Appearance8.FontData.ItalicAsString = "False"
        Appearance8.FontData.Name = "Arial"
        Appearance8.FontData.SizeInPoints = 8.25!
        Appearance8.FontData.StrikeoutAsString = "False"
        Appearance8.FontData.UnderlineAsString = "False"
        Me.txt_CalibFreq.Appearance = Appearance8
        Me.txt_CalibFreq.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CalibFreq.Location = New System.Drawing.Point(161, 164)
        Me.txt_CalibFreq.Name = "txt_CalibFreq"
        Me.txt_CalibFreq.Size = New System.Drawing.Size(192, 21)
        Me.txt_CalibFreq.TabIndex = 11
        '
        'dt_CalibDueOn
        '
        Appearance9.FontData.BoldAsString = "False"
        Appearance9.FontData.ItalicAsString = "False"
        Appearance9.FontData.Name = "Arial"
        Appearance9.FontData.SizeInPoints = 8.25!
        Appearance9.FontData.StrikeoutAsString = "False"
        Appearance9.FontData.UnderlineAsString = "False"
        Me.dt_CalibDueOn.Appearance = Appearance9
        Me.dt_CalibDueOn.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dt_CalibDueOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_CalibDueOn.Location = New System.Drawing.Point(161, 191)
        Me.dt_CalibDueOn.Name = "dt_CalibDueOn"
        Me.dt_CalibDueOn.NullText = "Not Defined"
        Me.dt_CalibDueOn.Size = New System.Drawing.Size(160, 21)
        Me.dt_CalibDueOn.TabIndex = 13
        Me.dt_CalibDueOn.Value = Nothing
        '
        'UltraLabel3
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance10
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel3.Location = New System.Drawing.Point(57, 194)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(101, 14)
        Me.UltraLabel3.TabIndex = 12
        Me.UltraLabel3.Text = "Calibration Due On"
        '
        'chk_ForProcess
        '
        Me.chk_ForProcess.AutoSize = True
        Me.chk_ForProcess.Location = New System.Drawing.Point(161, 218)
        Me.chk_ForProcess.Name = "chk_ForProcess"
        Me.chk_ForProcess.Size = New System.Drawing.Size(162, 17)
        Me.chk_ForProcess.TabIndex = 14
        Me.chk_ForProcess.Text = "This is a process instrument"
        '
        'UltraLabel11
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance11
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel11.Location = New System.Drawing.Point(35, 138)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(123, 14)
        Me.UltraLabel11.TabIndex = 8
        Me.UltraLabel11.Text = "Grade / Accuracy Class"
        '
        'txt_GradeAccu
        '
        Appearance12.FontData.BoldAsString = "False"
        Appearance12.FontData.ItalicAsString = "False"
        Appearance12.FontData.Name = "Arial"
        Appearance12.FontData.SizeInPoints = 8.25!
        Appearance12.FontData.StrikeoutAsString = "False"
        Appearance12.FontData.UnderlineAsString = "False"
        Me.txt_GradeAccu.Appearance = Appearance12
        Me.txt_GradeAccu.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_GradeAccu.Location = New System.Drawing.Point(161, 134)
        Me.txt_GradeAccu.Name = "txt_GradeAccu"
        Me.txt_GradeAccu.Size = New System.Drawing.Size(192, 21)
        Me.txt_GradeAccu.TabIndex = 9
        '
        'UltraLabel9
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance13
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel9.Location = New System.Drawing.Point(26, 83)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(132, 14)
        Me.UltraLabel9.TabIndex = 4
        Me.UltraLabel9.Text = "Manufacturer's Serial No."
        '
        'txt_ManuSerial
        '
        Appearance14.FontData.BoldAsString = "False"
        Appearance14.FontData.ItalicAsString = "False"
        Appearance14.FontData.Name = "Arial"
        Appearance14.FontData.SizeInPoints = 8.25!
        Appearance14.FontData.StrikeoutAsString = "False"
        Appearance14.FontData.UnderlineAsString = "False"
        Me.txt_ManuSerial.Appearance = Appearance14
        Me.txt_ManuSerial.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ManuSerial.Location = New System.Drawing.Point(161, 80)
        Me.txt_ManuSerial.Name = "txt_ManuSerial"
        Me.txt_ManuSerial.Size = New System.Drawing.Size(200, 21)
        Me.txt_ManuSerial.TabIndex = 5
        '
        'dt_BoughtOn
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.ItalicAsString = "False"
        Appearance15.FontData.Name = "Arial"
        Appearance15.FontData.SizeInPoints = 8.25!
        Appearance15.FontData.StrikeoutAsString = "False"
        Appearance15.FontData.UnderlineAsString = "False"
        Me.dt_BoughtOn.Appearance = Appearance15
        Me.dt_BoughtOn.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dt_BoughtOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_BoughtOn.Location = New System.Drawing.Point(161, 107)
        Me.dt_BoughtOn.Name = "dt_BoughtOn"
        Me.dt_BoughtOn.NullText = "Not Defined"
        Me.dt_BoughtOn.Size = New System.Drawing.Size(200, 21)
        Me.dt_BoughtOn.TabIndex = 7
        Me.dt_BoughtOn.Value = Nothing
        '
        'UltraLabel5
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance16
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel5.Location = New System.Drawing.Point(100, 110)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(58, 14)
        Me.UltraLabel5.TabIndex = 6
        Me.UltraLabel5.Text = "Bought On"
        '
        'UltraLabel4
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance17
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel4.Location = New System.Drawing.Point(88, 55)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(70, 14)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Model / Type"
        '
        'txt_Model
        '
        Appearance18.FontData.BoldAsString = "False"
        Appearance18.FontData.ItalicAsString = "False"
        Appearance18.FontData.Name = "Arial"
        Appearance18.FontData.SizeInPoints = 8.25!
        Appearance18.FontData.StrikeoutAsString = "False"
        Appearance18.FontData.UnderlineAsString = "False"
        Me.txt_Model.Appearance = Appearance18
        Me.txt_Model.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Model.Location = New System.Drawing.Point(161, 52)
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.Size = New System.Drawing.Size(160, 21)
        Me.txt_Model.TabIndex = 3
        '
        'lblMake
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.lblMake.Appearance = Appearance19
        Me.lblMake.AutoSize = True
        Me.lblMake.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblMake.Location = New System.Drawing.Point(126, 25)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(32, 14)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make"
        '
        'txt_Make
        '
        Appearance20.FontData.BoldAsString = "False"
        Appearance20.FontData.ItalicAsString = "False"
        Appearance20.FontData.Name = "Arial"
        Appearance20.FontData.SizeInPoints = 8.25!
        Appearance20.FontData.StrikeoutAsString = "False"
        Appearance20.FontData.UnderlineAsString = "False"
        Me.txt_Make.Appearance = Appearance20
        Me.txt_Make.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Make.Location = New System.Drawing.Point(161, 22)
        Me.txt_Make.Name = "txt_Make"
        Me.txt_Make.Size = New System.Drawing.Size(128, 21)
        Me.txt_Make.TabIndex = 1
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(145, 111)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.Size = New System.Drawing.Size(192, 22)
        Me.cmb_matdepid.TabIndex = 7
        '
        'UltraLabel12
        '
        Appearance21.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance21
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(79, 115)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel12.TabIndex = 6
        Me.UltraLabel12.Text = "Department"
        '
        'UltraLabel7
        '
        Appearance22.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance22
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel7.Location = New System.Drawing.Point(111, 61)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(31, 14)
        Me.UltraLabel7.TabIndex = 2
        Me.UltraLabel7.Text = "Code"
        '
        'txt_CodeNum
        '
        Appearance23.FontData.BoldAsString = "False"
        Appearance23.FontData.ItalicAsString = "False"
        Appearance23.FontData.Name = "Arial"
        Appearance23.FontData.SizeInPoints = 8.25!
        Appearance23.FontData.StrikeoutAsString = "False"
        Appearance23.FontData.UnderlineAsString = "False"
        Me.txt_CodeNum.Appearance = Appearance23
        Me.txt_CodeNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_CodeNum.Location = New System.Drawing.Point(145, 57)
        Me.txt_CodeNum.Name = "txt_CodeNum"
        Me.txt_CodeNum.Size = New System.Drawing.Size(128, 21)
        Me.txt_CodeNum.TabIndex = 3
        '
        'UltraLabel10
        '
        Appearance24.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance24
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel10.Location = New System.Drawing.Point(98, 171)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel10.TabIndex = 10
        Me.UltraLabel10.Text = "Remark"
        '
        'txt_Remark
        '
        Appearance25.FontData.BoldAsString = "False"
        Appearance25.FontData.ItalicAsString = "False"
        Appearance25.FontData.Name = "Arial"
        Appearance25.FontData.SizeInPoints = 8.25!
        Appearance25.FontData.StrikeoutAsString = "False"
        Appearance25.FontData.UnderlineAsString = "False"
        Me.txt_Remark.Appearance = Appearance25
        Me.txt_Remark.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Remark.Location = New System.Drawing.Point(145, 167)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Size = New System.Drawing.Size(296, 21)
        Me.txt_Remark.TabIndex = 11
        '
        'UltraLabel1
        '
        Appearance26.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance26
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel1.Location = New System.Drawing.Point(95, 143)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(47, 14)
        Me.UltraLabel1.TabIndex = 8
        Me.UltraLabel1.Text = "Location"
        '
        'txt_location
        '
        Appearance27.FontData.BoldAsString = "False"
        Appearance27.FontData.ItalicAsString = "False"
        Appearance27.FontData.Name = "Arial"
        Appearance27.FontData.SizeInPoints = 8.25!
        Appearance27.FontData.StrikeoutAsString = "False"
        Appearance27.FontData.UnderlineAsString = "False"
        Me.txt_location.Appearance = Appearance27
        Me.txt_location.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_location.Location = New System.Drawing.Point(145, 140)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(192, 21)
        Me.txt_location.TabIndex = 9
        '
        'UltraLabel2
        '
        Appearance28.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance28
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(51, 34)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(91, 14)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Instrument Name"
        '
        'UltraLabel6
        '
        Appearance29.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance29
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel6.Location = New System.Drawing.Point(104, 197)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(38, 14)
        Me.UltraLabel6.TabIndex = 12
        Me.UltraLabel6.Text = "Range"
        '
        'txt_descrip
        '
        Appearance30.FontData.BoldAsString = "False"
        Appearance30.FontData.ItalicAsString = "False"
        Appearance30.FontData.Name = "Arial"
        Appearance30.FontData.SizeInPoints = 8.25!
        Appearance30.FontData.StrikeoutAsString = "False"
        Appearance30.FontData.UnderlineAsString = "False"
        Me.txt_descrip.Appearance = Appearance30
        Me.txt_descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_descrip.Location = New System.Drawing.Point(145, 194)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(296, 53)
        Me.txt_descrip.TabIndex = 13
        '
        'txt_InstruName
        '
        Appearance31.FontData.BoldAsString = "False"
        Appearance31.FontData.ItalicAsString = "False"
        Appearance31.FontData.Name = "Arial"
        Appearance31.FontData.SizeInPoints = 8.25!
        Appearance31.FontData.StrikeoutAsString = "False"
        Appearance31.FontData.UnderlineAsString = "False"
        Me.txt_InstruName.Appearance = Appearance31
        Me.txt_InstruName.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_InstruName.Location = New System.Drawing.Point(145, 30)
        Me.txt_InstruName.Name = "txt_InstruName"
        Me.txt_InstruName.Size = New System.Drawing.Size(296, 21)
        Me.txt_InstruName.TabIndex = 1
        '
        'UltraTabControl1
        '
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl3)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl4)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl5)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 277)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(845, 295)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Calibration History"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Range and Accuracy Data"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Breakdowns"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Preventive Maintenance"
        UltraTab4.Key = "params"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "Parameters"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab5, UltraTab3, UltraTab4})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(841, 269)
        '
        'frmInstru
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Instrument"
        Me.ClientSize = New System.Drawing.Size(845, 620)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmInstru"
        Me.Text = "Instrument"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGridCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGridUC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.chk_UseScaleFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.UltraGridBD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGridPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.PerformLayout()
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.txt_Param10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param8, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.cmb_MacTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_NotinUse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txt_CalibFreq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_CalibDueOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chk_ForProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GradeAccu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ManuSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_BoughtOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Model, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CodeNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_InstruName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGridBD As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnDelBD As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddBD As Infragistics.Win.Misc.UltraButton

#End Region
End Class

