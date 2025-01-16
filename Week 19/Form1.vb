Public Class Form1
    Private searchResults As New Dictionary(Of String, Integer)

    Public Sub SearchAndCount(searchText As String, searchLabel As String)
        Dim npos As Integer = 0
        Dim count As Integer = 0
        Do
            npos = InStr(npos + 1, RichTextBox1.Text, searchText)
            If npos > 0 Then
                count += 1
            End If
        Loop While npos > 0
        If Not String.IsNullOrWhiteSpace(searchText) Then
            searchResults($"{searchLabel}: {searchText}") = count
        End If
    End Sub

    Private Sub DisplayResults()
        RichTextBox12.Clear()
        Dim sortedResults = searchResults.OrderByDescending(Function(kvp) kvp.Value)
        For Each result In sortedResults
            RichTextBox12.AppendText($"{result.Key} = {result.Value}{Environment.NewLine}")
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        searchResults.Clear()

        SearchAndCount(RichTextBox2.Text, "Search 2")
        SearchAndCount(RichTextBox3.Text, "Search 3")
        SearchAndCount(RichTextBox4.Text, "Search 4")
        SearchAndCount(RichTextBox5.Text, "Search 5")
        SearchAndCount(RichTextBox6.Text, "Search 6")
        SearchAndCount(RichTextBox7.Text, "Search 7")
        SearchAndCount(RichTextBox8.Text, "Search 8")
        SearchAndCount(RichTextBox9.Text, "Search 9")
        SearchAndCount(RichTextBox10.Text, "Search 10")
        SearchAndCount(RichTextBox11.Text, "Search 11")
        DisplayResults()
    End Sub
End Class
