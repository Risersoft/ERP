Imports ug = Infragistics.Win.UltraWinGrid
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Partial Class frmTrainEmp
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
    Friend WithEvents UltraGridTraining As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UltraLabel1 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel2 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLabel6 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents UltraLable4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSave As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnCancel As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnOK As Infragistics.Win.Misc.UltraButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnEditDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnDelDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents btnAddDoc As Infragistics.Win.Misc.UltraButton
    Friend WithEvents dt_Dated As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
    Friend WithEvents UltraLabel3 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Faculty As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Topic As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Place As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txt_Durations As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents UltraLabel4 As Infragistics.Win.Misc.UltraLabel
    Friend WithEvents txt_Descrip As Infragistics.Win.UltraWinEditors.UltraTextEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
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
        Me.UltraGridTraining = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UltraLabel4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Descrip = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txt_Durations = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel3 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Place = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.dt_Dated = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor()
        Me.UltraLabel1 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Faculty = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.UltraLabel2 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLabel6 = New Infragistics.Win.Misc.UltraLabel()
        Me.UltraLable4 = New Infragistics.Win.Misc.UltraLabel()
        Me.txt_Topic = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSave = New Infragistics.Win.Misc.UltraButton()
        Me.btnCancel = New Infragistics.Win.Misc.UltraButton()
        Me.btnOK = New Infragistics.Win.Misc.UltraButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnEditDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnDelDoc = New Infragistics.Win.Misc.UltraButton()
        Me.btnAddDoc = New Infragistics.Win.Misc.UltraButton()
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGridTraining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Durations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Place, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_Dated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Faculty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Topic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UltraGridTraining
        '
        Me.UltraGridTraining.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UltraGridTraining.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.UltraGridTraining.Location = New System.Drawing.Point(0, 120)
        Me.UltraGridTraining.Name = "UltraGridTraining"
        Me.UltraGridTraining.Size = New System.Drawing.Size(608, 277)
        Me.UltraGridTraining.TabIndex = 1
        Me.UltraGridTraining.Text = "UltraGrid1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UltraLabel4)
        Me.Panel1.Controls.Add(Me.txt_Descrip)
        Me.Panel1.Controls.Add(Me.txt_Durations)
        Me.Panel1.Controls.Add(Me.UltraLabel3)
        Me.Panel1.Controls.Add(Me.txt_Place)
        Me.Panel1.Controls.Add(Me.dt_Dated)
        Me.Panel1.Controls.Add(Me.UltraLabel1)
        Me.Panel1.Controls.Add(Me.txt_Faculty)
        Me.Panel1.Controls.Add(Me.UltraLabel2)
        Me.Panel1.Controls.Add(Me.UltraLabel6)
        Me.Panel1.Controls.Add(Me.UltraLable4)
        Me.Panel1.Controls.Add(Me.txt_Topic)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 120)
        Me.Panel1.TabIndex = 0
        '
        'UltraLabel4
        '
        Appearance14.TextHAlignAsString = "Left"
        Me.UltraLabel4.Appearance = Appearance14
        Me.UltraLabel4.Location = New System.Drawing.Point(336, 32)
        Me.UltraLabel4.Name = "UltraLabel4"
        Me.UltraLabel4.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel4.TabIndex = 6
        Me.UltraLabel4.Text = "Description"
        '
        'txt_Descrip
        '
        Appearance15.FontData.BoldAsString = "False"
        Appearance15.FontData.ItalicAsString = "False"
        Appearance15.FontData.Name = "Arial"
        Appearance15.FontData.SizeInPoints = 8.25!
        Appearance15.FontData.StrikeoutAsString = "False"
        Appearance15.FontData.UnderlineAsString = "False"
        Me.txt_Descrip.Appearance = Appearance15
        Me.txt_Descrip.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Descrip.Location = New System.Drawing.Point(336, 56)
        Me.txt_Descrip.Multiline = True
        Me.txt_Descrip.Name = "txt_Descrip"
        Me.txt_Descrip.Size = New System.Drawing.Size(256, 48)
        Me.txt_Descrip.TabIndex = 9
        '
        'txt_Durations
        '
        Appearance1.FontData.BoldAsString = "False"
        Appearance1.FontData.ItalicAsString = "False"
        Appearance1.FontData.Name = "Arial"
        Appearance1.FontData.SizeInPoints = 8.25!
        Appearance1.FontData.StrikeoutAsString = "False"
        Appearance1.FontData.UnderlineAsString = "False"
        Me.txt_Durations.Appearance = Appearance1
        Me.txt_Durations.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Durations.Location = New System.Drawing.Point(424, 8)
        Me.txt_Durations.Name = "txt_Durations"
        Me.txt_Durations.Size = New System.Drawing.Size(144, 21)
        Me.txt_Durations.TabIndex = 3
        '
        'UltraLabel3
        '
        Appearance2.TextHAlignAsString = "Right"
        Me.UltraLabel3.Appearance = Appearance2
        Me.UltraLabel3.Location = New System.Drawing.Point(48, 80)
        Me.UltraLabel3.Name = "UltraLabel3"
        Me.UltraLabel3.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel3.TabIndex = 10
        Me.UltraLabel3.Text = "Place"
        '
        'txt_Place
        '
        Appearance3.FontData.BoldAsString = "False"
        Appearance3.FontData.ItalicAsString = "False"
        Appearance3.FontData.Name = "Arial"
        Appearance3.FontData.SizeInPoints = 8.25!
        Appearance3.FontData.StrikeoutAsString = "False"
        Appearance3.FontData.UnderlineAsString = "False"
        Me.txt_Place.Appearance = Appearance3
        Me.txt_Place.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Place.Location = New System.Drawing.Point(96, 80)
        Me.txt_Place.Name = "txt_Place"
        Me.txt_Place.Size = New System.Drawing.Size(232, 21)
        Me.txt_Place.TabIndex = 11
        '
        'dt_Dated
        '
        Appearance4.FontData.BoldAsString = "False"
        Appearance4.FontData.ItalicAsString = "False"
        Appearance4.FontData.Name = "Arial"
        Appearance4.FontData.SizeInPoints = 8.25!
        Appearance4.FontData.StrikeoutAsString = "False"
        Appearance4.FontData.UnderlineAsString = "False"
        Me.dt_Dated.Appearance = Appearance4
        Me.dt_Dated.FormatString = "dddd dd MMM yyyy"
        Me.dt_Dated.Location = New System.Drawing.Point(96, 8)
        Me.dt_Dated.Name = "dt_Dated"
        Me.dt_Dated.NullText = "Not Defined"
        Me.dt_Dated.Size = New System.Drawing.Size(232, 21)
        Me.dt_Dated.TabIndex = 1
        '
        'UltraLabel1
        '
        Appearance5.TextHAlignAsString = "Right"
        Me.UltraLabel1.Appearance = Appearance5
        Me.UltraLabel1.Location = New System.Drawing.Point(360, 8)
        Me.UltraLabel1.Name = "UltraLabel1"
        Me.UltraLabel1.Size = New System.Drawing.Size(64, 24)
        Me.UltraLabel1.TabIndex = 2
        Me.UltraLabel1.Text = "Durations"
        '
        'txt_Faculty
        '
        Appearance6.FontData.BoldAsString = "False"
        Appearance6.FontData.ItalicAsString = "False"
        Appearance6.FontData.Name = "Arial"
        Appearance6.FontData.SizeInPoints = 8.25!
        Appearance6.FontData.StrikeoutAsString = "False"
        Appearance6.FontData.UnderlineAsString = "False"
        Me.txt_Faculty.Appearance = Appearance6
        Me.txt_Faculty.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Faculty.Location = New System.Drawing.Point(96, 32)
        Me.txt_Faculty.Name = "txt_Faculty"
        Me.txt_Faculty.Size = New System.Drawing.Size(232, 21)
        Me.txt_Faculty.TabIndex = 5
        '
        'UltraLabel2
        '
        Appearance7.TextHAlignAsString = "Right"
        Me.UltraLabel2.Appearance = Appearance7
        Me.UltraLabel2.Location = New System.Drawing.Point(48, 8)
        Me.UltraLabel2.Name = "UltraLabel2"
        Me.UltraLabel2.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel2.TabIndex = 0
        Me.UltraLabel2.Text = "Date"
        '
        'UltraLabel6
        '
        Appearance8.TextHAlignAsString = "Right"
        Me.UltraLabel6.Appearance = Appearance8
        Me.UltraLabel6.Location = New System.Drawing.Point(48, 56)
        Me.UltraLabel6.Name = "UltraLabel6"
        Me.UltraLabel6.Size = New System.Drawing.Size(40, 24)
        Me.UltraLabel6.TabIndex = 7
        Me.UltraLabel6.Text = "Topic"
        '
        'UltraLable4
        '
        Appearance9.TextHAlignAsString = "Right"
        Me.UltraLable4.Appearance = Appearance9
        Me.UltraLable4.Location = New System.Drawing.Point(40, 32)
        Me.UltraLable4.Name = "UltraLable4"
        Me.UltraLable4.Size = New System.Drawing.Size(48, 24)
        Me.UltraLable4.TabIndex = 4
        Me.UltraLable4.Text = "Faculty"
        '
        'txt_Topic
        '
        Appearance10.FontData.BoldAsString = "False"
        Appearance10.FontData.ItalicAsString = "False"
        Appearance10.FontData.Name = "Arial"
        Appearance10.FontData.SizeInPoints = 8.25!
        Appearance10.FontData.StrikeoutAsString = "False"
        Appearance10.FontData.UnderlineAsString = "False"
        Me.txt_Topic.Appearance = Appearance10
        Me.txt_Topic.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.txt_Topic.Location = New System.Drawing.Point(96, 56)
        Me.txt_Topic.Name = "txt_Topic"
        Me.txt_Topic.Size = New System.Drawing.Size(232, 21)
        Me.txt_Topic.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnSave)
        Me.Panel4.Controls.Add(Me.btnCancel)
        Me.Panel4.Controls.Add(Me.btnOK)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 437)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(608, 48)
        Me.Panel4.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance11.FontData.BoldAsString = "True"
        Me.btnSave.Appearance = Appearance11
        Me.btnSave.Location = New System.Drawing.Point(320, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 32)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "&Save"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance12.FontData.BoldAsString = "True"
        Me.btnCancel.Appearance = Appearance12
        Me.btnCancel.Location = New System.Drawing.Point(416, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 32)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance13.FontData.BoldAsString = "True"
        Me.btnOK.Appearance = Appearance13
        Me.btnOK.Location = New System.Drawing.Point(512, 8)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(88, 32)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnEditDoc)
        Me.Panel3.Controls.Add(Me.btnDelDoc)
        Me.Panel3.Controls.Add(Me.btnAddDoc)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Panel3.Location = New System.Drawing.Point(0, 397)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(608, 40)
        Me.Panel3.TabIndex = 2
        '
        'btnEditDoc
        '
        Me.btnEditDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnEditDoc.Location = New System.Drawing.Point(448, 8)
        Me.btnEditDoc.Name = "btnEditDoc"
        Me.btnEditDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnEditDoc.TabIndex = 1
        Me.btnEditDoc.Text = "&Edit"
        '
        'btnDelDoc
        '
        Me.btnDelDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnDelDoc.Location = New System.Drawing.Point(368, 8)
        Me.btnDelDoc.Name = "btnDelDoc"
        Me.btnDelDoc.Size = New System.Drawing.Size(70, 24)
        Me.btnDelDoc.TabIndex = 0
        Me.btnDelDoc.Text = "&Delete"
        '
        'btnAddDoc
        '
        Me.btnAddDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddDoc.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnAddDoc.Location = New System.Drawing.Point(528, 8)
        Me.btnAddDoc.Name = "btnAddDoc"
        Me.btnAddDoc.Size = New System.Drawing.Size(72, 24)
        Me.btnAddDoc.TabIndex = 2
        Me.btnAddDoc.Text = "&Add New"
        '
        'frmTrainEmp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Caption = "Employee Training Record"
        Me.ClientSize = New System.Drawing.Size(608, 485)
        Me.Controls.Add(Me.UltraGridTraining)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmTrainEmp"
        Me.Text = "Employee Training Record"
        CType(Me.eBag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGridTraining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_Descrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Durations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Place, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_Dated, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Faculty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Topic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class

