Imports System.Data.SQLite
Imports Dapper
Imports System.IO

Public Class Form1
    Public Sub New()
        InitializeComponent()
        InitializeDatabase()
    End Sub

    Private Sub InitializeDatabase()
        Dim dbPath As String = "catalogue.db"
        Dim connectionStr As String = $"Data Source={dbPath};Version=3;"

        ' Create the database file if it does not exist
        If Not File.Exists(dbPath) Then
            SQLiteConnection.CreateFile(dbPath)
        End If

        ' Create the game table if it does not exist
        Using cn As New SQLiteConnection(connectionStr)
            cn.Open()
            Dim createTableSql As String = "CREATE TABLE IF NOT EXISTS game (" &
                                         "id INTEGER PRIMARY KEY AUTOINCREMENT, " &
                                         "gamename TEXT NOT NULL, " &
                                         "gamedev TEXT NOT NULL);"
            cn.Execute(createTableSql)
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim gameName As String = cbGame.Text.Trim()
        Dim gameDev As String = GameDeveloper.Text.Trim()

        If String.IsNullOrWhiteSpace(gameName) Or String.IsNullOrWhiteSpace(gameDev) Then Exit Sub

        Dim connectionStr As String = "Data Source=catalogue.db;Version=3;"
        Using cn As New SQLiteConnection(connectionStr)
            Dim sql As String = "INSERT INTO game (gamename, gamedev) VALUES (@GameName, @GameDev)"
            Dim params As New DynamicParameters
            params.Add("@GameName", gameName)
            params.Add("@GameDev", gameDev)

            Try
                cn.Open()
                If cn.Execute(sql, params) > 0 Then
                    MessageBox.Show("Game added successfully.", "Success")
                Else
                    MessageBox.Show("Failed to add game.", "Error")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error")
            End Try
        End Using
    End Sub
End Class
