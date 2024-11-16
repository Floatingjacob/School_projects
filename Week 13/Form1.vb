Public Class Form1
    Private datatable As New DataTable("YRC")


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        datatable.TableName = "YRC_Table"
        datatable.Columns.Add("YRC_Column")
        datatable.Rows.Add(TextBox1.Text)
        datatable.WriteXml("YourRandomCrap.xml")
        Using dataset As New DataSet
            dataset.ReadXml("YourRandomCrap.xml")
            datatable = dataset.Tables(0)
        End Using
    End Sub
End Class
