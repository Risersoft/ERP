<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmMacSpare
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents CtlItemVMS1 As ctlItemVMS2
    Friend WithEvents combo_ItemUnit As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents combo_ItemName As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents combo_ItemId As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_purpose As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_purpose = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.combo_ItemUnit = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.combo_ItemName = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.combo_ItemId = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.CtlItemVMS1 = New risersoft.app.config.ctlItemVMS2()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combo_ItemId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UltraLabel6)
        Me.Panel2.Controls.Add(Me.txt_purpose)
        Me.Panel2.Controls.Add(Me.combo_ItemUnit)
        Me.Panel2.Controls.Add(Me.combo_ItemName)
        Me.Panel2.Controls.Add(Me.combo_ItemId)
        Me.Panel2.Controls.Add(Me.UltraLabel3)
        Me.Panel2.Controls.Add(Me.UltraLabel2)
        Me.Panel2.Controls.Add(Me.UltraLabel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(592, 96)
        Me.Panel2.TabIndex = 0
        '
        'UltraLabel6
        '
        Appearance6.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance6
        Me.UltraLabel6.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraLabel6.Location = New System.Drawing.Point(56, 64)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(64, 16)
        Me.UltraLabel6.TabIndex = 6
        Me.UltraLabel6.Text = "Purpose"
        '
        'txt_purpose
        '
        Appearance7.FontData.BoldAsString = "False"
        Appearance7.FontData.ItalicAsString = "False"
        Appearance7.FontData.Name = "Arial"
        Appearance7.FontData.SizeInPoints = 8.25!
        Appearance7.FontData.StrikeoutAsString = "False"
        Appearance7.FontData.UnderlineAsString = "False"
        Me.txt_purpose.Appearance = Appearance7
        Me.txt_purpose.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_purpose.Location = New System.Drawing.Point(120, 64)
        Me.txt_purpose.Multiline = True
        Me.txt_purpose.Name = "txt_purpose"
        Me.txt_purpose.Size = New System.Drawing.Size(440, 24)
        Me.txt_purpose.TabIndex = 7
        '
        'combo_ItemUnit
        '
        Me.combo_ItemUnit.DisplayMember = "unitName"
        Me.combo_ItemUnit.Location = New System.Drawing.Point(456, 8)
        Me.combo_ItemUnit.Name = "combo_ItemUnit"
        Me.combo_ItemUnit.ReadOnly = True
        Me.combo_ItemUnit.Size = New System.Drawing.Size(120, 22)
        Me.combo_ItemUnit.TabIndex = 3
        Me.combo_ItemUnit.TabStop = False
        Me.combo_ItemUnit.ValueMember = "itemId"
        '
        'combo_ItemName
        '
        Me.combo_ItemName.DisplayMember = "itemName"
        Me.combo_ItemName.Location = New System.Drawing.Point(120, 32)
        Me.combo_ItemName.Name = "combo_ItemName"
        Me.combo_ItemName.Size = New System.Drawing.Size(456, 22)
        Me.combo_ItemName.TabIndex = 5
        Me.combo_ItemName.ValueMember = "itemId"
        '
        'combo_ItemId
        '
        Me.combo_ItemId.DisplayMember = "itemCode"
        Me.combo_ItemId.Location = New System.Drawing.Point(120, 8)
        Me.combo_ItemId.Name = "combo_ItemId"
        Me.combo_ItemId.Size = New System.Drawing.Size(224, 22)
        Me.combo_ItemId.TabIndex = 1
        Me.combo_ItemId.ValueMember = "itemId"
        '
        'UltraLabel3
        '
        Appearance1.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance1
        Me.UltraLabel3.Location = New System.Drawing.Point(416, 8)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(32, 16)
        Me.UltraLabel3.TabIndex = 2
        Me.UltraLabel3.Text = "Unit"
        '
        'UltraLabel2
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance2
        Me.UltraLabel2.Location = New System.Drawing.Point(56, 32)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel2.TabIndex = 4
        Me.UltraLabel2.Text = "Item Name"
        '
        'UltraLabel1
        '
        Appearance3.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance3
        Me.UltraLabel1.Location = New System.Drawing.Point(56, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 23)
        Me.UltraLabel1.TabIndex = 0
        Me.UltraLabel1.Text = "Item Code"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 430)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(592, 40)
        Me.Panel4.TabIndex = 2
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance4.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance4
        Me.btnCancel.Location = New System.Drawing.Point(400, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 0
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance5.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance5
        Me.btnOK.Location = New System.Drawing.Point(496, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "&OK"
        '
        'CtlItemVMS1
        '
        Me.CtlItemVMS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlItemVMS1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.CtlItemVMS1.ItemVMSID = 0
        Me.CtlItemVMS1.Location = New System.Drawing.Point(0, 96)
        Me.CtlItemVMS1.Mode = risersoft.[shared].EnumVMSMode.acItem
        Me.CtlItemVMS1.Name = "CtlItemVMS1"
        Me.CtlItemVMS1.Size = New System.Drawing.Size(592, 334)
        Me.CtlItemVMS1.TabIndex = 0
        '
        'frmMacSpare
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Machine Spare"
        Me.ClientSize = New System.Drawing.Size(592, 470)
        Me.Controls.Add(Me.CtlItemVMS1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmMacSpare"
        Me.Text = "Machine Spare"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_purpose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combo_ItemId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class

