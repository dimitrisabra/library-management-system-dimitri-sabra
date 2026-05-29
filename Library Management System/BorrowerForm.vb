Imports SqlCommand = Microsoft.Data.Sqlite.SqliteCommand
Imports SqlConnection = Microsoft.Data.Sqlite.SqliteConnection

Public Class BorrowerForm
    Private connectionString As String = Database.ConnectionString

    Private Sub BorrowersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllBorrowers()
    End Sub

    Private Sub LoadAllBorrowers()
        Dim query As String = "SELECT borrower_id, name, age, blood_type FROM borrowers"
        Dim table As New DataTable()

        Using MyCn As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, MyCn)

            Try
                MyCn.Open()
                adapter.Fill(table)
                dgvBorrowers.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim query As String = "INSERT INTO borrowers (name, age, blood_type) VALUES (@name, @age, @blood_type)"

        Using MyCn As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand(query, MyCn)

            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@age", txtAge.Text)
            cmd.Parameters.AddWithValue("@blood_type", txtBloodType.Text)

            Try
                MyCn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Borrower added successfully!")
                LoadAllBorrowers()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim borrowerId As Integer
        If Integer.TryParse(txtSearchId.Text, borrowerId) Then
            Dim query = "SELECT borrower_id, name, age, blood_type FROM borrowers WHERE borrower_id = @borrower_id"
            Dim table As New DataTable

            Using MyCn As New SqlConnection(connectionString)
                Dim adapter As New SqlDataAdapter(query, MyCn)
                adapter.SelectCommand.Parameters.AddWithValue("@borrower_id", borrowerId)

                Try
                    MyCn.Open()
                    adapter.Fill(table)
                    dgvBorrowers.DataSource = table
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please enter a valid Borrower ID.")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim borrowerId As Integer
        If Integer.TryParse(txtBorrowerId.Text, borrowerId) Then
            Dim query As String = "DELETE FROM borrowers WHERE borrower_id = @borrower_id"

            Using MyCn As New SqlConnection(connectionString)
                Dim cmd As New SqlCommand(query, MyCn)
                cmd.Parameters.AddWithValue("@borrower_id", borrowerId)

                Try
                    MyCn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Borrower deleted successfully!")
                    Else
                        MessageBox.Show("No borrower found with ID ")
                    End If
                    LoadAllBorrowers()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please enter a valid Borrower ID.")
        End If
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadAllBorrowers()
    End Sub
End Class
