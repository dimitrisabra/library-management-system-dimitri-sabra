<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BooksForm))
        btnAdd = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtPrice = New TextBox()
        txtAuthor = New TextBox()
        txtPublisher = New TextBox()
        txtYear = New TextBox()
        txtTitle = New TextBox()
        btnDelete = New Button()
        Label7 = New Label()
        txtBookId = New TextBox()
        Label10 = New Label()
        dgvBooks = New DataGridView()
        btnSearch = New Button()
        txtSearchId = New TextBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        btnRefresh = New Button()
        GroupBox4 = New GroupBox()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(217, 170)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 25
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(315, 80)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 24
        Label6.Text = "Price:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(315, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 23
        Label5.Text = "Year:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 15)
        Label4.TabIndex = 22
        Label4.Text = "Publisher:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 15)
        Label3.TabIndex = 21
        Label3.Text = "Author:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 20
        Label2.Text = "Book Title:"
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(357, 77)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 18
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(94, 77)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(100, 23)
        txtAuthor.TabIndex = 17
        ' 
        ' txtPublisher
        ' 
        txtPublisher.Location = New Point(94, 115)
        txtPublisher.Name = "txtPublisher"
        txtPublisher.Size = New Size(100, 23)
        txtPublisher.TabIndex = 16
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(357, 38)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(100, 23)
        txtYear.TabIndex = 15
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(94, 38)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(100, 23)
        txtTitle.TabIndex = 14
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(277, 36)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 43
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 39)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 15)
        Label7.TabIndex = 42
        Label7.Text = "Enter Book Id to remove:"
        ' 
        ' txtBookId
        ' 
        txtBookId.Location = New Point(159, 36)
        txtBookId.Name = "txtBookId"
        txtBookId.Size = New Size(100, 23)
        txtBookId.TabIndex = 40
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
        ' dgvBooks
        ' 
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(17, 32)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(758, 522)
        dgvBooks.TabIndex = 46
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
        ' txtSearchId
        ' 
        txtSearchId.Location = New Point(104, 35)
        txtSearchId.Name = "txtSearchId"
        txtSearchId.Size = New Size(100, 23)
        txtSearchId.TabIndex = 44
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(btnDelete)
        GroupBox1.Controls.Add(txtBookId)
        GroupBox1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        GroupBox1.Location = New Point(36, 403)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(437, 86)
        GroupBox1.TabIndex = 48
        GroupBox1.TabStop = False
        GroupBox1.Text = "Delete a book"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtTitle)
        GroupBox2.Controls.Add(txtYear)
        GroupBox2.Controls.Add(txtPublisher)
        GroupBox2.Controls.Add(txtAuthor)
        GroupBox2.Controls.Add(txtPrice)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(btnAdd)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(36, 139)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(493, 227)
        GroupBox2.TabIndex = 49
        GroupBox2.TabStop = False
        GroupBox2.Text = "Add a book"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnRefresh)
        GroupBox3.Controls.Add(Label10)
        GroupBox3.Controls.Add(txtSearchId)
        GroupBox3.Controls.Add(btnSearch)
        GroupBox3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.Location = New Point(36, 24)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(493, 83)
        GroupBox3.TabIndex = 50
        GroupBox3.TabStop = False
        GroupBox3.Text = "Search For A Book"
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
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(dgvBooks)
        GroupBox4.Location = New Point(555, 24)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(803, 584)
        GroupBox4.TabIndex = 51
        GroupBox4.TabStop = False
        GroupBox4.Text = "Books Table"
        ' 
        ' BooksForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1370, 641)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "BooksForm"
        Text = "Books Management"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBookId As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents GroupBox4 As GroupBox
End Class
