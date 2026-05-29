Imports SqlCommand = Microsoft.Data.Sqlite.SqliteCommand
Imports SqlConnection = Microsoft.Data.Sqlite.SqliteConnection
Imports SqlDataReader = Microsoft.Data.Sqlite.SqliteDataReader
Imports System.Data

Public Class ManageBooksForm
    Private MyCn As New SqlConnection(Database.ConnectionString)

    Private Sub ManageBooksForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowings()
    End Sub
    Private Sub LoadBorrowings()
        Try
            Dim query As String = "
    SELECT 
        b.borrowing_id, 
        b.borrower_id, 
        br.name AS borrower_name, 
        b.book_id, 
        bk.title AS book_name, 
        bk.price,        
        b.due_date, 
        b.date
    FROM borrowings b
    INNER JOIN borrowers br ON b.borrower_id = br.borrower_id
    INNER JOIN books bk ON b.book_id = bk.book_id
"

            Dim adapter As New SqlDataAdapter(query, MyCn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDueDates.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim borrowingId As Integer
        If Integer.TryParse(txtSearchId.Text, borrowingId) Then
            Dim query As String = "
            SELECT 
                b.borrowing_id, 
                b.borrower_id, 
                br.name AS borrower_name, 
                b.book_id, 
                bk.title AS book_name, 
                bk.price,
                b.due_date, 
                b.date
            FROM borrowings b
            INNER JOIN borrowers br ON b.borrower_id = br.borrower_id
            INNER JOIN books bk ON b.book_id = bk.book_id
            WHERE b.borrowing_id = @borrowingId
        "

            Dim table As New DataTable()

            Using MyCn As New SqlConnection(Database.ConnectionString)
                Using cmd As New SqlCommand(query, MyCn)
                    cmd.Parameters.AddWithValue("@borrowingId", borrowingId)
                    Using adapter As New SqlDataAdapter(cmd)
                        Try
                            MyCn.Open()
                            adapter.Fill(table)
                            dgvDueDates.DataSource = table
                        Catch ex As Exception
                            MessageBox.Show("Error: " & ex.Message)
                        End Try
                    End Using
                End Using
            End Using
        Else
            MessageBox.Show("Please enter a valid Borrowing ID.")
        End If
    End Sub



    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Try
            MyCn.Open()
            Dim selectCmd As New SqlCommand("
            SELECT 
                b.borrowing_id, 
                b.borrower_id, 
                br.name AS borrower_name, 
                b.book_id, 
                bk.title AS book_name, 
                bk.price
            FROM borrowings b
            INNER JOIN borrowers br ON b.borrower_id = br.borrower_id
            INNER JOIN books bk ON b.book_id = bk.book_id
            WHERE b.borrowing_id = @id", MyCn)
            selectCmd.Parameters.AddWithValue("@id", txtborrowingid.Text)

            Dim reader As SqlDataReader = selectCmd.ExecuteReader()
            If reader.Read() Then

                Dim borrowingId As Integer = Convert.ToInt32(reader("borrowing_id"))
                Dim borrowerId As Integer = Convert.ToInt32(reader("borrower_id"))
                Dim borrowerName As String = reader("borrower_name").ToString()
                Dim bookId As Integer = Convert.ToInt32(reader("book_id"))
                Dim bookName As String = reader("book_name").ToString()
                Dim price As Decimal = Convert.ToDecimal(reader("price"))
                reader.Close()

                Dim insertCmd As New SqlCommand("
                INSERT INTO returned 
                (borrowing_id, borrower_id, borrower_name, book_id, book_name, price, return_date) 
                VALUES 
                (@borrow, @borrower, @borrowerName, @book, @bookName, @price, @date)", MyCn)
                insertCmd.Parameters.AddWithValue("@borrow", borrowingId)
                insertCmd.Parameters.AddWithValue("@borrower", borrowerId)
                insertCmd.Parameters.AddWithValue("@borrowerName", borrowerName)
                insertCmd.Parameters.AddWithValue("@book", bookId)
                insertCmd.Parameters.AddWithValue("@bookName", bookName)
                insertCmd.Parameters.AddWithValue("@price", price)
                insertCmd.Parameters.AddWithValue("@date", DateTime.Now)
                insertCmd.ExecuteNonQuery()

                Dim deleteCmd As New SqlCommand("DELETE FROM borrowings WHERE borrowing_id = @id", MyCn)
                deleteCmd.Parameters.AddWithValue("@id", borrowingId)
                deleteCmd.ExecuteNonQuery()

                MessageBox.Show("Borrowing returned and logged successfully.")
                LoadBorrowings()
            Else
                reader.Close()
                MessageBox.Show("Borrowing ID not found.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MyCn.Close()
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadBorrowings()
    End Sub

    Private Sub btnBorrow_Click(sender As Object, e As EventArgs) Handles btnBorrow.Click
        Try
            Dim borrowerId As Integer
            Dim bookId As Integer
            Dim dueDate As DateTime

            If Not Integer.TryParse(txtBorrowerId.Text, borrowerId) Then
                MessageBox.Show("Please enter a valid Borrower ID.")
                Return
            End If

            If Not Integer.TryParse(txtBookId.Text, bookId) Then
                MessageBox.Show("Please enter a valid Book ID.")
                Return
            End If

            If Not DateTime.TryParse(txtDueDate.Text, dueDate) Then
                MessageBox.Show("Please enter a valid Due Date.")
                Return
            End If

            Dim borrowDate As DateTime = DateTime.Now

            Dim query As String = "INSERT INTO borrowings (borrower_id, book_id, due_date, date) " &
                                  "VALUES (@borrowerId, @bookId, @dueDate, @borrowDate)"

            Using cmd As New SqlCommand(query, MyCn)
                cmd.Parameters.AddWithValue("@borrowerId", borrowerId)
                cmd.Parameters.AddWithValue("@bookId", bookId)
                cmd.Parameters.AddWithValue("@dueDate", dueDate)
                cmd.Parameters.AddWithValue("@borrowDate", borrowDate)

                MyCn.Open()
                cmd.ExecuteNonQuery()
                MyCn.Close()

                MessageBox.Show("Book borrowed successfully!")

                LoadBorrowings()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
