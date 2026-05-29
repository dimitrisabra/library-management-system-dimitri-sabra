<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BorrowerForm))
        GroupBox4 = New GroupBox()
        dgvBorrowers = New DataGridView()
        GroupBox3 = New GroupBox()
        btnRefresh = New Button()
        Label10 = New Label()
        txtSearchId = New TextBox()
        btnSearch = New Button()
        GroupBox2 = New GroupBox()
        txtName = New TextBox()
        txtBloodType = New TextBox()
        txtAge = New TextBox()
        Label2 = New Label()
        btnAdd = New Button()
        Label3 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label7 = New Label()
        btnDelete = New Button()
        txtBorrowerId = New TextBox()
        GroupBox4.SuspendLayout()
        CType(dgvBorrowers, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvBorrowers)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox4.Location = New Point(536, 12)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(803, 584)
        GroupBox4.TabIndex = 55
        GroupBox4.TabStop = False
        GroupBox4.Text = "Borrower Table"
        ' 
        ' dgvBorrowers
        ' 
        dgvBorrowers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBorrowers.Location = New Point(17, 32)
        dgvBorrowers.Name = "dgvBorrowers"
        dgvBorrowers.Size = New Size(758, 522)
        dgvBorrowers.TabIndex = 46
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnRefresh)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtSearchId)
        GroupBox3.Controls.Add(btnSearch)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(17, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(493, 83)
        GroupBox3.TabIndex = 54
        GroupBox3.TabStop = False
        GroupBox3.Text = "Search For A Borrower"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(340, 35)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(75, 23)
        btnRefresh.TabIndex = 48
        btnRefresh.Text = "Reset"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(21, 38)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 15)
        Label10.TabIndex = 47
        Label10.Text = "Enter Book Id"
        ' 
        ' txtSearchId
        ' 
        txtSearchId.Location = New Point(104, 35)
        txtSearchId.Name = "txtSearchId"
        txtSearchId.Size = New Size(100, 23)
        txtSearchId.TabIndex = 44
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(236, 35)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 45
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtName)
        GroupBox2.Controls.Add(txtBloodType)
        GroupBox2.Controls.Add(txtAge)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(17, 127)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(493, 188)
        GroupBox2.TabIndex = 53
        GroupBox2.TabStop = False
        GroupBox2.Text = "Add a borrower"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(94, 38)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 14
        ' 
        ' txtBloodType
        ' 
        txtBloodType.Location = New Point(357, 38)
        txtBloodType.Name = "txtBloodType"
        txtBloodType.Size = New Size(100, 23)
        txtBloodType.TabIndex = 15
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(94, 77)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(100, 23)
        txtAge.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 20
        Label2.Text = "Name:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(214, 132)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 25
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(31, 15)
        Label3.TabIndex = 21
        Label3.Text = "Age:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(282, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 23
        Label5.Text = "Blood Type:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(txtBorrowerId)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(17, 339)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(437, 86)
        GroupBox1.TabIndex = 52
        GroupBox1.TabStop = False
        GroupBox1.Text = "Delete a borrower"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 39)
        Label7.Name = "Label7"
        Label7.Size = New Size(159, 15)
        Label7.TabIndex = 42
        Label7.Text = "Enter Borrower Id to remove:"
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(289, 36)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 43
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtBorrowerId
        ' 
        txtBorrowerId.Location = New Point(171, 36)
        txtBorrowerId.Name = "txtBorrowerId"
        txtBorrowerId.Size = New Size(100, 23)
        txtBorrowerId.TabIndex = 40
        ' 
        ' BorrowerForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1370, 749)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BorrowerForm"
        Text = "BorrowForm"
        GroupBox4.ResumeLayout(False)
        CType(dgvBorrowers, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvBorrowers As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearchId As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBloodType As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtBorrowerId As TextBox
End Class
