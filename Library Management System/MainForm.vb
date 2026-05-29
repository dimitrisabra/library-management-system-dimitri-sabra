Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        labelDateTime.Text = DateTime.Now.ToString("F")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelDateTime.Text = DateTime.Now.ToString("F")
    End Sub
    Private Sub btnManageBooks_Click(sender As Object, e As EventArgs) Handles btnManageBooks.Click
        Dim manageBooks As New BooksForm()
        manageBooks.Show()
    End Sub
    Private Sub btnManageBorrowers_Click(sender As Object, e As EventArgs) Handles btnManageBorrowers.Click
        Dim borrowForm As New BorrowerForm()
        borrowForm.Show()
    End Sub
    Private Sub btnManageBorrowReturn_Click(sender As Object, e As EventArgs) Handles btnManageBorrowReturn.Click
        Dim borrowForm As New ManageBooksForm()
        borrowForm.Show()
    End Sub
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Dim generateForm As New GenerateReportForm()
        generateForm.Show()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Dim loginForm As New Form1()
        loginForm.Show()
    End Sub
End Class