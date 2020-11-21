<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmNCItem
	Inherits frmMax
#Region " Windows Form Designer generated code "

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
    Friend WithEvents dt_clearDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel8 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_correcaction As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel7 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_investigation As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_NC As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_prevenaction As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel10 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_WorkBy As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel12 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_rectifyBy As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents UltraLabel13 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents dt_RectifyDate As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel14 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_StatusNum As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents ComboCatID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents cmb_ProdNCCatID As Infragistics.Win.UltraWinGrid.UltraCombo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.UltraLabel9 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_remark = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_NC = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_ProdNCCatID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.txt_investigation = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.ComboCatID = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel12 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_WorkBy = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
        Me.txt_correcaction = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel7 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel8 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_clearDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.cmb_StatusNum = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel10 = New Infragistics.Win.Misc.UltraLabel()
        Me.dt_RectifyDate = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.txt_prevenaction = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel14 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel13 = New Infragistics.Win.Misc.UltraLabel()
        Me.cmb_rectifyBy = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.txt_remark, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_NC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_ProdNCCatID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_investigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboCatID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_WorkBy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.txt_correcaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_clearDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_RectifyDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prevenaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_rectifyBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel9)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_remark)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_NC)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel4)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel6)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_ProdNCCatID)
        Me.UltraTabPageControl1.Controls.Add(Me.txt_investigation)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel2)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel3)
        Me.UltraTabPageControl1.Controls.Add(Me.ComboCatID)
        Me.UltraTabPageControl1.Controls.Add(Me.UltraLabel12)
        Me.UltraTabPageControl1.Controls.Add(Me.cmb_WorkBy)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(842, 171)
        '
        'UltraLabel9
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel9.Appearance = Appearance1
        Me.UltraLabel9.AutoSize = True
        Me.UltraLabel9.Location = New System.Drawing.Point(53, 129)
        Me.UltraLabel9.Name = "UltraLabel9"
        Me.UltraLabel9.Size = New System.Drawing.Size(44, 14)
        Me.UltraLabel9.TabIndex = 10
        Me.UltraLabel9.Text = "Remark"
        '
        'txt_remark
        '
        Me.txt_remark.AcceptsReturn = True
        Me.txt_remark.Location = New System.Drawing.Point(100, 126)
        Me.txt_remark.Multiline = True
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(732, 32)
        Me.txt_remark.TabIndex = 11
        '
        'txt_NC
        '
        Me.txt_NC.AcceptsReturn = True
        Me.txt_NC.Location = New System.Drawing.Point(100, 19)
        Me.txt_NC.Multiline = True
        Me.txt_NC.Name = "txt_NC"
        Me.txt_NC.Size = New System.Drawing.Size(432, 32)
        Me.txt_NC.TabIndex = 1
        '
        'UltraLabel4
        '
        Appearance14.TextHAlignAsString = "Right"
        Me.UltraLabel4.Appearance = Appearance14
        Me.UltraLabel4.AutoSize = True
        Me.UltraLabel4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel4.Location = New System.Drawing.Point(280, 62)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(73, 14)
        Me.UltraLabel4.TabIndex = 4
        Me.UltraLabel4.Text = "Sub Category"
        '
        'UltraLabel6
        '
        Appearance4.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance4
        Me.UltraLabel6.AutoSize = True
        Me.UltraLabel6.Location = New System.Drawing.Point(29, 90)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(68, 14)
        Me.UltraLabel6.TabIndex = 6
        Me.UltraLabel6.Text = "Investigation"
        '
        'cmb_ProdNCCatID
        '
        Me.cmb_ProdNCCatID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_ProdNCCatID.Location = New System.Drawing.Point(356, 58)
        Me.cmb_ProdNCCatID.Name = "cmb_ProdNCCatID"
        Me.cmb_ProdNCCatID.Size = New System.Drawing.Size(176, 22)
        Me.cmb_ProdNCCatID.TabIndex = 5
        '
        'txt_investigation
        '
        Me.txt_investigation.AcceptsReturn = True
        Me.txt_investigation.Location = New System.Drawing.Point(100, 87)
        Me.txt_investigation.Multiline = True
        Me.txt_investigation.Name = "txt_investigation"
        Me.txt_investigation.Size = New System.Drawing.Size(432, 32)
        Me.txt_investigation.TabIndex = 7
        '
        'UltraLabel2
        '
        Appearance13.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance13
        Me.UltraLabel2.AutoSize = True
        Me.UltraLabel2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel2.Location = New System.Drawing.Point(47, 61)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(50, 14)
        Me.UltraLabel2.TabIndex = 2
        Me.UltraLabel2.Text = "Category"
        '
        'UltraLabel3
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance5
        Me.UltraLabel3.AutoSize = True
        Me.UltraLabel3.Location = New System.Drawing.Point(18, 22)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(79, 14)
        Me.UltraLabel3.TabIndex = 0
        Me.UltraLabel3.Text = "Non Confirmity"
        '
        'ComboCatID
        '
        Me.ComboCatID.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ComboCatID.Location = New System.Drawing.Point(100, 58)
        Me.ComboCatID.Name = "ComboCatID"
        Me.ComboCatID.Size = New System.Drawing.Size(168, 22)
        Me.ComboCatID.TabIndex = 3
        '
        'UltraLabel12
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel12.Appearance = Appearance8
        Me.UltraLabel12.AutoSize = True
        Me.UltraLabel12.Location = New System.Drawing.Point(560, 90)
        Me.UltraLabel12.Name = "UltraLabel12"
        Me.UltraLabel12.Size = New System.Drawing.Size(77, 14)
        Me.UltraLabel12.TabIndex = 8
        Me.UltraLabel12.Text = "Work Done By"
        '
        'cmb_WorkBy
        '
        Me.cmb_WorkBy.Location = New System.Drawing.Point(640, 87)
        Me.cmb_WorkBy.Name = "cmb_WorkBy"
        Me.cmb_WorkBy.Size = New System.Drawing.Size(192, 21)
        Me.cmb_WorkBy.TabIndex = 9
        Me.cmb_WorkBy.Text = "UltraComboEditor1"
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.txt_correcaction)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel7)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel8)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel1)
        Me.UltraTabPageControl2.Controls.Add(Me.dt_clearDate)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_StatusNum)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel10)
        Me.UltraTabPageControl2.Controls.Add(Me.dt_RectifyDate)
        Me.UltraTabPageControl2.Controls.Add(Me.txt_prevenaction)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel14)
        Me.UltraTabPageControl2.Controls.Add(Me.UltraLabel13)
        Me.UltraTabPageControl2.Controls.Add(Me.cmb_rectifyBy)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(2, 19)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(842, 171)
        '
        'txt_correcaction
        '
        Me.txt_correcaction.AcceptsReturn = True
        Me.txt_correcaction.Location = New System.Drawing.Point(100, 19)
        Me.txt_correcaction.Multiline = True
        Me.txt_correcaction.Name = "txt_correcaction"
        Me.txt_correcaction.Size = New System.Drawing.Size(456, 32)
        Me.txt_correcaction.TabIndex = 1
        '
        'UltraLabel7
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel7.Appearance = Appearance3
        Me.UltraLabel7.AutoSize = True
        Me.UltraLabel7.Location = New System.Drawing.Point(7, 22)
        Me.UltraLabel7.Name = "UltraLabel7"
        Me.UltraLabel7.Size = New System.Drawing.Size(90, 14)
        Me.UltraLabel7.TabIndex = 0
        Me.UltraLabel7.Text = "Corrective Action"
        '
        'UltraLabel8
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel8.Appearance = Appearance2
        Me.UltraLabel8.AutoSize = True
        Me.UltraLabel8.Location = New System.Drawing.Point(569, 89)
        Me.UltraLabel8.Name = "UltraLabel8"
        Me.UltraLabel8.Size = New System.Drawing.Size(71, 14)
        Me.UltraLabel8.TabIndex = 10
        Me.UltraLabel8.Text = "Cleared Date"
        '
        'UltraLabel1
        '
        Appearance12.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance12
        Me.UltraLabel1.AutoSize = True
        Me.UltraLabel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel1.Location = New System.Drawing.Point(604, 61)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(36, 14)
        Me.UltraLabel1.TabIndex = 6
        Me.UltraLabel1.Text = "Status"
        '
        'dt_clearDate
        '
        Me.dt_clearDate.FormatString = "dddd dd MMM yyyy  "
        Me.dt_clearDate.Location = New System.Drawing.Point(643, 86)
        Me.dt_clearDate.Name = "dt_clearDate"
        Me.dt_clearDate.NullText = "Not Defined"
        Me.dt_clearDate.Size = New System.Drawing.Size(192, 21)
        Me.dt_clearDate.TabIndex = 11
        '
        'cmb_StatusNum
        '
        Me.cmb_StatusNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cmb_StatusNum.Location = New System.Drawing.Point(643, 57)
        Me.cmb_StatusNum.Name = "cmb_StatusNum"
        Me.cmb_StatusNum.Size = New System.Drawing.Size(192, 22)
        Me.cmb_StatusNum.TabIndex = 7
        '
        'UltraLabel10
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel10.Appearance = Appearance6
        Me.UltraLabel10.AutoSize = True
        Me.UltraLabel10.Location = New System.Drawing.Point(5, 91)
        Me.UltraLabel10.Name = "UltraLabel10"
        Me.UltraLabel10.Size = New System.Drawing.Size(92, 14)
        Me.UltraLabel10.TabIndex = 8
        Me.UltraLabel10.Text = "Preventive Action"
        '
        'dt_RectifyDate
        '
        Me.dt_RectifyDate.FormatString = "dddd dd MMM yyyy  "
        Me.dt_RectifyDate.Location = New System.Drawing.Point(409, 58)
        Me.dt_RectifyDate.Name = "dt_RectifyDate"
        Me.dt_RectifyDate.NullText = "Not Defined"
        Me.dt_RectifyDate.Size = New System.Drawing.Size(147, 21)
        Me.dt_RectifyDate.TabIndex = 5
        '
        'txt_prevenaction
        '
        Me.txt_prevenaction.AcceptsReturn = True
        Me.txt_prevenaction.Location = New System.Drawing.Point(100, 87)
        Me.txt_prevenaction.Multiline = True
        Me.txt_prevenaction.Name = "txt_prevenaction"
        Me.txt_prevenaction.Size = New System.Drawing.Size(456, 32)
        Me.txt_prevenaction.TabIndex = 9
        '
        'UltraLabel14
        '
        Appearance10.TextHAlignAsString = "Right"
        Me.UltraLabel14.Appearance = Appearance10
        Me.UltraLabel14.AutoSize = True
        Me.UltraLabel14.Location = New System.Drawing.Point(340, 61)
        Me.UltraLabel14.Name = "UltraLabel14"
        Me.UltraLabel14.Size = New System.Drawing.Size(66, 14)
        Me.UltraLabel14.TabIndex = 4
        Me.UltraLabel14.Text = "Rectify Date"
        '
        'UltraLabel13
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLabel13.Appearance = Appearance9
        Me.UltraLabel13.AutoSize = True
        Me.UltraLabel13.Location = New System.Drawing.Point(32, 61)
        Me.UltraLabel13.Name = "UltraLabel13"
        Me.UltraLabel13.Size = New System.Drawing.Size(65, 14)
        Me.UltraLabel13.TabIndex = 2
        Me.UltraLabel13.Text = "Rectified By"
        '
        'cmb_rectifyBy
        '
        Me.cmb_rectifyBy.Location = New System.Drawing.Point(100, 58)
        Me.cmb_rectifyBy.Name = "cmb_rectifyBy"
        Me.cmb_rectifyBy.Size = New System.Drawing.Size(229, 21)
        Me.cmb_rectifyBy.TabIndex = 3
        Me.cmb_rectifyBy.Text = "UltraComboEditor1"
        '
        'UltraTabControl1
        '
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Me.UltraTabControl1.ActiveTabAppearance = Appearance11
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Appearance7.BackColor = System.Drawing.SystemColors.Control
        Appearance7.FontData.BoldAsString = "True"
        Me.UltraTabControl1.SelectedTabAppearance = Appearance7
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.ShowTabListButton = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraTabControl1.Size = New System.Drawing.Size(846, 192)
        Me.UltraTabControl1.SpaceBeforeTabs = New Infragistics.Win.DefaultableInteger(50)
        Me.UltraTabControl1.Style = Infragistics.Win.UltraWinTabControl.UltraTabControlStyle.PropertyPage2003
        Me.UltraTabControl1.TabIndex = 0
        Me.UltraTabControl1.TabPadding = New System.Drawing.Size(10, 0)
        UltraTab1.TabPage = Me.UltraTabPageControl1
        UltraTab1.Text = "General"
        UltraTab2.TabPage = Me.UltraTabPageControl2
        UltraTab2.Text = "Others"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(842, 171)
        '
        'frmNCItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Non Confirmity"
        Me.ClientSize = New System.Drawing.Size(846, 192)
        Me.Controls.Add(Me.UltraTabControl1)
        Me.Name = "frmNCItem"
        Me.Text = "Non Confirmity"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl1.ResumeLayout(False)
        Me.UltraTabPageControl1.PerformLayout()
        CType(Me.txt_remark, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_NC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_ProdNCCatID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_investigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboCatID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_WorkBy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        Me.UltraTabPageControl2.PerformLayout()
        CType(Me.txt_correcaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_clearDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_StatusNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_RectifyDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prevenaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_rectifyBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraLabel9 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_remark As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl

#End Region
End Class

