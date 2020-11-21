Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmLabParam
	Inherits frmMax
    Dim dtInstru As DataTable

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        myView.SetGrid(UltraGrid1)
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
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_Remarks As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmb_matdepid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_typetestid As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_UOM As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmb_PhysicalPropID As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDelInstru As Infragistics.Win.Misc.UltraButton
    Friend WithEvents txt_InstruSetNum As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAddInstru As Infragistics.Win.Misc.UltraButton

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.btnDelInstru = New Infragistics.Win.Misc.UltraButton
        Me.btnAddInstru = New Infragistics.Win.Misc.UltraButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmb_PhysicalPropID = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.txt_UOM = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmb_typetestid = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmb_matdepid = New Infragistics.Win.UltraWinGrid.UltraCombo
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_Remarks = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label7 = New System.Windows.Forms.Label
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.btnSave = New Infragistics.Win.Misc.UltraButton
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton
        Me.btnOK = New Infragistics.Win.Misc.UltraButton
        Me.txt_InstruSetNum = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.cmb_PhysicalPropID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_UOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_typetestid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_InstruSetNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(704, 534)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.UltraGrid1)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 213)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 321)
        Me.Panel3.TabIndex = 9
        '
        'UltraGrid1
        '
        Me.UltraGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGrid1.Location = New System.Drawing.Point(0, 0)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(704, 281)
        Me.UltraGrid1.TabIndex = 8
        Me.UltraGrid1.Text = "Lots"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnDelInstru)
        Me.Panel7.Controls.Add(Me.btnAddInstru)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 281)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(704, 40)
        Me.Panel7.TabIndex = 9
        '
        'btnDelInstru
        '
        Me.btnDelInstru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelInstru.Location = New System.Drawing.Point(520, 6)
        Me.btnDelInstru.Name = "btnDelInstru"
        Me.btnDelInstru.Size = New System.Drawing.Size(76, 24)
        Me.btnDelInstru.TabIndex = 6
        Me.btnDelInstru.Text = "Delete"
        '
        'btnAddInstru
        '
        Me.btnAddInstru.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddInstru.Location = New System.Drawing.Point(608, 6)
        Me.btnAddInstru.Name = "btnAddInstru"
        Me.btnAddInstru.Size = New System.Drawing.Size(76, 24)
        Me.btnAddInstru.TabIndex = 5
        Me.btnAddInstru.Text = "Add New"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_InstruSetNum)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmb_PhysicalPropID)
        Me.Panel1.Controls.Add(Me.txt_UOM)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_typetestid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_matdepid)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txt_Remarks)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(704, 213)
        Me.Panel1.TabIndex = 0
        '
        'cmb_PhysicalPropID
        '
        Me.cmb_PhysicalPropID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmb_PhysicalPropID.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.cmb_PhysicalPropID.Location = New System.Drawing.Point(144, 82)
        Me.cmb_PhysicalPropID.Name = "cmb_PhysicalPropID"
        Me.cmb_PhysicalPropID.Size = New System.Drawing.Size(238, 22)
        Me.cmb_PhysicalPropID.TabIndex = 141
        Me.cmb_PhysicalPropID.Text = "Propname"
        '
        'txt_UOM
        '
        Me.txt_UOM.Location = New System.Drawing.Point(144, 110)
        Me.txt_UOM.Name = "txt_UOM"
        Me.txt_UOM.Size = New System.Drawing.Size(136, 21)
        Me.txt_UOM.TabIndex = 139
        Me.txt_UOM.Text = "UltraTextEditor17"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(48, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "Unit of Measure"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_typetestid
        '
        Me.cmb_typetestid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmb_typetestid.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.cmb_typetestid.Location = New System.Drawing.Point(144, 48)
        Me.cmb_typetestid.Name = "cmb_typetestid"
        Me.cmb_typetestid.Size = New System.Drawing.Size(472, 22)
        Me.cmb_typetestid.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Test Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(24, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Parameter"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_matdepid
        '
        Me.cmb_matdepid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmb_matdepid.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.[Default]
        Me.cmb_matdepid.Location = New System.Drawing.Point(144, 16)
        Me.cmb_matdepid.Name = "cmb_matdepid"
        Me.cmb_matdepid.ReadOnly = True
        Me.cmb_matdepid.Size = New System.Drawing.Size(256, 22)
        Me.cmb_matdepid.TabIndex = 107
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(16, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 24)
        Me.Label21.TabIndex = 106
        Me.Label21.Text = "Lab Name"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(144, 142)
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(488, 32)
        Me.txt_Remarks.TabIndex = 74
        Me.txt_Remarks.Text = "UltraTextEditor3"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(82, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Remarks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 534)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(704, 48)
        Me.Panel4.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(416, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(512, 8)
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
        Me.btnOK.Location = New System.Drawing.Point(608, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        '
        'txt_InstruSetNum
        '
        Me.txt_InstruSetNum.Location = New System.Drawing.Point(144, 180)
        Me.txt_InstruSetNum.Name = "txt_InstruSetNum"
        Me.txt_InstruSetNum.Size = New System.Drawing.Size(136, 21)
        Me.txt_InstruSetNum.TabIndex = 142
        Me.txt_InstruSetNum.Text = "UltraTextEditor17"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 16)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Instrument Set No."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLabParam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 582)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmLabParam"
        Me.Text = "Measurement Parameter"
        CType(Me.dsCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cmb_PhysicalPropID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_UOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_typetestid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_matdepid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_InstruSetNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class

