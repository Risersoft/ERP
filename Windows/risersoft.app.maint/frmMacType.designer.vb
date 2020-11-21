Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMacType
    Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        InitForm()
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_MacType As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_PrevMaintFreqWeeks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PanelPrm As System.Windows.Forms.Panel
    Friend WithEvents txt_Param7Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_Param6Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_Param5name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Param4Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblS As System.Windows.Forms.Label
    Friend WithEvents txt_Param3Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblZ As System.Windows.Forms.Label
    Friend WithEvents txt_Param2Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents txt_Param1Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents btnUp As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDown As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAdd As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents chk_hasparams As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents txt_MacTypeNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl3 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDelParam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddParam As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab4 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab5 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.chk_hasparams = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_PrevMaintFreqWeeks = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelPrm = New System.Windows.Forms.Panel()
        Me.txt_Param10Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Param9Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Param8Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_Param7Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Param6Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Param5name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Param4Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblS = New System.Windows.Forms.Label()
        Me.txt_Param3Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblZ = New System.Windows.Forms.Label()
        Me.txt_Param2Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblY = New System.Windows.Forms.Label()
        Me.txt_Param1Name = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblX = New System.Windows.Forms.Label()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton()
        Me.btnUp = New Infragistics.Win.Misc.UltraButton()
        Me.btnDown = New Infragistics.Win.Misc.UltraButton()
        Me.btnDel = New Infragistics.Win.Misc.UltraButton()
        Me.btnAdd = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl3 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDelParam = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddParam = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabPageControl4 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraTabPageControl5 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.pic_PicPerson = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSavepic = New Infragistics.Win.Misc.UltraButton()
        Me.UltraButton4 = New Infragistics.Win.Misc.UltraButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_EquipType = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_MacTypeNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_MacType = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.chk_hasparams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PrevMaintFreqWeeks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrm.SuspendLayout()
        CType(Me.txt_Param10Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param9Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param8Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param7Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param6Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param5name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param4Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param3Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param2Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Param1Name, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.UltraTabPageControl3.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.UltraTabPageControl5.SuspendLayout()
        CType(Me.pic_PicPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_EquipType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MacTypeNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_MacType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.chk_hasparams)
        Me.UltraTabPageControl1.Controls.Add(Me.Label17)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_PrevMaintFreqWeeks)
        Me.UltraTabPageControl1.Controls.Add(Me.Label4)
        Me.UltraTabPageControl1.Controls.Add(Me.PanelPrm)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(1, 23)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(591, 313)
        '
        'chk_hasparams
        '
        Me.chk_hasparams.Location = New System.Drawing.Point(106, 3)
        Me.chk_hasparams.Name = "chk_hasparams"
        Me.chk_hasparams.Size = New System.Drawing.Size(112, 24)
        Me.chk_hasparams.TabIndex = 1
        Me.chk_hasparams.Text = "Has Paramters"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(10, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 24)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Parameter Names"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PrevMaintFreqWeeks
        '
        Me.txt_PrevMaintFreqWeeks.Location = New System.Drawing.Point(453, 6)
        Me.txt_PrevMaintFreqWeeks.Name = "txt_PrevMaintFreqWeeks"
        Me.txt_PrevMaintFreqWeeks.Size = New System.Drawing.Size(80, 21)
        Me.txt_PrevMaintFreqWeeks.TabIndex = 4
        Me.txt_PrevMaintFreqWeeks.Text = "UltraTextEditor1"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(357, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Frequency of Preventive Maintenance (Weeks)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelPrm
        '
        Me.PanelPrm.Controls.Add(Me.txt_Param10Name)
        Me.PanelPrm.Controls.Add(Me.Label9)
        Me.PanelPrm.Controls.Add(Me.txt_Param9Name)
        Me.PanelPrm.Controls.Add(Me.Label8)
        Me.PanelPrm.Controls.Add(Me.txt_Param8Name)
        Me.PanelPrm.Controls.Add(Me.Label7)
        Me.PanelPrm.Controls.Add(Me.txt_Param7Name)
        Me.PanelPrm.Controls.Add(Me.Label3)
        Me.PanelPrm.Controls.Add(Me.txt_Param6Name)
        Me.PanelPrm.Controls.Add(Me.Label1)
        Me.PanelPrm.Controls.Add(Me.txt_Param5name)
        Me.PanelPrm.Controls.Add(Me.Label5)
        Me.PanelPrm.Controls.Add(Me.txt_Param4Name)
        Me.PanelPrm.Controls.Add(Me.lblS)
        Me.PanelPrm.Controls.Add(Me.txt_Param3Name)
        Me.PanelPrm.Controls.Add(Me.lblZ)
        Me.PanelPrm.Controls.Add(Me.txt_Param2Name)
        Me.PanelPrm.Controls.Add(Me.lblY)
        Me.PanelPrm.Controls.Add(Me.txt_Param1Name)
        Me.PanelPrm.Controls.Add(Me.lblX)
        Me.PanelPrm.Location = New System.Drawing.Point(106, 27)
        Me.PanelPrm.Name = "PanelPrm"
        Me.PanelPrm.Size = New System.Drawing.Size(240, 294)
        Me.PanelPrm.TabIndex = 2
        '
        'txt_Param10Name
        '
        Me.txt_Param10Name.Location = New System.Drawing.Point(95, 250)
        Me.txt_Param10Name.Name = "txt_Param10Name"
        Me.txt_Param10Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param10Name.TabIndex = 0
        Me.txt_Param10Name.Text = "UltraTextEditor5"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(15, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Param 10"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param9Name
        '
        Me.txt_Param9Name.Location = New System.Drawing.Point(95, 223)
        Me.txt_Param9Name.Name = "txt_Param9Name"
        Me.txt_Param9Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param9Name.TabIndex = 18
        Me.txt_Param9Name.Text = "UltraTextEditor5"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(15, 223)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Param 9"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param8Name
        '
        Me.txt_Param8Name.Location = New System.Drawing.Point(95, 196)
        Me.txt_Param8Name.Name = "txt_Param8Name"
        Me.txt_Param8Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param8Name.TabIndex = 16
        Me.txt_Param8Name.Text = "UltraTextEditor5"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(15, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Param 8"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param7Name
        '
        Me.txt_Param7Name.Location = New System.Drawing.Point(95, 169)
        Me.txt_Param7Name.Name = "txt_Param7Name"
        Me.txt_Param7Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param7Name.TabIndex = 14
        Me.txt_Param7Name.Text = "UltraTextEditor5"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(15, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Param 7"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param6Name
        '
        Me.txt_Param6Name.Location = New System.Drawing.Point(95, 142)
        Me.txt_Param6Name.Name = "txt_Param6Name"
        Me.txt_Param6Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param6Name.TabIndex = 12
        Me.txt_Param6Name.Text = "UltraTextEditor5"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(15, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Param 6"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param5name
        '
        Me.txt_Param5name.Location = New System.Drawing.Point(95, 115)
        Me.txt_Param5name.Name = "txt_Param5name"
        Me.txt_Param5name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param5name.TabIndex = 10
        Me.txt_Param5name.Text = "UltraTextEditor5"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(15, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Param 5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param4Name
        '
        Me.txt_Param4Name.Location = New System.Drawing.Point(95, 88)
        Me.txt_Param4Name.Name = "txt_Param4Name"
        Me.txt_Param4Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param4Name.TabIndex = 8
        Me.txt_Param4Name.Text = "UltraTextEditor5"
        '
        'lblS
        '
        Me.lblS.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblS.Location = New System.Drawing.Point(15, 88)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(56, 16)
        Me.lblS.TabIndex = 7
        Me.lblS.Text = "Param 4"
        Me.lblS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param3Name
        '
        Me.txt_Param3Name.Location = New System.Drawing.Point(95, 61)
        Me.txt_Param3Name.Name = "txt_Param3Name"
        Me.txt_Param3Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param3Name.TabIndex = 6
        Me.txt_Param3Name.Text = "UltraTextEditor4"
        '
        'lblZ
        '
        Me.lblZ.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblZ.Location = New System.Drawing.Point(15, 61)
        Me.lblZ.Name = "lblZ"
        Me.lblZ.Size = New System.Drawing.Size(56, 16)
        Me.lblZ.TabIndex = 5
        Me.lblZ.Text = "Param 3"
        Me.lblZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param2Name
        '
        Me.txt_Param2Name.Location = New System.Drawing.Point(95, 34)
        Me.txt_Param2Name.Name = "txt_Param2Name"
        Me.txt_Param2Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param2Name.TabIndex = 4
        Me.txt_Param2Name.Text = "UltraTextEditor3"
        '
        'lblY
        '
        Me.lblY.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblY.Location = New System.Drawing.Point(15, 34)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(56, 16)
        Me.lblY.TabIndex = 3
        Me.lblY.Text = "Param 2"
        Me.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Param1Name
        '
        Me.txt_Param1Name.Location = New System.Drawing.Point(95, 7)
        Me.txt_Param1Name.Name = "txt_Param1Name"
        Me.txt_Param1Name.Size = New System.Drawing.Size(128, 21)
        Me.txt_Param1Name.TabIndex = 2
        Me.txt_Param1Name.Text = "UltraTextEditor2"
        '
        'lblX
        '
        Me.lblX.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblX.Location = New System.Drawing.Point(15, 7)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(56, 16)
        Me.lblX.TabIndex = 1
        Me.lblX.Text = "Param 1"
        Me.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel9)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(591, 313)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(591, 265)
        Me.UltraGrid1.TabIndex = 11
        Me.UltraGrid1.Text = "Delivery Schedule"
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.UltraButton1)
        Me.Panel9.Controls.Add(Me.btnUp)
        Me.Panel9.Controls.Add(Me.btnDown)
        Me.Panel9.Controls.Add(Me.btnDel)
        Me.Panel9.Controls.Add(Me.btnAdd)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 265)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(591, 48)
        Me.Panel9.TabIndex = 10
        '
        'UltraButton1
        '
        Me.UltraButton1.Location = New System.Drawing.Point(176, 16)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(80, 24)
        Me.UltraButton1.TabIndex = 6
        Me.UltraButton1.Text = "Renumber"
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(8, 16)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(70, 24)
        Me.btnUp.TabIndex = 5
        Me.btnUp.Text = "Move Up"
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(88, 16)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(80, 24)
        Me.btnDown.TabIndex = 4
        Me.btnDown.Text = "Move Down"
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.Location = New System.Drawing.Point(403, 16)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 24)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(499, 16)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(72, 24)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add New"
        '
        'UltraTabPageControl3
        '
        Me.UltraTabPageControl3.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl3.Controls.Add(Me.Panel2)
        Me.UltraTabPageControl3.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl3.Name = "UltraTabPageControl3"
        Me.UltraTabPageControl3.Size = New System.Drawing.Size(591, 313)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(591, 265)
        Me.UltraGrid2.TabIndex = 13
        Me.UltraGrid2.Text = "Delivery Schedule"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnDelParam)
        Me.Panel2.Controls.Add(Me.btnAddParam)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(591, 48)
        Me.Panel2.TabIndex = 12
        '
        'btnDelParam
        '
        Me.btnDelParam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelParam.Location = New System.Drawing.Point(403, 16)
        Me.btnDelParam.Name = "btnDelParam"
        Me.btnDelParam.Size = New System.Drawing.Size(70, 24)
        Me.btnDelParam.TabIndex = 3
        Me.btnDelParam.Text = "Delete"
        '
        'btnAddParam
        '
        Me.btnAddParam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddParam.Location = New System.Drawing.Point(499, 16)
        Me.btnAddParam.Name = "btnAddParam"
        Me.btnAddParam.Size = New System.Drawing.Size(72, 24)
        Me.btnAddParam.TabIndex = 2
        Me.btnAddParam.Text = "Add New"
        '
        'UltraTabPageControl4
        '
        Me.UltraTabPageControl4.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl4.Name = "UltraTabPageControl4"
        Me.UltraTabPageControl4.Size = New System.Drawing.Size(591, 313)
        '
        'UltraTabPageControl5
        '
        Me.UltraTabPageControl5.Controls.Add(Me.pic_PicPerson)
        Me.UltraTabPageControl5.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl5.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl5.Name = "UltraTabPageControl5"
        Me.UltraTabPageControl5.Size = New System.Drawing.Size(591, 313)
        '
        'pic_PicPerson
        '
        Me.pic_PicPerson.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_PicPerson.Location = New System.Drawing.Point(0, 0)
        Me.pic_PicPerson.Name = "pic_PicPerson"
        Me.pic_PicPerson.Size = New System.Drawing.Size(338, 260)
        Me.pic_PicPerson.TabIndex = 22
        Me.pic_PicPerson.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnSavepic)
        Me.Panel3.Controls.Add(Me.UltraButton4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 260)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(591, 53)
        Me.Panel3.TabIndex = 23
        '
        'btnSavepic
        '
        Me.btnSavepic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance30.FontData.BoldAsString = "True"
        Me.btnSavepic.Appearance = Appearance30
        Me.btnSavepic.Location = New System.Drawing.Point(492, 6)
        Me.btnSavepic.Name = "btnSavepic"
        Me.btnSavepic.Size = New System.Drawing.Size(89, 32)
        Me.btnSavepic.TabIndex = 12
        Me.btnSavepic.Text = "Save"
        '
        'UltraButton4
        '
        Me.UltraButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance31.FontData.BoldAsString = "True"
        Me.UltraButton4.Appearance = Appearance31
        Me.UltraButton4.Location = New System.Drawing.Point(397, 6)
        Me.UltraButton4.Name = "UltraButton4"
        Me.UltraButton4.Size = New System.Drawing.Size(89, 32)
        Me.UltraButton4.TabIndex = 11
        Me.UltraButton4.Text = "Browse"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.cmb_EquipType)
        Me.Panel1.Controls.Add(Me.txt_MacTypeNum)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txt_MacType)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 116)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel3
        '
        Appearance25.FontData.BoldAsString = "True"
        Appearance25.FontData.SizeInPoints = 9.0!
        Appearance25.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance25
        Me.UltraLabel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel3.Location = New System.Drawing.Point(14, 68)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(138, 24)
        Me.UltraLabel3.TabIndex = 4
        Me.UltraLabel3.Text = "Equipment Type"
        '
        'cmb_EquipType
        '
        Appearance26.FontData.BoldAsString = "True"
        Appearance26.FontData.SizeInPoints = 9.0!
        Me.cmb_EquipType.Appearance = Appearance26
        Me.cmb_EquipType.DataMember = "mtype"
        Me.cmb_EquipType.DisplayMember = "mactype"
        Me.cmb_EquipType.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_EquipType.Location = New System.Drawing.Point(160, 68)
        Me.cmb_EquipType.Name = "cmb_EquipType"
        Me.cmb_EquipType.Size = New System.Drawing.Size(264, 23)
        Me.cmb_EquipType.TabIndex = 5
        Me.cmb_EquipType.ValueMember = "mactypeid"
        '
        'txt_MacTypeNum
        '
        Me.txt_MacTypeNum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MacTypeNum.Location = New System.Drawing.Point(160, 8)
        Me.txt_MacTypeNum.Name = "txt_MacTypeNum"
        Me.txt_MacTypeNum.Size = New System.Drawing.Size(88, 22)
        Me.txt_MacTypeNum.TabIndex = 1
        Me.txt_MacTypeNum.Text = "UltraTextEditor1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(32, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Type No."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_MacType
        '
        Me.txt_MacType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MacType.Location = New System.Drawing.Point(160, 36)
        Me.txt_MacType.Name = "txt_MacType"
        Me.txt_MacType.Size = New System.Drawing.Size(304, 22)
        Me.txt_MacType.TabIndex = 3
        Me.txt_MacType.Text = "UltraTextEditor1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(32, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Machine Type"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 455)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(595, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(307, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(403, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(499, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
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
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 116)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(595, 339)
        Me.UltraTabControl1.TabIndex = 1
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "Machine Parameters"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Preventive Maintenance Parameters"
        UltraTab3.TabPage = Me.UltraTabPageControl3
        UltraTab3.Text = "Parameters"
        UltraTab4.Key = "sys"
        UltraTab4.TabPage = Me.UltraTabPageControl4
        UltraTab4.Text = "System"
        UltraTab5.TabPage = Me.UltraTabPageControl5
        UltraTab5.Text = "Picture"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2, UltraTab3, UltraTab4, UltraTab5})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(591, 313)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMacType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Machine Type"
        Me.ClientSize = New System.Drawing.Size(595, 503)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMacType"
        Me.Text = "Machine Type"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.chk_hasparams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PrevMaintFreqWeeks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrm.ResumeLayout(False)
        Me.PanelPrm.PerformLayout()
        CType(Me.txt_Param10Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param9Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param8Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param7Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param6Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param5name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param4Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param3Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param2Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Param1Name, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.UltraTabPageControl3.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.UltraTabPageControl5.ResumeLayout(False)
        CType(Me.pic_PicPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_EquipType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MacTypeNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_MacType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabPageControl4 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl5 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents pic_PicPerson As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSavepic As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton4 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_Param10Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_Param9Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_Param8Name As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_EquipType As ug.UltraCombo

#End Region
End Class

