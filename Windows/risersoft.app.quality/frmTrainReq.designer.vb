<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmTrainReq
	Inherits frmMax

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Me.InitForm()
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_EmpCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_DepId As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_Designation As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_TrainReq As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblNum As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_EmpCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_DepId = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_Designation = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_TrainReq = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblNum = New System.Windows.Forms.Label()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_EmpCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_DepId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Designation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TrainReq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 48)
        Me.Panel1.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(0, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(448, 48)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Mr Rajendra Prasad"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 294)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(448, 48)
        Me.Panel4.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance1
        Me.btnSave.Location = New System.Drawing.Point(160, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance2.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance2
        Me.btnCancel.Location = New System.Drawing.Point(256, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance3.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance3
        Me.btnOK.Location = New System.Drawing.Point(352, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(91, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 14)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Code"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_EmpCode
        '
        Appearance4.FontData.BoldAsString = "False"
        Me.txt_EmpCode.Appearance = Appearance4
        Me.txt_EmpCode.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_EmpCode.Location = New System.Drawing.Point(128, 64)
        Me.txt_EmpCode.Name = "txt_EmpCode"
        Me.txt_EmpCode.ReadOnly = True
        Me.txt_EmpCode.Size = New System.Drawing.Size(96, 17)
        Me.txt_EmpCode.TabIndex = 1
        Me.txt_EmpCode.Text = "UltraTextEditor2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 14)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Department"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmb_DepId
        '
        Appearance5.FontData.BoldAsString = "False"
        Me.cmb_DepId.Appearance = Appearance5
        Me.cmb_DepId.Location = New System.Drawing.Point(128, 128)
        Me.cmb_DepId.Name = "cmb_DepId"
        Me.cmb_DepId.ReadOnly = True
        Me.cmb_DepId.Size = New System.Drawing.Size(296, 22)
        Me.cmb_DepId.TabIndex = 5
        Me.cmb_DepId.Text = "UltraCombo5"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(60, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 14)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "Designation"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_Designation
        '
        Appearance6.FontData.BoldAsString = "False"
        Me.txt_Designation.Appearance = Appearance6
        Me.txt_Designation.BorderStyle = Infragistics.Win.UIElementBorderStyle.None
        Me.txt_Designation.Location = New System.Drawing.Point(128, 96)
        Me.txt_Designation.Name = "txt_Designation"
        Me.txt_Designation.ReadOnly = True
        Me.txt_Designation.Size = New System.Drawing.Size(240, 17)
        Me.txt_Designation.TabIndex = 3
        Me.txt_Designation.Text = "UltraTextEditor2"
        '
        'txt_TrainReq
        '
        Me.txt_TrainReq.AcceptsReturn = True
        Me.txt_TrainReq.Location = New System.Drawing.Point(128, 190)
        Me.txt_TrainReq.Multiline = True
        Me.txt_TrainReq.Name = "txt_TrainReq"
        Me.txt_TrainReq.Size = New System.Drawing.Size(296, 64)
        Me.txt_TrainReq.TabIndex = 7
        Me.txt_TrainReq.Text = "UltraTextEditor2"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lblNum.Location = New System.Drawing.Point(32, 193)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(91, 14)
        Me.lblNum.TabIndex = 6
        Me.lblNum.Text = "Training Required"
        '
        'frmTrainReq
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Employee Details"
        Me.ClientSize = New System.Drawing.Size(448, 342)
        Me.Controls.Add(Me.txt_TrainReq)
        Me.Controls.Add(Me.lblNum)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_EmpCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_DepId)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txt_Designation)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmTrainReq"
        Me.Text = "Employee Details"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_EmpCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_DepId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Designation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TrainReq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
End Class

