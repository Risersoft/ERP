Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmLabStat
	Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.initForm()

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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
    Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
    Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_depcode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnEditRat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddRat As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraButton1 As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid2 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_labname As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnEditInstru As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddInstru As Infragistics.Win.Misc.UltraButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim UltraTab2 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.UltraButton1 = New Infragistics.Win.Misc.UltraButton
        Me.btnEditRat = New Infragistics.Win.Misc.UltraButton
        Me.btnAddRat = New Infragistics.Win.Misc.UltraButton
        Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Me.UltraGrid2 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnEditInstru = New Infragistics.Win.Misc.UltraButton
        Me.btnAddInstru = New Infragistics.Win.Misc.UltraButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl
        Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_depcode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_labname = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnSave = New Infragistics.Win.Misc.UltraButton
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton
        Me.btnOK = New Infragistics.Win.Misc.UltraButton
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabPageControl2.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.UltraTabPageControl1.SuspendLayout()
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UltraTabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_depcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_labname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraTabPageControl2
        '
        Me.UltraTabPageControl2.Controls.Add(Me.UltraGrid1)
        Me.UltraTabPageControl2.Controls.Add(Me.Panel7)
        Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 26)
        Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
        Me.UltraTabPageControl2.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(868, 337)
        Me.UltraGrid1.TabIndex = 14
        Me.UltraGrid1.Text = "Ratings"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.UltraButton1)
        Me.Panel7.Controls.Add(Me.btnEditRat)
        Me.Panel7.Controls.Add(Me.btnAddRat)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 337)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(868, 48)
        Me.Panel7.TabIndex = 15
        '
        'UltraButton1
        '
        Me.UltraButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UltraButton1.Location = New System.Drawing.Point(600, 16)
        Me.UltraButton1.Name = "UltraButton1"
        Me.UltraButton1.Size = New System.Drawing.Size(72, 24)
        Me.UltraButton1.TabIndex = 5
        Me.UltraButton1.Text = "Delete"
        '
        'btnEditRat
        '
        Me.btnEditRat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditRat.Location = New System.Drawing.Point(688, 16)
        Me.btnEditRat.Name = "btnEditRat"
        Me.btnEditRat.Size = New System.Drawing.Size(72, 24)
        Me.btnEditRat.TabIndex = 4
        Me.btnEditRat.Text = "Edit"
        '
        'btnAddRat
        '
        Me.btnAddRat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddRat.Location = New System.Drawing.Point(776, 16)
        Me.btnAddRat.Name = "btnAddRat"
        Me.btnAddRat.Size = New System.Drawing.Size(72, 24)
        Me.btnAddRat.TabIndex = 2
        Me.btnAddRat.Text = "Add New"
        '
        'UltraTabPageControl1
        '
        Me.UltraTabPageControl1.Controls.Add(Me.UltraGrid2)
        Me.UltraTabPageControl1.Controls.Add(Me.Panel3)
        Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
        Me.UltraTabPageControl1.Size = New System.Drawing.Size(868, 385)
        '
        'UltraGrid2
        '
        Me.UltraGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid2.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid2.Name = "UltraGrid2"
        Me.UltraGrid2.Size = New System.Drawing.Size(868, 337)
        Me.UltraGrid2.TabIndex = 16
        Me.UltraGrid2.Text = "Ratings"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditInstru)
        Me.Panel3.Controls.Add(Me.btnAddInstru)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 337)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(868, 48)
        Me.Panel3.TabIndex = 17
        '
        'btnEditInstru
        '
        Me.btnEditInstru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditInstru.Location = New System.Drawing.Point(688, 16)
        Me.btnEditInstru.Name = "btnEditInstru"
        Me.btnEditInstru.Size = New System.Drawing.Size(72, 24)
        Me.btnEditInstru.TabIndex = 4
        Me.btnEditInstru.Text = "Edit"
        '
        'btnAddInstru
        '
        Me.btnAddInstru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddInstru.Location = New System.Drawing.Point(776, 16)
        Me.btnAddInstru.Name = "btnAddInstru"
        Me.btnAddInstru.Size = New System.Drawing.Size(72, 24)
        Me.btnAddInstru.TabIndex = 2
        Me.btnAddInstru.Text = "Add New"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraTabControl1)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 550)
        Me.Panel2.TabIndex = 16
        '
        'UltraTabControl1
        '
        Appearance1.FontData.BoldAsString = "True"
        Appearance1.FontData.SizeInPoints = 11.0!
        Me.UltraTabControl1.Appearance = Appearance1
        Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
        Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
        Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraTabControl1.Location = New System.Drawing.Point(0, 136)
        Me.UltraTabControl1.Name = "UltraTabControl1"
        Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
        Me.UltraTabControl1.Size = New System.Drawing.Size(872, 414)
        Me.UltraTabControl1.TabIndex = 138
        UltraTab1.TabPage = Me.UltraTabPageControl2
        UltraTab1.Text = "Measurement Parameters"
        UltraTab2.Key = "mat"
        UltraTab2.TabPage = Me.UltraTabPageControl1
        UltraTab2.Text = "Instruments"
        Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab1, UltraTab2})
        '
        'UltraTabSharedControlsPage1
        '
        Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
        Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
        Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(868, 385)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_depcode)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txt_labname)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 136)
        Me.Panel1.TabIndex = 137
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(104, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = "Code"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_depcode
        '
        Appearance2.FontData.BoldAsString = "False"
        Appearance2.FontData.SizeInPoints = 11.0!
        Me.txt_depcode.Appearance = Appearance2
        Me.txt_depcode.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_depcode.Location = New System.Drawing.Point(176, 24)
        Me.txt_depcode.Name = "txt_depcode"
        Me.txt_depcode.ReadOnly = True
        Me.txt_depcode.Size = New System.Drawing.Size(96, 22)
        Me.txt_depcode.TabIndex = 105
        Me.txt_depcode.Text = "UltraTextEditor2"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(32, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 24)
        Me.Label21.TabIndex = 104
        Me.Label21.Text = "Lab Name"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_labname
        '
        Appearance3.FontData.BoldAsString = "False"
        Appearance3.FontData.SizeInPoints = 11.0!
        Me.txt_labname.Appearance = Appearance3
        Me.txt_labname.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_labname.Location = New System.Drawing.Point(176, 56)
        Me.txt_labname.Name = "txt_labname"
        Me.txt_labname.ReadOnly = True
        Me.txt_labname.Size = New System.Drawing.Size(240, 22)
        Me.txt_labname.TabIndex = 103
        Me.txt_labname.Text = "UltraTextEditor2"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 550)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(872, 40)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance4
        Me.btnSave.Location = New System.Drawing.Point(584, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 24)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance5
        Me.btnCancel.Location = New System.Drawing.Point(680, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 24)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance6.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance6
        Me.btnOK.Location = New System.Drawing.Point(776, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 24)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'frmLabStat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(872, 590)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmLabStat"
        Me.Text = "Lab Status"
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabPageControl2.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.UltraTabPageControl1.ResumeLayout(False)
        CType(Me.UltraGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UltraTabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_depcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_labname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class

