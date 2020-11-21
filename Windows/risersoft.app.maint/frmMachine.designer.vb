<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMachine
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
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_MacTypeID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_macNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_shiftid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_StatusOK As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Capacity As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ManuSerial As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dt_InstalledOn As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Model As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblMake As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Make As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_location As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraGrid3 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents lblp As System.Windows.Forms.Label
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents txt_Param7 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblr As System.Windows.Forms.Label
    Friend WithEvents txt_Param6 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblq As System.Windows.Forms.Label
    Friend WithEvents txt_Param5 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param2 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnDelMaint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddMaint As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents btnDelSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnEditSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddSpare As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_PlnCapResID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_BatchMin As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_AssetClass = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_BatchMin = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_PlnCapResID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_shiftid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_StatusOK = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Capacity = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ManuSerial = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_InstalledOn = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Model = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMake = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Make = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_location = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
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
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnEditSpare = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddSpare = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid3 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDelMaint = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddMaint = New Infragistics.Win.Misc.UltraButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_MacTypeID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_macNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl4.SuspendLayout()
        CType(Me.cmb_AssetClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BatchMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_PlnCapResID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_shiftid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Capacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ManuSerial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_InstalledOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Model, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_location, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl5.SuspendLayout()
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
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_MacTypeID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_macNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Controls.Add(Me.Label2)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_AssetClass)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel11)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_StatusOK)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_BatchMin)
        Me.UltraTabPageControl4.Controls.Add(Me.Label1)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_PlnCapResID)
        Me.UltraTabPageControl4.Controls.Add(Me.Label3)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_shiftid)
        Me.UltraTabPageControl4.Controls.Add(Me.cmb_matdepid)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Capacity)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_ManuSerial)
        Me.UltraTabPageControl4.Controls.Add(Me.dt_InstalledOn)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel5)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Model)
        Me.UltraTabPageControl4.Controls.Add(Me.lblMake)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_Make)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_location)
        Me.UltraTabPageControl4.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl4.Controls.Add(Me.txt_descrip)
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(778, 332)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Asset Class"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_AssetClass
        '
        Appearance1.FontData.BoldAsString = "False"
        Me.cmb_AssetClass.Appearance = Appearance1
        Me.cmb_AssetClass.Location = New System.Drawing.Point(458, 291)
        Me.cmb_AssetClass.Name = "cmb_AssetClass"
        Me.cmb_AssetClass.Size = New System.Drawing.Size(224, 22)
        Me.cmb_AssetClass.TabIndex = 25
        Me.cmb_AssetClass.Text = "UltraCombo5"
        '
        'UltraLabel11
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance2
        Me.UltraLabel11.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel11.Location = New System.Drawing.Point(34, 292)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(144, 16)
        Me.UltraLabel11.TabIndex = 22
        Me.UltraLabel11.Text = "Batch Minimum"
        '
        'txt_BatchMin
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.txt_BatchMin.Appearance = Appearance4
        Me.txt_BatchMin.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_BatchMin.Location = New System.Drawing.Point(178, 292)
        Me.txt_BatchMin.Name = "txt_BatchMin"
        Me.txt_BatchMin.Size = New System.Drawing.Size(160, 21)
        Me.txt_BatchMin.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(338, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Capacity Resource"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_PlnCapResID
        '
        Appearance5.FontData.BoldAsString = "False"
        Me.cmb_PlnCapResID.Appearance = Appearance5
        Me.cmb_PlnCapResID.Location = New System.Drawing.Point(458, 260)
        Me.cmb_PlnCapResID.Name = "cmb_PlnCapResID"
        Me.cmb_PlnCapResID.Size = New System.Drawing.Size(224, 22)
        Me.cmb_PlnCapResID.TabIndex = 21
        Me.cmb_PlnCapResID.Text = "UltraCombo5"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(130, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Shift"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_shiftid
        '
        Appearance6.FontData.BoldAsString = "False"
        Me.cmb_shiftid.Appearance = Appearance6
        Me.cmb_shiftid.Location = New System.Drawing.Point(178, 260)
        Me.cmb_shiftid.Name = "cmb_shiftid"
        Me.cmb_shiftid.Size = New System.Drawing.Size(160, 22)
        Me.cmb_shiftid.TabIndex = 19
        Me.cmb_shiftid.Text = "UltraCombo5"
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(178, 152)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.Size = New System.Drawing.Size(192, 22)
        Me.cmb_matdepid.TabIndex = 13
        '
        'UltraLabel7
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance7
        Me.UltraLabel7.Location = New System.Drawing.Point(98, 152)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel7.TabIndex = 12
        Me.UltraLabel7.Text = "Department"
        '
        'cmb_StatusOK
        '
        Me.cmb_StatusOK.Location = New System.Drawing.Point(458, 55)
        Me.cmb_StatusOK.Name = "cmb_StatusOK"
        Me.cmb_StatusOK.Size = New System.Drawing.Size(224, 21)
        Me.cmb_StatusOK.TabIndex = 5
        Me.cmb_StatusOK.Text = "UltraComboEditor1"
        '
        'UltraLabel8
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance8
        Me.UltraLabel8.Location = New System.Drawing.Point(122, 120)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel8.TabIndex = 10
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
        Me.txt_Capacity.Location = New System.Drawing.Point(178, 120)
        Me.txt_Capacity.Name = "txt_Capacity"
        Me.txt_Capacity.Size = New System.Drawing.Size(504, 21)
        Me.txt_Capacity.TabIndex = 11
        '
        'UltraLabel10
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance3
        Me.UltraLabel10.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel10.Location = New System.Drawing.Point(402, 55)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel10.TabIndex = 4
        Me.UltraLabel10.Text = "Status"
        '
        'UltraLabel9
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance10
        Me.UltraLabel9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel9.Location = New System.Drawing.Point(90, 88)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(80, 24)
        Me.UltraLabel9.TabIndex = 8
        Me.UltraLabel9.Text = "Manufacturer's Serial No."
        '
        'txt_ManuSerial
        '
        Appearance11.FontData.BoldAsString = "False"
        Appearance11.FontData.ItalicAsString = "False"
        Appearance11.FontData.Name = "Arial"
        Appearance11.FontData.SizeInPoints = 8.25!
        Appearance11.FontData.StrikeoutAsString = "False"
        Appearance11.FontData.UnderlineAsString = "False"
        Me.txt_ManuSerial.Appearance = Appearance11
        Me.txt_ManuSerial.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_ManuSerial.Location = New System.Drawing.Point(178, 88)
        Me.txt_ManuSerial.Name = "txt_ManuSerial"
        Me.txt_ManuSerial.Size = New System.Drawing.Size(504, 21)
        Me.txt_ManuSerial.TabIndex = 9
        '
        'dt_InstalledOn
        '
        Appearance12.FontData.BoldAsString = "False"
        Appearance12.FontData.ItalicAsString = "False"
        Appearance12.FontData.Name = "Arial"
        Appearance12.FontData.SizeInPoints = 8.25!
        Appearance12.FontData.StrikeoutAsString = "False"
        Appearance12.FontData.UnderlineAsString = "False"
        Me.dt_InstalledOn.Appearance = Appearance12
        Me.dt_InstalledOn.DateTime = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_InstalledOn.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.dt_InstalledOn.FormatString = "dddd dd MMM yyyy"
        Me.dt_InstalledOn.Location = New System.Drawing.Point(178, 55)
        Me.dt_InstalledOn.Name = "dt_InstalledOn"
        Me.dt_InstalledOn.NullText = "Not Defined"
        Me.dt_InstalledOn.Size = New System.Drawing.Size(160, 21)
        Me.dt_InstalledOn.TabIndex = 7
        Me.dt_InstalledOn.Value = Nothing
        '
        'UltraLabel5
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance13
        Me.UltraLabel5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel5.Location = New System.Drawing.Point(104, 57)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(72, 16)
        Me.UltraLabel5.TabIndex = 6
        Me.UltraLabel5.Text = "Installed On"
        '
        'UltraLabel4
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance14
        Me.UltraLabel4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel4.Location = New System.Drawing.Point(416, 27)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(40, 16)
        Me.UltraLabel4.TabIndex = 2
        Me.UltraLabel4.Text = "Model"
        '
        'txt_Model
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.ItalicAsString = "False"
        Appearance15.FontData.Name = "Arial"
        Appearance15.FontData.SizeInPoints = 8.25!
        Appearance15.FontData.StrikeoutAsString = "False"
        Appearance15.FontData.UnderlineAsString = "False"
        Me.txt_Model.Appearance = Appearance15
        Me.txt_Model.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Model.Location = New System.Drawing.Point(458, 24)
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.Size = New System.Drawing.Size(224, 21)
        Me.txt_Model.TabIndex = 3
        '
        'lblMake
        '
        Appearance16.TextHAlignAsString = "Right"
        Me.lblMake.Appearance = Appearance16
        Me.lblMake.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblMake.Location = New System.Drawing.Point(122, 24)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(48, 16)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "Make"
        '
        'txt_Make
        '
        Appearance17.FontData.BoldAsString = "False"
        Appearance17.FontData.ItalicAsString = "False"
        Appearance17.FontData.Name = "Arial"
        Appearance17.FontData.SizeInPoints = 8.25!
        Appearance17.FontData.StrikeoutAsString = "False"
        Appearance17.FontData.UnderlineAsString = "False"
        Me.txt_Make.Appearance = Appearance17
        Me.txt_Make.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Make.Location = New System.Drawing.Point(178, 24)
        Me.txt_Make.Name = "txt_Make"
        Me.txt_Make.Size = New System.Drawing.Size(160, 21)
        Me.txt_Make.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance18.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance18
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel1.Location = New System.Drawing.Point(402, 152)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(48, 16)
        Me.UltraLabel1.TabIndex = 14
        Me.UltraLabel1.Text = "Location"
        '
        'txt_location
        '
        Appearance19.FontData.BoldAsString = "False"
        Appearance19.FontData.ItalicAsString = "False"
        Appearance19.FontData.Name = "Arial"
        Appearance19.FontData.SizeInPoints = 8.25!
        Appearance19.FontData.StrikeoutAsString = "False"
        Appearance19.FontData.UnderlineAsString = "False"
        Me.txt_location.Appearance = Appearance19
        Me.txt_location.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_location.Location = New System.Drawing.Point(458, 152)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(224, 21)
        Me.txt_location.TabIndex = 15
        '
        'UltraLabel6
        '
        Appearance20.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance20
        Me.UltraLabel6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel6.Location = New System.Drawing.Point(106, 184)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel6.TabIndex = 16
        Me.UltraLabel6.Text = "Description"
        '
        'txt_descrip
        '
        Appearance21.FontData.BoldAsString = "False"
        Appearance21.FontData.ItalicAsString = "False"
        Appearance21.FontData.Name = "Arial"
        Appearance21.FontData.SizeInPoints = 8.25!
        Appearance21.FontData.StrikeoutAsString = "False"
        Appearance21.FontData.UnderlineAsString = "False"
        Me.txt_descrip.Appearance = Appearance21
        Me.txt_descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_descrip.Location = New System.Drawing.Point(178, 184)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(504, 64)
        Me.txt_descrip.TabIndex = 17
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.lblc)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param10)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param9)
        Me.UltraTabPageControl5.Controls.Add(Me.lblb)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param8)
        Me.UltraTabPageControl5.Controls.Add(Me.lbla)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param7)
        Me.UltraTabPageControl5.Controls.Add(Me.lblr)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param6)
        Me.UltraTabPageControl5.Controls.Add(Me.lblq)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param5)
        Me.UltraTabPageControl5.Controls.Add(Me.lblp)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param4)
        Me.UltraTabPageControl5.Controls.Add(Me.lblS)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param3)
        Me.UltraTabPageControl5.Controls.Add(Me.lblZ)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param2)
        Me.UltraTabPageControl5.Controls.Add(Me.lblY)
        Me.UltraTabPageControl5.Controls.Add(Me.txt_Param1)
        Me.UltraTabPageControl5.Controls.Add(Me.lblX)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(778, 332)
        '
        'lblc
        '
        Me.lblc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblc.Location = New System.Drawing.Point(25, 292)
        Me.lblc.Name = "lblc"
        Me.lblc.Size = New System.Drawing.Size(264, 16)
        Me.lblc.TabIndex = 18
        Me.lblc.Text = "Item Code"
        Me.lblc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param10
        '
        Me.txt_Param10.Location = New System.Drawing.Point(297, 289)
        Me.txt_Param10.Name = "txt_Param10"
        Me.txt_Param10.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param10.TabIndex = 19
        Me.txt_Param10.Text = "UltraTextEditor5"
        '
        'txt_Param9
        '
        Me.txt_Param9.Location = New System.Drawing.Point(297, 262)
        Me.txt_Param9.Name = "txt_Param9"
        Me.txt_Param9.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param9.TabIndex = 17
        Me.txt_Param9.Text = "UltraTextEditor5"
        '
        'lblb
        '
        Me.lblb.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblb.Location = New System.Drawing.Point(25, 262)
        Me.lblb.Name = "lblb"
        Me.lblb.Size = New System.Drawing.Size(264, 16)
        Me.lblb.TabIndex = 16
        Me.lblb.Text = "Item Code"
        Me.lblb.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param8
        '
        Me.txt_Param8.Location = New System.Drawing.Point(297, 235)
        Me.txt_Param8.Name = "txt_Param8"
        Me.txt_Param8.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param8.TabIndex = 15
        Me.txt_Param8.Text = "UltraTextEditor5"
        '
        'lbla
        '
        Me.lbla.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lbla.Location = New System.Drawing.Point(25, 235)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(264, 16)
        Me.lbla.TabIndex = 14
        Me.lbla.Text = "Item Code"
        Me.lbla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param7
        '
        Me.txt_Param7.Location = New System.Drawing.Point(297, 208)
        Me.txt_Param7.Name = "txt_Param7"
        Me.txt_Param7.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param7.TabIndex = 13
        Me.txt_Param7.Text = "UltraTextEditor5"
        '
        'lblr
        '
        Me.lblr.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblr.Location = New System.Drawing.Point(25, 208)
        Me.lblr.Name = "lblr"
        Me.lblr.Size = New System.Drawing.Size(264, 16)
        Me.lblr.TabIndex = 12
        Me.lblr.Text = "Item Code"
        Me.lblr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param6
        '
        Me.txt_Param6.Location = New System.Drawing.Point(297, 176)
        Me.txt_Param6.Name = "txt_Param6"
        Me.txt_Param6.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param6.TabIndex = 11
        Me.txt_Param6.Text = "UltraTextEditor5"
        '
        'lblq
        '
        Me.lblq.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblq.Location = New System.Drawing.Point(25, 176)
        Me.lblq.Name = "lblq"
        Me.lblq.Size = New System.Drawing.Size(264, 16)
        Me.lblq.TabIndex = 10
        Me.lblq.Text = "Item Code"
        Me.lblq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param5
        '
        Me.txt_Param5.Location = New System.Drawing.Point(297, 144)
        Me.txt_Param5.Name = "txt_Param5"
        Me.txt_Param5.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param5.TabIndex = 9
        Me.txt_Param5.Text = "UltraTextEditor5"
        '
        'lblp
        '
        Me.lblp.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblp.Location = New System.Drawing.Point(25, 144)
        Me.lblp.Name = "lblp"
        Me.lblp.Size = New System.Drawing.Size(264, 16)
        Me.lblp.TabIndex = 8
        Me.lblp.Text = "Item Code"
        Me.lblp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param4
        '
        Me.txt_Param4.Location = New System.Drawing.Point(297, 112)
        Me.txt_Param4.Name = "txt_Param4"
        Me.txt_Param4.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param4.TabIndex = 7
        Me.txt_Param4.Text = "UltraTextEditor5"
        '
        'lblS
        '
        Me.lblS.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblS.Location = New System.Drawing.Point(25, 112)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(264, 16)
        Me.lblS.TabIndex = 6
        Me.lblS.Text = "Item Code"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param3
        '
        Me.txt_Param3.Location = New System.Drawing.Point(297, 80)
        Me.txt_Param3.Name = "txt_Param3"
        Me.txt_Param3.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param3.TabIndex = 5
        Me.txt_Param3.Text = "UltraTextEditor4"
        '
        'lblZ
        '
        Me.lblZ.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblZ.Location = New System.Drawing.Point(25, 80)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(264, 16)
        Me.lblZ.TabIndex = 4
        Me.lblZ.Text = "Item Code"
        Me.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param2
        '
        Me.txt_Param2.Location = New System.Drawing.Point(297, 48)
        Me.txt_Param2.Name = "txt_Param2"
        Me.txt_Param2.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param2.TabIndex = 3
        Me.txt_Param2.Text = "UltraTextEditor3"
        '
        'lblY
        '
        Me.lblY.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblY.Location = New System.Drawing.Point(25, 48)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(264, 16)
        Me.lblY.TabIndex = 2
        Me.lblY.Text = "Item Code"
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param1
        '
        Me.txt_Param1.Location = New System.Drawing.Point(297, 16)
        Me.txt_Param1.Name = "txt_Param1"
        Me.txt_Param1.Size = New System.Drawing.Size(448, 21)
        Me.txt_Param1.TabIndex = 1
        Me.txt_Param1.Text = "UltraTextEditor2"
        '
        'lblX
        '
        Me.lblX.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblX.Location = New System.Drawing.Point(25, 16)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(264, 16)
        Me.lblX.TabIndex = 0
        Me.lblX.Text = "Item Code"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(778, 332)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(778, 292)
        Me.UltraGrid1.TabIndex = 0
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnDelDoc)
        Me.Panel3.Controls.Add(Me.btnAddDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(0, 292)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(778, 40)
        Me.Panel3.TabIndex = 1
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelDoc.Location = New System.Drawing.Point(608, 8)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "&Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddDoc.Location = New System.Drawing.Point(698, 8)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 1
        Me.btnAddDoc.Text = "&Add New"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(778, 332)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(778, 284)
        Me.UltraGrid2.TabIndex = 0
        Me.UltraGrid2.Text = "UltraGrid2"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDelSpare)
        Me.Panel2.Controls.Add(Me.btnEditSpare)
        Me.Panel2.Controls.Add(Me.btnAddSpare)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(778, 48)
        Me.Panel2.TabIndex = 1
        '
        'btnDelSpare
        '
        Appearance22.FontData.BoldAsString = "True"
        Me.btnDelSpare.Appearance = Appearance22
        Me.btnDelSpare.Location = New System.Drawing.Point(432, 16)
        Me.btnDelSpare.Name = "btnDelSpare"
        Me.btnDelSpare.Size = New System.Drawing.Size(64, 24)
        Me.btnDelSpare.TabIndex = 0
        Me.btnDelSpare.Text = "Delete"
        '
        'btnEditSpare
        '
        Appearance23.FontData.BoldAsString = "True"
        Me.btnEditSpare.Appearance = Appearance23
        Me.btnEditSpare.Location = New System.Drawing.Point(504, 16)
        Me.btnEditSpare.Name = "btnEditSpare"
        Me.btnEditSpare.Size = New System.Drawing.Size(64, 24)
        Me.btnEditSpare.TabIndex = 1
        Me.btnEditSpare.Text = "Edit"
        '
        'btnAddSpare
        '
        Appearance24.FontData.BoldAsString = "True"
        Me.btnAddSpare.Appearance = Appearance24
        Me.btnAddSpare.Location = New System.Drawing.Point(576, 16)
        Me.btnAddSpare.Name = "btnAddSpare"
        Me.btnAddSpare.Size = New System.Drawing.Size(64, 24)
        Me.btnAddSpare.TabIndex = 2
        Me.btnAddSpare.Text = "Add"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid3)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel5)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(778, 332)
        '
        'UltraGrid3
        '
        Me.UltraGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGrid3.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid3.Name = "UltraGrid3"
        Me.UltraGrid3.Size = New System.Drawing.Size(778, 292)
        Me.UltraGrid3.TabIndex = 0
        Me.UltraGrid3.Text = "UltraGrid3"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDelMaint)
        Me.Panel5.Controls.Add(Me.btnAddMaint)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel5.Location = New System.Drawing.Point(0, 292)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(778, 40)
        Me.Panel5.TabIndex = 1
        '
        'btnDelMaint
        '
        Me.btnDelMaint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelMaint.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelMaint.Location = New System.Drawing.Point(608, 8)
        Me.btnDelMaint.Name = "btnDelMaint"
        Me.btnDelMaint.Size = New System.Drawing.Size(70, 24)
        Me.btnDelMaint.TabIndex = 0
        Me.btnDelMaint.Text = "&Delete"
        '
        'btnAddMaint
        '
        Me.btnAddMaint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddMaint.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddMaint.Location = New System.Drawing.Point(698, 8)
        Me.btnAddMaint.Name = "btnAddMaint"
        Me.btnAddMaint.Size = New System.Drawing.Size(72, 24)
        Me.btnAddMaint.TabIndex = 1
        Me.btnAddMaint.Text = "&Add New"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 406)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance25.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance25
        Me.btnSave.Location = New System.Drawing.Point(494, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance26.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance26
        Me.btnCancel.Location = New System.Drawing.Point(590, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance27.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance27
        Me.btnOK.Location = New System.Drawing.Point(686, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'UltraLabel3
        '
        Appearance28.FontData.BoldAsString = "True"
        Appearance28.FontData.SizeInPoints = 9.0!
        Appearance28.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance28
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel3.Location = New System.Drawing.Point(39, 12)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(86, 15)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Machine Type"
        '
        'cmb_MacTypeID
        '
        Appearance29.FontData.BoldAsString = "True"
        Appearance29.FontData.SizeInPoints = 9.0!
        Me.cmb_MacTypeID.Appearance = Appearance29
        Me.cmb_MacTypeID.DataMember = "mtype"
        Me.cmb_MacTypeID.DisplayMember = "mactype"
        Me.cmb_MacTypeID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_MacTypeID.Location = New System.Drawing.Point(128, 8)
        Me.cmb_MacTypeID.Name = "cmb_MacTypeID"
        Me.cmb_MacTypeID.Size = New System.Drawing.Size(264, 23)
        Me.cmb_MacTypeID.TabIndex = 1
        Me.cmb_MacTypeID.ValueMember = "mactypeid"
        '
        'UltraLabel2
        '
        Appearance30.FontData.BoldAsString = "True"
        Appearance30.FontData.SizeInPoints = 9.0!
        Appearance30.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance30
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(413, 12)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(104, 15)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Machine Number"
        '
        'txt_macNum
        '
        Appearance31.FontData.BoldAsString = "True"
        Appearance31.FontData.ItalicAsString = "False"
        Appearance31.FontData.Name = "Arial"
        Appearance31.FontData.SizeInPoints = 9.0!
        Appearance31.FontData.StrikeoutAsString = "False"
        Appearance31.FontData.UnderlineAsString = "False"
        Me.txt_macNum.Appearance = Appearance31
        Me.txt_macNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_macNum.Location = New System.Drawing.Point(520, 8)
        Me.txt_macNum.Name = "txt_macNum"
        Me.txt_macNum.Size = New System.Drawing.Size(128, 22)
        Me.txt_macNum.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.cmb_MacTypeID)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.txt_macNum)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 48)
        Me.Panel1.TabIndex = 0
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
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 48)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(782, 358)
        Me.UltraTabControl1.TabIndex = 0
        UltraTab1.TabPage = Me.UltraTabPageControl4
        UltraTab1.Text = "Details"
        UltraTab2.Key = "Params"
        UltraTab2.TabPage = Me.UltraTabPageControl5
        UltraTab2.Text = "Parameters"
        UltraTab3.TabPage = Me.UltraTabPageControl1
        UltraTab3.Text = "Breakdowns"
        UltraTab4.TabPage = Me.UltraTabPageControl2
        UltraTab4.Text = "Spare Parts"
        UltraTab5.TabPage = Me.UltraTabPageControl3
        UltraTab5.Text = "Preventive Maintenance"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(778, 332)
        '
        'frmMachine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Machine Details"
        Me.ClientSize = New System.Drawing.Size(782, 454)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMachine"
        Me.Text = "Machine Details"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl4.ResumeLayout(False)
        Me.UltraTabPageControl4.PerformLayout()
        CType(Me.cmb_AssetClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BatchMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_PlnCapResID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_shiftid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Capacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ManuSerial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_InstalledOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Model, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Make, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_location, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descrip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl5.ResumeLayout(False)
        Me.UltraTabPageControl5.PerformLayout()
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
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_MacTypeID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_macNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_Param10 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Param9 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblb As System.Windows.Forms.Label
    Friend WithEvents txt_Param8 As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lbla As System.Windows.Forms.Label
    Friend WithEvents lblc As System.Windows.Forms.Label
    Friend WithEvents cmb_AssetClass As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label

#End Region
End Class

