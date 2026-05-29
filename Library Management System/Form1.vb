Imports SqlCommand = Microsoft.Data.Sqlite.SqliteCommand
Imports SqlConnection = Microsoft.Data.Sqlite.SqliteConnection

Public Class Form1
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim MyCn As New SqlConnection
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        MyCn.ConnectionString = Database.ConnectionString

        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"

        Dim command As New SqlCommand(query, MyCn)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)

        Try
            MyCn.Open()

            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login successful!")

                Dim mainForm As New MainForm()
                AddHandler mainForm.FormClosed, AddressOf MainForm_Closed
                mainForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)

        Finally
            If MyCn.State = ConnectionState.Open Then
                MyCn.Close()
            End If
        End Try
    End Sub

    Private Sub MainForm_Closed(sender As Object, e As FormClosedEventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Database.Initialize()
    End Sub
End Class
