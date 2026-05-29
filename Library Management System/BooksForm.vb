Imports SqlCommand = Microsoft.Data.Sqlite.SqliteCommand
Imports SqlConnection = Microsoft.Data.Sqlite.SqliteConnection

Public Class BooksForm
    Private connectionString As String = Database.ConnectionString

    Private Sub BooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllBooks()
    End Sub

    Private Sub LoadAllBooks()
        Dim query As String = "SELECT * FROM books"
        Dim table As New DataTable()

        Using MyCn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, MyCn)

            Try
                MyCn.Open()
                adapter.Fill(table)
                dgvBooks.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO books (title, author, publisher, year, price) VALUES (@title, @author, @publisher, @year, @price)"

        Using MyCn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, MyCn)

            cmd.Parameters.AddWithValue("@title", txtTitle.Text)
            cmd.Parameters.AddWithValue("@author", txtAuthor.Text)
            cmd.Parameters.AddWithValue("@publisher", txtPublisher.Text)
            cmd.Parameters.AddWithValue("@year", txtYear.Text)
            cmd.Parameters.AddWithValue("@price", txtPrice.Text)

            Try
                MyCn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Book added successfully!")
                LoadAllBooks()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim bookId As Integer
        If Integer.TryParse(txtSearchId.Text, bookId) Then
            Dim query = "SELECT * FROM books WHERE book_id = @bookId"
            Dim table As New DataTable

            Using MyCn As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter(query, MyCn)
                adapter.SelectCommand.Parameters.AddWithValue("@bookId", bookId)

                Try
                    MyCn.Open()
                    adapter.Fill(table)
                    dgvBooks.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please enter a valid Book ID.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim bookId As Integer
        If Integer.TryParse(txtBookId.Text, bookId) Then
            Dim query As String = "DELETE FROM books WHERE book_id = @bookId"

            Using MyCn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(query, MyCn)
                cmd.Parameters.AddWithValue("@bookId", bookId)

                Try
                    MyCn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Book deleted successfully!")
                        LoadAllBooks()
                    Else
                        MessageBox.Show("No book found with that ID.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please enter a valid Book ID.")
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllBooks()
    End Sub
End Class
