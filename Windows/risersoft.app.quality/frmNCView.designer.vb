<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmNCView
	Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.initForm()
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
    Friend WithEvents cmb_ProdSerialID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_clearDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_correcaction As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_investigation As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_ncnum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel5 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_ncdate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents txt_NC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_prevenaction As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_raisedby As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel11 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_WorkBy As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_rectifyBy As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents btnNext As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnPrevious As Infragistics.Win.Misc.UltraButton
    Friend WithEvents textParty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents textRating As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel15 As Infragistics.Win.Misc.UltraLabel
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNext = New Infragistics.Win.Misc.UltraButton()
        Me.btnPrevious = New Infragistics.Win.Misc.UltraButton()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.cmb_ProdSerialID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_clearDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_correcaction = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_investigation = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_ncnum = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel5 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_ncdate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_NC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_prevenaction = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_raisedby = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel11 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_WorkBy = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_rectifyBy = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.textParty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.textRating = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel15 = New Infragistics.Win.Misc.UltraLabel()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.cmb_ProdSerialID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_clearDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_correcaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_investigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ncnum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_ncdate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prevenaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_raisedby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_WorkBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rectifyBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textParty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnNext)
        Me.Panel4.Controls.Add(Me.btnPrevious)
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 494)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(792, 48)
        Me.Panel4.TabIndex = 30
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnNext.Appearance = Appearance1
        Me.btnNext.Location = New System.Drawing.Point(160, 8)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(88, 32)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "&Next"
        '
        'btnPrevious
        '
        Me.btnPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnPrevious.Appearance = Appearance2
        Me.btnPrevious.Location = New System.Drawing.Point(256, 8)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(88, 32)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "&Previous"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance3
        Me.btnSave.Location = New System.Drawing.Point(504, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Location = New System.Drawing.Point(600, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Location = New System.Drawing.Point(696, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        '
        'cmb_ProdSerialID
        '
        Me.cmb_ProdSerialID.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.cmb_ProdSerialID.Location = New System.Drawing.Point(592, 112)
        Me.cmb_ProdSerialID.Name = "cmb_ProdSerialID"
        Me.cmb_ProdSerialID.ReadOnly = True
        Me.cmb_ProdSerialID.Size = New System.Drawing.Size(176, 22)
        Me.cmb_ProdSerialID.TabIndex = 13
        '
        'UltraLabel4
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance6
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Location = New System.Drawing.Point(556, 116)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(33, 14)
        Me.UltraLabel4.TabIndex = 12
        Me.UltraLabel4.Text = "Serial"
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.Location = New System.Drawing.Point(128, 112)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.ReadOnly = True
        Me.cmb_matdepid.Size = New System.Drawing.Size(341, 22)
        Me.cmb_matdepid.TabIndex = 11
        '
        'UltraLabel1
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance7
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Location = New System.Drawing.Point(62, 115)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(63, 14)
        Me.UltraLabel1.TabIndex = 10
        Me.UltraLabel1.Text = "Department"
        '
        'dt_clearDate
        '
        Me.dt_clearDate.FormatString = "dddd dd MMM yyyy  "
        Me.dt_clearDate.Location = New System.Drawing.Point(592, 80)
        Me.dt_clearDate.Name = "dt_clearDate"
        Me.dt_clearDate.NullText = "Not Defined"
        Me.dt_clearDate.ReadOnly = True
        Me.dt_clearDate.Size = New System.Drawing.Size(176, 21)
        Me.dt_clearDate.TabIndex = 9
        '
        'txt_remark
        '
        Me.txt_remark.AcceptsReturn = True
        Me.txt_remark.Location = New System.Drawing.Point(128, 448)
        Me.txt_remark.Multiline = True
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.ReadOnly = True
        Me.txt_remark.Size = New System.Drawing.Size(640, 32)
        Me.txt_remark.TabIndex = 29
        '
        'UltraLabel9
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance8
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(81, 451)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel9.TabIndex = 28
        Me.UltraLabel9.Text = "Remark"
        '
        'UltraLabel8
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance9
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(479, 83)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(110, 14)
        Me.UltraLabel8.TabIndex = 8
        Me.UltraLabel8.Text = "Cleared Date && Time"
        '
        'txt_correcaction
        '
        Me.txt_correcaction.AcceptsReturn = True
        Appearance10.FontData.BoldAsString = "True"
        Me.txt_correcaction.Appearance = Appearance10
        Me.txt_correcaction.Location = New System.Drawing.Point(128, 296)
        Me.txt_correcaction.Multiline = True
        Me.txt_correcaction.Name = "txt_correcaction"
        Me.txt_correcaction.ReadOnly = True
        Me.txt_correcaction.Size = New System.Drawing.Size(640, 64)
        Me.txt_correcaction.TabIndex = 25
        '
        'UltraLabel7
        '
        Appearance11.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance11
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(35, 299)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel7.TabIndex = 24
        Me.UltraLabel7.Text = "Corrective Action"
        '
        'txt_investigation
        '
        Me.txt_investigation.AcceptsReturn = True
        Appearance12.FontData.BoldAsString = "True"
        Me.txt_investigation.Appearance = Appearance12
        Me.txt_investigation.Location = New System.Drawing.Point(128, 232)
        Me.txt_investigation.Multiline = True
        Me.txt_investigation.Name = "txt_investigation"
        Me.txt_investigation.ReadOnly = True
        Me.txt_investigation.Size = New System.Drawing.Size(640, 56)
        Me.txt_investigation.TabIndex = 23
        '
        'UltraLabel6
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance13
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(57, 234)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel6.TabIndex = 22
        Me.UltraLabel6.Text = "Investigation"
        '
        'txt_ncnum
        '
        Me.txt_ncnum.Location = New System.Drawing.Point(128, 80)
        Me.txt_ncnum.Name = "txt_ncnum"
        Me.txt_ncnum.ReadOnly = True
        Me.txt_ncnum.Size = New System.Drawing.Size(104, 21)
        Me.txt_ncnum.TabIndex = 5
        '
        'UltraLabel5
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel5.Appearance = Appearance14
        Me.UltraLabel5.AutoSize = True
        Me.UltraLabel5.Location = New System.Drawing.Point(19, 83)
        Me.UltraLabel5.Name = "UltraLabel5"
        Me.UltraLabel5.Size = New System.Drawing.Size(106, 14)
        Me.UltraLabel5.TabIndex = 4
        Me.UltraLabel5.Text = "NC/Observation No."
        '
        'UltraLabel2
        '
        Appearance15.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance15
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Location = New System.Drawing.Point(257, 83)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(28, 14)
        Me.UltraLabel2.TabIndex = 6
        Me.UltraLabel2.Text = "Date"
        '
        'dt_ncdate
        '
        Me.dt_ncdate.FormatString = "dddd dd MMM yyyy"
        Me.dt_ncdate.Location = New System.Drawing.Point(288, 80)
        Me.dt_ncdate.Name = "dt_ncdate"
        Me.dt_ncdate.NullText = "Not Defined"
        Me.dt_ncdate.ReadOnly = True
        Me.dt_ncdate.Size = New System.Drawing.Size(181, 21)
        Me.dt_ncdate.TabIndex = 7
        '
        'txt_NC
        '
        Me.txt_NC.AcceptsReturn = True
        Appearance16.FontData.BoldAsString = "True"
        Me.txt_NC.Appearance = Appearance16
        Me.txt_NC.Location = New System.Drawing.Point(128, 144)
        Me.txt_NC.Multiline = True
        Me.txt_NC.Name = "txt_NC"
        Me.txt_NC.ReadOnly = True
        Me.txt_NC.Size = New System.Drawing.Size(640, 32)
        Me.txt_NC.TabIndex = 15
        '
        'UltraLabel3
        '
        Appearance17.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance17
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(46, 147)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel3.TabIndex = 14
        Me.UltraLabel3.Text = "Non Confirmity"
        '
        'txt_prevenaction
        '
        Me.txt_prevenaction.AcceptsReturn = True
        Appearance18.FontData.BoldAsString = "True"
        Me.txt_prevenaction.Appearance = Appearance18
        Me.txt_prevenaction.Location = New System.Drawing.Point(128, 368)
        Me.txt_prevenaction.Multiline = True
        Me.txt_prevenaction.Name = "txt_prevenaction"
        Me.txt_prevenaction.ReadOnly = True
        Me.txt_prevenaction.Size = New System.Drawing.Size(640, 72)
        Me.txt_prevenaction.TabIndex = 27
        '
        'UltraLabel10
        '
        Appearance19.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance19
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(33, 371)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel10.TabIndex = 26
        Me.UltraLabel10.Text = "Preventive Action"
        '
        'cmb_raisedby
        '
        Me.cmb_raisedby.Location = New System.Drawing.Point(128, 200)
        Me.cmb_raisedby.Name = "cmb_raisedby"
        Me.cmb_raisedby.ReadOnly = True
        Me.cmb_raisedby.Size = New System.Drawing.Size(216, 21)
        Me.cmb_raisedby.TabIndex = 17
        Me.cmb_raisedby.Text = "UltraComboEditor1"
        '
        'UltraLabel11
        '
        Me.UltraLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance20.TextHAlignAsString = "Right"
        Me.UltraLabel11.Appearance = Appearance20
        Me.UltraLabel11.AutoSize = True
        Me.UltraLabel11.Location = New System.Drawing.Point(127, 184)
        Me.UltraLabel11.Name = "UltraLabel11"
        Me.UltraLabel11.Size = New System.Drawing.Size(56, 14)
        Me.UltraLabel11.TabIndex = 16
        Me.UltraLabel11.Text = "Raised By"
        '
        'cmb_WorkBy
        '
        Me.cmb_WorkBy.Location = New System.Drawing.Point(360, 200)
        Me.cmb_WorkBy.Name = "cmb_WorkBy"
        Me.cmb_WorkBy.ReadOnly = True
        Me.cmb_WorkBy.Size = New System.Drawing.Size(200, 21)
        Me.cmb_WorkBy.TabIndex = 19
        Me.cmb_WorkBy.Text = "UltraComboEditor1"
        '
        'UltraLabel12
        '
        Me.UltraLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance21.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance21
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(360, 184)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel12.TabIndex = 18
        Me.UltraLabel12.Text = "Work Done By"
        '
        'cmb_rectifyBy
        '
        Me.cmb_rectifyBy.Location = New System.Drawing.Point(568, 200)
        Me.cmb_rectifyBy.Name = "cmb_rectifyBy"
        Me.cmb_rectifyBy.ReadOnly = True
        Me.cmb_rectifyBy.Size = New System.Drawing.Size(200, 21)
        Me.cmb_rectifyBy.TabIndex = 21
        Me.cmb_rectifyBy.Text = "UltraComboEditor1"
        '
        'UltraLabel13
        '
        Me.UltraLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance22.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance22
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(566, 184)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel13.TabIndex = 20
        Me.UltraLabel13.Text = "Rectified By"
        '
        'textParty
        '
        Appearance23.FontData.BoldAsString = "True"
        Appearance23.FontData.SizeInPoints = 12.0!
        Me.textParty.Appearance = Appearance23
        Me.textParty.Location = New System.Drawing.Point(128, 16)
        Me.textParty.Name = "textParty"
        Me.textParty.ReadOnly = True
        Me.textParty.Size = New System.Drawing.Size(640, 27)
        Me.textParty.TabIndex = 1
        '
        'UltraLabel14
        '
        Appearance24.FontData.SizeInPoints = 12.0!
        Appearance24.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance24
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(81, 19)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(44, 20)
        Me.UltraLabel14.TabIndex = 0
        Me.UltraLabel14.Text = "Party"
        '
        'textRating
        '
        Appearance25.FontData.BoldAsString = "True"
        Appearance25.FontData.SizeInPoints = 12.0!
        Me.textRating.Appearance = Appearance25
        Me.textRating.Location = New System.Drawing.Point(128, 48)
        Me.textRating.Name = "textRating"
        Me.textRating.ReadOnly = True
        Me.textRating.Size = New System.Drawing.Size(640, 27)
        Me.textRating.TabIndex = 3
        '
        'UltraLabel15
        '
        Appearance26.FontData.SizeInPoints = 12.0!
        Appearance26.TextHAlignAsString = "Right"
        Me.UltraLabel15.Appearance = Appearance26
        Me.UltraLabel15.AutoSize = True
        Me.UltraLabel15.Location = New System.Drawing.Point(72, 51)
        Me.UltraLabel15.Name = "UltraLabel15"
        Me.UltraLabel15.Size = New System.Drawing.Size(53, 20)
        Me.UltraLabel15.TabIndex = 2
        Me.UltraLabel15.Text = "Rating"
        '
        'frmNCView
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "NC"
        Me.ClientSize = New System.Drawing.Size(792, 542)
        Me.Controls.Add(Me.textRating)
        Me.Controls.Add(Me.UltraLabel15)
        Me.Controls.Add(Me.textParty)
        Me.Controls.Add(Me.UltraLabel14)
        Me.Controls.Add(Me.cmb_rectifyBy)
        Me.Controls.Add(Me.UltraLabel13)
        Me.Controls.Add(Me.cmb_WorkBy)
        Me.Controls.Add(Me.UltraLabel12)
        Me.Controls.Add(Me.cmb_raisedby)
        Me.Controls.Add(Me.UltraLabel11)
        Me.Controls.Add(Me.txt_prevenaction)
        Me.Controls.Add(Me.UltraLabel10)
        Me.Controls.Add(Me.txt_NC)
        Me.Controls.Add(Me.UltraLabel3)
        Me.Controls.Add(Me.cmb_ProdSerialID)
        Me.Controls.Add(Me.UltraLabel4)
        Me.Controls.Add(Me.cmb_matdepid)
        Me.Controls.Add(Me.UltraLabel1)
        Me.Controls.Add(Me.dt_clearDate)
        Me.Controls.Add(Me.txt_remark)
        Me.Controls.Add(Me.UltraLabel9)
        Me.Controls.Add(Me.UltraLabel8)
        Me.Controls.Add(Me.txt_correcaction)
        Me.Controls.Add(Me.UltraLabel7)
        Me.Controls.Add(Me.txt_investigation)
        Me.Controls.Add(Me.UltraLabel6)
        Me.Controls.Add(Me.txt_ncnum)
        Me.Controls.Add(Me.UltraLabel5)
        Me.Controls.Add(Me.UltraLabel2)
        Me.Controls.Add(Me.dt_ncdate)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmNCView"
        Me.Text = "NC"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.cmb_ProdSerialID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_clearDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_correcaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_investigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ncnum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_ncdate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prevenaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_raisedby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_WorkBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rectifyBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textParty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
End Class

