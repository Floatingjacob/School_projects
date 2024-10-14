Imports System.IO
Imports System.Media

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sound As New SoundPlayer("create.wav")
        If TextBox1.Text <> "" Then
            Try
                sound.Play()
                LB1.Items.Add(TextBox1.Text)
                File.AppendAllText("list", TextBox1.Text & "
")
                TextBox1.Clear()
            Catch
            End Try
        End If

    End Sub
    Private Sub donebox_CheckedChanged(sender As Object, e As EventArgs) Handles donebox.CheckedChanged
        If donebox.Checked = True Then
            If LB1.Items.Count <> LB1.CheckedItems.Count Then
                Try
                    donebox.Checked = False
                    MessageBox.Show("You can't check this until you check evertyhing else")
                Catch
                End Try
            Else
                MessageBox.Show("Yay! you did it!")
                Try
                    LB1.Items.Clear()
                    File.Delete("list")
                Catch
                End Try
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            LB1.Items.Clear()
            File.Delete("list")
        Catch
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim lines() As String = File.ReadAllLines("list")
            For Each line As String In lines
                If Not String.IsNullOrWhiteSpace(line) Then
                    LB1.Items.Add(line)
                End If
            Next
        Catch
        End Try
    End Sub



    Private Sub LB1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles LB1.ItemCheck
        Try
            Dim check As New SoundPlayer("check.wav")
            check.Play()
            Dim itemText As String = LB1.Items(e.Index).ToString()

            If e.NewValue = CheckState.Unchecked Then

                Dim uncheck As New SoundPlayer("uncheck.wav")
                uncheck.Play()
            End If
        Catch
        End Try

    End Sub

End Class
