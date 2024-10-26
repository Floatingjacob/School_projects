
Imports System.Xml
Public Class idc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Export.Click
        Dim save As New SaveFileDialog()
        Try
            Dim rnd As New Random()
            Dim rndn As Integer = rnd.Next(0, 3)
            Dim randomstuffstring As New randomstuff(idbox.Text)

            Dim xmlDoc As New XmlDocument()
            save.Filter() = "Identity Card( *.idc)|*.idc"
            save.FileName = namebox.Text
            save.ShowDialog()

            Dim declaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            Dim root As XmlElement = xmlDoc.CreateElement("Root")
            xmlDoc.AppendChild(declaration)
            xmlDoc.AppendChild(root)

            Dim iname As XmlElement = xmlDoc.CreateElement("name")
            Dim randomstuff As XmlElement = xmlDoc.CreateElement("randomstuff")
            Dim info As XmlElement = xmlDoc.CreateElement("info")
            iname.InnerText = namebox.Text
            info.InnerText = infobox.Text
            randomstuff.InnerText = randomstuffstring.randomstuff
            xmlDoc.DocumentElement.AppendChild(iname)
            xmlDoc.DocumentElement.AppendChild(info)
            xmlDoc.DocumentElement.AppendChild(randomstuff)
            xmlDoc.Save(save.FileName)
            MessageBox.Show("Success, you may now close this window")
        Catch
        End Try
    End Sub

End Class
Public Class randomstuff
    Public Sub dot1()
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(1, 3)
        Select Case randomNumber
            Case 1
                idc.dotlbl.Text.Append(".")
                Task.Delay(50)
            Case 2
                dot2()
        End Select
    End Sub
    Private Sub dot2()
        Dim rnd As New Random()
        Dim randomNumber As Integer = rnd.Next(1, 3)
        Select Case randomNumber
            Case 1
                dot1()
            Case 2
                idc.dotlbl.ResetText()
        End Select
    End Sub
    Public randomstuff As String
    Public Sub New()
        randomstuff = "218o74ougdf"
    End Sub
    Public Sub New(ByVal randomstuff As String)
        Me.randomstuff = randomstuff

    End Sub
End Class

