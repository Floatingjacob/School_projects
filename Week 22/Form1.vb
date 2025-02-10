Imports System.Data.SQLite
Imports Dapper

Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim gameName As String = cbGame.Text.Trim()
        Dim gameDev As String = GameDeveloper.Text.Trim()

        If String.IsNullOrWhiteSpace(gameName) Or String.IsNullOrWhiteSpace(gameDev) Then
            MessageBox.Show("Game name and developer cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim connectionStr As String = "Data Source=catalogue.db;Version=3;"
        Using cn As New SQLiteConnection(connectionStr)
            Dim sql As String = "INSERT INTO game (gamename, gamedev) VALUES (@GameName, @GameDev)"
            Dim params As New DynamicParameters
            params.Add("@GameName", value:=gameName, dbType:=DbType.String)
            params.Add("@GameDev", value:=gameDev, dbType:=DbType.String)

            Try
                cn.Open()
                Dim result As Integer = cn.Execute(sql, params)
                If result > 0 Then
                    MessageBox.Show("Game added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Failed to add game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
