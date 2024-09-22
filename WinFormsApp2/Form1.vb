Imports Microsoft.VisualBasic.Devices
Imports System.Diagnostics
Imports System.Media
Imports System.Security.Cryptography
Public Class Form1

    Private stopwatch As New Stopwatch()
    Private random As New Random()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        begin()
    End Sub
    Private Sub begin()
        Dim scream As New SoundPlayer("scream.wav")
        Dim tooltip As New ToolTip()
        Button1.Hide()
        scream.Play()
        stopbutton.Show()
        stopwatch.Reset()
        stopwatch.Start()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timelabel.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss\.fff")
    End Sub



    Private Sub stopbutton_Click(sender As Object, e As EventArgs) Handles stopbutton.Click
        stopbutton.Hide()
        stopwatch.Stop()
        MessageBox.Show("Congrats, you were able to press the buton.", stopwatch.Elapsed.ToString())
        Button1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim centerX As Integer = Me.Width \ 2
        Dim centerY As Integer = Me.Height \ 2
        Dim newLeft As Integer = centerX - stopbutton.Width \ 2
        Dim newTop As Integer = centerY - stopbutton.Height \ 2
        stopbutton.Location = New Point(newLeft, newTop)
    End Sub
    Private Sub cooldown_Tick(sender As Object, e As EventArgs) Handles cooldown.Tick
        Dim randomValue1 As Integer = random.Next(1, 200)
        Dim randomValue2 As Integer = random.Next(1, 100)
        Dim dx As Integer = Cursor.Position.X - stopbutton.Left
        Dim dy As Integer = Cursor.Position.Y - stopbutton.Top
        Dim distance As Double = Math.Sqrt(dx * dx + dy * dy)

        If distance < 500 Then
            stopbutton.Left += 100 * dx / distance - randomValue1
            stopbutton.Top += 100 * dy / distance - randomValue2
        End If

    End Sub

    Private Sub teachermode_CheckedChanged(sender As Object, e As EventArgs) Handles teachermode.CheckedChanged
        If teachermode.Checked Then
            cooldown.Enabled = False
        Else
            cooldown.Enabled = True
        End If
    End Sub
End Class
