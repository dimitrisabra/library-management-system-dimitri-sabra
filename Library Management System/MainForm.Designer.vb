<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox5 = New PictureBox()
        btnManageBooks = New Button()
        GroupBox2 = New GroupBox()
        btnGenerateReport = New Button()
        PictureBox6 = New PictureBox()
        GroupBox3 = New GroupBox()
        PictureBox7 = New PictureBox()
        btnManageBorrowers = New Button()
        GroupBox4 = New GroupBox()
        btnManageBorrowReturn = New Button()
        PictureBox14 = New PictureBox()
        labelDateTime = New Label()
        Timer1 = New Timer(components)
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(57, 51)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(236, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(293, 30)
        Label2.TabIndex = 8
        Label2.Text = "Library Management System"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox5)
        GroupBox1.Controls.Add(btnManageBooks)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 89)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(199, 92)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Book Management"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(20, 32)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(51, 40)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 15
        PictureBox5.TabStop = False
        ' 
        ' btnManageBooks
        ' 
        btnManageBooks.Location = New Point(77, 32)
        btnManageBooks.Name = "btnManageBooks"
        btnManageBooks.Size = New Size(84, 40)
        btnManageBooks.TabIndex = 14
        btnManageBooks.Text = "Manage Books"
        btnManageBooks.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnGenerateReport)
        GroupBox2.Controls.Add(PictureBox6)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(12, 215)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(199, 90)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Report"
        ' 
        ' btnGenerateReport
        ' 
        btnGenerateReport.Location = New Point(72, 34)
        btnGenerateReport.Name = "btnGenerateReport"
        btnGenerateReport.Size = New Size(75, 40)
        btnGenerateReport.TabIndex = 13
        btnGenerateReport.Text = "Generate Report"
        btnGenerateReport.UseVisualStyleBackColor = True
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(15, 34)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(51, 40)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(PictureBox7)
        GroupBox3.Controls.Add(btnManageBorrowers)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(236, 89)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(199, 92)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Borrower Management"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImageLayout = ImageLayout.None
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(21, 32)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(51, 40)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        ' 
        ' btnManageBorrowers
        ' 
        btnManageBorrowers.Location = New Point(78, 32)
        btnManageBorrowers.Name = "btnManageBorrowers"
        btnManageBorrowers.Size = New Size(84, 40)
        btnManageBorrowers.TabIndex = 14
        btnManageBorrowers.Text = "Manage Borrowers"
        btnManageBorrowers.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnManageBorrowReturn)
        GroupBox4.Controls.Add(PictureBox14)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(469, 89)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(199, 92)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        GroupBox4.Text = "Transaction"
        ' 
        ' btnManageBorrowReturn
        ' 
        btnManageBorrowReturn.Location = New Point(81, 32)
        btnManageBorrowReturn.Name = "btnManageBorrowReturn"
        btnManageBorrowReturn.Size = New Size(93, 40)
        btnManageBorrowReturn.TabIndex = 0
        btnManageBorrowReturn.Text = "Manage Borrow/Return"
        btnManageBorrowReturn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = CType(resources.GetObject("PictureBox14.Image"), Image)
        PictureBox14.Location = New Point(24, 32)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(51, 40)
        PictureBox14.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox14.TabIndex = 12
        PictureBox14.TabStop = False
        ' 
        ' labelDateTime
        ' 
        labelDateTime.AutoSize = True
        labelDateTime.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        labelDateTime.Location = New Point(602, 35)
        labelDateTime.Name = "labelDateTime"
        labelDateTime.Size = New Size(41, 15)
        labelDateTime.TabIndex = 14
        labelDateTime.Text = "Label1"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(89, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 51)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(labelDateTime)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "MainForm"
        Text = "Library Management System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnManageBooks As Button
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnManageBorrowers As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnManageBorrowReturn As Button
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents labelDateTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
