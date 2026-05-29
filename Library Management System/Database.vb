Imports Microsoft.Data.Sqlite
Imports System.Data
Imports System.IO

Public Module Database
    Private ReadOnly DatabaseDirectory As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Library Management System")
    Private ReadOnly DatabasePathValue As String = Path.Combine(DatabaseDirectory, "library.db")
    Private ReadOnly InitializeLock As New Object()
    Private IsInitialized As Boolean = False

    Public ReadOnly Property DatabasePath As String
        Get
            Return DatabasePathValue
        End Get
    End Property

    Public ReadOnly Property ConnectionString As String
        Get
            Directory.CreateDirectory(DatabaseDirectory)

            Dim builder As New SqliteConnectionStringBuilder()
            builder.DataSource = DatabasePathValue
            Return builder.ToString()
        End Get
    End Property

    Public Sub Initialize()
        If IsInitialized Then
            Return
        End If

        SyncLock InitializeLock
            If IsInitialized Then
                Return
            End If

            Directory.CreateDirectory(DatabaseDirectory)

            Using connection As New SqliteConnection(ConnectionString)
                connection.Open()

                For Each statement In SchemaStatements()
                    ExecuteNonQuery(connection, statement)
                Next

                ExecuteNonQuery(connection, "INSERT INTO users (username, password) VALUES ('admin', '123') ON CONFLICT(username) DO UPDATE SET password = excluded.password;")
                ExecuteNonQuery(connection, "INSERT OR IGNORE INTO users (username, password) VALUES ('user', '123');")
            End Using

            IsInitialized = True
        End SyncLock
    End Sub

    Public Function NormalizeSql(sql As String) As String
        Return sql.Replace("dbo.", "")
    End Function

    Private Function SchemaStatements() As String()
        Return {
            "CREATE TABLE IF NOT EXISTS users (
                user_id INTEGER PRIMARY KEY AUTOINCREMENT,
                username TEXT NOT NULL UNIQUE,
                password TEXT NOT NULL,
                created_at TEXT DEFAULT CURRENT_TIMESTAMP
            );",
            "CREATE TABLE IF NOT EXISTS books (
                book_id INTEGER PRIMARY KEY AUTOINCREMENT,
                title TEXT,
                author TEXT,
                publisher TEXT,
                year TEXT,
                price NUMERIC
            );",
            "CREATE TABLE IF NOT EXISTS borrowers (
                borrower_id INTEGER PRIMARY KEY AUTOINCREMENT,
                name TEXT,
                age INTEGER,
                blood_type TEXT
            );",
            "CREATE TABLE IF NOT EXISTS borrowings (
                borrowing_id INTEGER PRIMARY KEY AUTOINCREMENT,
                borrower_id INTEGER,
                book_id INTEGER,
                due_date TEXT,
                date TEXT
            );",
            "CREATE TABLE IF NOT EXISTS returned (
                return_id INTEGER PRIMARY KEY AUTOINCREMENT,
                borrowing_id INTEGER,
                borrower_id INTEGER,
                borrower_name TEXT,
                book_id INTEGER,
                book_name TEXT,
                price NUMERIC,
                return_date TEXT DEFAULT CURRENT_DATE
            );"
        }
    End Function

    Private Sub ExecuteNonQuery(connection As SqliteConnection, commandText As String)
        Using command = connection.CreateCommand()
            command.CommandText = commandText
            command.ExecuteNonQuery()
        End Using
    End Sub
End Module

Public Class SqlDataAdapter
    Implements IDisposable

    Public Property SelectCommand As SqliteCommand

    Public Sub New(commandText As String, connection As SqliteConnection)
        SelectCommand = connection.CreateCommand()
        SelectCommand.CommandText = Database.NormalizeSql(commandText)
    End Sub

    Public Sub New(command As SqliteCommand)
        SelectCommand = command
        SelectCommand.CommandText = Database.NormalizeSql(command.CommandText)
    End Sub

    Public Function Fill(table As DataTable) As Integer
        If SelectCommand Is Nothing OrElse SelectCommand.Connection Is Nothing Then
            Throw New InvalidOperationException("The adapter needs a command with a database connection.")
        End If

        SelectCommand.CommandText = Database.NormalizeSql(SelectCommand.CommandText)

        Dim shouldCloseConnection = SelectCommand.Connection.State <> ConnectionState.Open

        Try
            If shouldCloseConnection Then
                SelectCommand.Connection.Open()
            End If

            Using reader = SelectCommand.ExecuteReader()
                table.Load(reader)
            End Using
        Finally
            If shouldCloseConnection AndAlso SelectCommand.Connection.State = ConnectionState.Open Then
                SelectCommand.Connection.Close()
            End If
        End Try

        Return table.Rows.Count
    End Function

    Public Sub Dispose() Implements IDisposable.Dispose
        If SelectCommand IsNot Nothing Then
            SelectCommand.Dispose()
            SelectCommand = Nothing
        End If
    End Sub
End Class
