Public Class Form1


    Private Sub YouBrokeIt()
        Try
            Dim number1 As Double = Convert.ToDouble(TextBox1.Text)
            Dim number2 As Double = Convert.ToDouble(TextBox2.Text)
            Dim mean As Double = (number1 + number2) / 2

            MessageBox.Show("This should be your new favorite number: " & mean)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        YouBrokeIt()
    End Sub

End Class
