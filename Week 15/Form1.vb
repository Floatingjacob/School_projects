Imports System.Media


Public Class Form1
    Public fillable = 1
    Public times = 0
    Public err As New SoundPlayer("error.wav")
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim boot As New SoundPlayer("boot.wav")
        boot.Play()
        Await Task.Delay(5000)
        err.Play()
        MessageBox.Show("Error: Recycle bin is too large, please select files to remove.")
    End Sub

    Private Sub FileExplorerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileExplorerToolStripMenuItem.Click
        If GroupBox1.Visible = False Then
            GroupBox1.Show()
        Else
            GroupBox1.Hide()
        End If
        GroupBox2.Hide()

    End Sub

    Private Sub Desktop_Click(sender As Object, e As EventArgs) Handles Desktop.Click
        GroupBox1.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox1.Hide()
        GroupBox2.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        Fill()
    End Sub
    Private Async Sub Fill()
        If fillable = 1 Then
            For x As Integer = 1 To Integer.MaxValue
                If fillable = 0 Then
                    Exit For
                End If
                TextBox1.Text = (x.ToString() & " GB")
                Await Task.Delay(300)
            Next
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Hide()
        Else
            GroupBox3.Show()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If Timer1.Enabled = False Then
            times += 1
            Select Case times
                Case 1
                    fillable = 0
                    TextBox1.Text = "2 Petabytes"
                    err.Play()
                    MessageBox.Show("Error: Recycle bin is at critical mass, empty immediately.")
                Case 2
                    TextBox1.Text = "10 Petabytes"
                    err.Play()
                    MessageBox.Show("Error: Recycle bin is beyond critical mass, EMPTY IMMEDIATELY TO AVOID HARM.")
                Case 3
                    Process.Start(New ProcessStartInfo("explode.mp4") With {.UseShellExecute = True})
            End Select
        End If
    End Sub
End Class