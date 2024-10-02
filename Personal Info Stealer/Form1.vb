


Public Class Form1
    Private Sub FirstName_TextChanged(sender As Object, e As EventArgs) Handles FirstName.TextChanged
        info.Clear()
        info.AppendText("Hello, my name is " & FirstName.Text)
    End Sub

    Private Sub LastName_TextChanged(sender As Object, e As EventArgs) Handles LastName.TextChanged

        info.Clear()
        info.AppendText("Hello, my name is " & FirstName.Text & " " & LastName.Text)
    End Sub

    Private Sub DateOfBirth_TextChanged(sender As Object, e As EventArgs) Handles DateOfBirth.TextChanged
        info.Clear()
        info.AppendText("Hello, my name is " & FirstName.Text & " " & LastName.Text & ". " & "My birthday is " & DateOfBirth.Text)
    End Sub

    Private Sub FavoriteColor_TextChanged(sender As Object, e As EventArgs) Handles FavoriteColor.TextChanged
        info.Clear()
        info.AppendText("Hello, my name is " & FirstName.Text & " " & LastName.Text & ". " & "My birthday is " & DateOfBirth.Text & " and my favorite color is " & FavoriteColor.Text)
    End Sub
End Class
