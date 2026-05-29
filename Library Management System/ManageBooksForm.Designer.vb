<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageBooksForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageBooksForm))
        GroupBox4 = New GroupBox()
        dgvDueDates = New DataGridView()
        GroupBox3 = New GroupBox()
        btnRefresh = New Button()
        Label10 = New Label()
        txtSearchId = New TextBox()
        btnSearch = New Button()
        GroupBox2 = New GroupBox()
        txtBorrowerId = New TextBox()
        txtDueDate = New TextBox()
        txtBookId = New TextBox()
        Label2 = New Label()
        btnBorrow = New Button()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        btnReturn = New Button()
        txtborrowingid = New TextBox()
        Label1 = New Label()
        GroupBox4.SuspendLayout()
        CType(dgvDueDates, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvDueDates)
        GroupBox4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        GroupBox4.Location = New Point(531, 24)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(803, 584)
        GroupBox4.TabIndex = 59
        GroupBox4.TabStop = False
        GroupBox4.Text = "Due Date Table"
        ' 
        ' dgvDueDates
        ' 
        dgvDueDates.AllowDrop = True
        dgvDueDates.AllowUserToOrderColumns = True
        dgvDueDates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDueDates.Location = New Point(17, 32)
        dgvDueDates.Name = "dgvDueDates"
        dgvDueDates.Size = New Size(758, 522)
        dgvDueDates.TabIndex = 46
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnRefresh)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtSearchId)
        GroupBox3.Controls.Add(btnSearch)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        GroupBox3.Location = New Point(12, 24)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(493, 83)
        GroupBox3.TabIndex = 58
        GroupBox3.TabStop = False
        GroupBox3.Text = "Search A Borrower"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(362, 35)
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
        Label10.Size = New Size(102, 15)
        Label10.TabIndex = 47
        Label10.Text = "Enter Borrower Id:"
        ' 
        ' txtSearchId
        ' 
        txtSearchId.Location = New Point(126, 35)
        txtSearchId.Name = "txtSearchId"
        txtSearchId.Size = New Size(100, 23)
        txtSearchId.TabIndex = 44
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(258, 35)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(75, 23)
        btnSearch.TabIndex = 45
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtBorrowerId)
        GroupBox2.Controls.Add(txtDueDate)
        GroupBox2.Controls.Add(txtBookId)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnBorrow)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        GroupBox2.Location = New Point(12, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(493, 227)
        GroupBox2.TabIndex = 57
        GroupBox2.TabStop = False
        GroupBox2.Text = "Borrow A Book"
        ' 
        ' txtBorrowerId
        ' 
        txtBorrowerId.Location = New Point(148, 38)
        txtBorrowerId.Name = "txtBorrowerId"
        txtBorrowerId.Size = New Size(100, 23)
        txtBorrowerId.TabIndex = 14
        ' 
        ' txtDueDate
        ' 
        txtDueDate.Location = New Point(148, 115)
        txtDueDate.Name = "txtDueDate"
        txtDueDate.Size = New Size(100, 23)
        txtDueDate.TabIndex = 16
        ' 
        ' txtBookId
        ' 
        txtBookId.Location = New Point(148, 77)
        txtBookId.Name = "txtBookId"
        txtBookId.Size = New Size(100, 23)
        txtBookId.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 15)
        Label2.TabIndex = 20
        Label2.Text = "Enter Borrower Id:"
        ' 
        ' btnBorrow
        ' 
        btnBorrow.Location = New Point(217, 170)
        btnBorrow.Name = "btnBorrow"
        btnBorrow.Size = New Size(75, 23)
        btnBorrow.TabIndex = 25
        btnBorrow.Text = "Borrow"
        btnBorrow.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 21
        Label3.Text = "Enter Book Id:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 15)
        Label4.TabIndex = 22
        Label4.Text = "Enter Due Date:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnReturn)
        GroupBox1.Controls.Add(txtborrowingid)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(12, 403)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(437, 126)
        GroupBox1.TabIndex = 56
        GroupBox1.TabStop = False
        GroupBox1.Text = "Return A Book"
        ' 
        ' btnReturn
        ' 
        btnReturn.Location = New Point(188, 86)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(75, 23)
        btnReturn.TabIndex = 48
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = True
        ' 
        ' txtborrowingid
        ' 
        txtborrowingid.Location = New Point(148, 39)
        txtborrowingid.Name = "txtborrowingid"
        txtborrowingid.Size = New Size(100, 23)
        txtborrowingid.TabIndex = 44
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 46
        Label1.Text = "Enter Borrower Id:"
        ' 
        ' ManageBooksForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1296, 685)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ManageBooksForm"
        Text = "Library Management - Manage Books"
        GroupBox4.ResumeLayout(False)
        CType(dgvDueDates, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvDueDates As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearchId As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtBorrowerId As TextBox
    Friend WithEvents txtDueDate As TextBox
    Friend WithEvents txtBookId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBorrow As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtborrowingid As TextBox
    Friend WithEvents Label1 As Label
End Class
