Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            SaveFileDialog1.ShowDialog()
            File.WriteAllTextAsync(SaveFileDialog1.FileName, TextBox1.Text)
        Finally
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                TextBox1.Text = File.ReadAllText(OpenFileDialog1.FileName)
            End If
        Finally
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                File.WriteAllTextAsync(OpenFileDialog1.FileName, TextBox1.Text)
            End If
        Finally
        End Try
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Try
            TextBox1.Text = ""
        Finally
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Close()
    End Sub

End Class
