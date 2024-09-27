Imports System.IO
Imports System.Media


Public Class Form1
    Public yeet As New SoundPlayer("yeet.wav")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        yeet.Play()
        recentbox.Items.Add(TextBox1.Text)
        If Megayeet.Checked = True Then
            MessageBox.Show(TextBox1.Text & " was mega yeeted")
        ElseIf Nyeet.Checked = True Then
            MessageBox.Show(TextBox1.Text & " was yeeted")
        ElseIf Cyeet.Checked = True Then
            If yeetbox.Text = "" Then
                MessageBox.Show(TextBox1.Text & " was yeeted " & yeetbox.SelectedItem & " times " & TextBox2.Text)
            Else MessageBox.Show(TextBox1.Text & " was yeeted " & yeetbox.Text & " times " & TextBox2.Text)
            End If
        End If
        TextBox1.Clear()
    End Sub


    Private Sub recentbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles recentbox.SelectedIndexChanged
        TextBox1.Clear()
        TextBox1.AppendText(recentbox.SelectedItem)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Integer = 1 To 50
            yeetbox.Items.Add(x.ToString)
        Next
        If Cyeet.Checked = True Then
            TextBox2.Show()
            TextBox2.Enabled = True
        Else
            TextBox2.Hide()
            TextBox2.Clear()
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Megayeet_CheckedChanged_1(sender As Object, e As EventArgs) Handles Megayeet.CheckedChanged
        If Megayeet.Checked = True Then
            yeetbox.Enabled = False
            yeetbox.Hide()
            Label3.Hide()
            Button1.Top = +200
        Else
            yeetbox.Enabled = True
            yeetbox.Show()
            Label3.Show()
        End If
    End Sub


    Private Sub Cyeet_CheckedChanged(sender As Object, e As EventArgs) Handles Cyeet.CheckedChanged
        If Cyeet.Checked = True Then
            TextBox2.Show()
            yeetbox.Show()
            Label2.Show()
            Label3.Show()
            TextBox2.Enabled = True
            Button1.Top = +300
        Else
            TextBox2.Hide()
            TextBox2.Clear()
            yeetbox.Hide()
            Label2.Hide()
            Label3.Hide()
            TextBox2.Enabled = False
        End If

    End Sub

    Private Sub Nyeet_CheckedChanged(sender As Object, e As EventArgs) Handles Nyeet.CheckedChanged
        If Nyeet.Checked = True Then
            TextBox2.Hide()
            Label2.Hide()
            Label3.Hide()
            yeetbox.Hide()
            Button1.Top = +200
        End If
    End Sub
End Class
