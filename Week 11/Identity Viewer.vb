
Imports System.Xml
Public Class Identity_Viewer
    Private Sub Identity_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadidentity As New OpenFileDialog
        loadidentity.Filter() = "Identity Card( *.idc)|*.idc"
        If loadidentity.ShowDialog() = DialogResult.OK Then

            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(loadidentity.FileName)
            Dim iname As XmlElement = xmlDoc.SelectSingleNode("/Root/name")
            Dim info As XmlElement = xmlDoc.SelectSingleNode("/Root/info")
            Dim randomstuff As XmlElement = xmlDoc.SelectSingleNode("/Root/randomstuff")
            If iname IsNot Nothing Then
                namelbl.Text = iname.InnerText
            End If
            If info IsNot Nothing Then
                storylbl.Text = info.InnerText
            End If
            If randomstuff IsNot Nothing Then
                idbox.Text = randomstuff.InnerText
            End If
        End If
    End Sub
End Class