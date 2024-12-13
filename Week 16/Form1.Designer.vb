<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(256, 88)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 23)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(230, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(292, 30)
        Label1.TabIndex = 1
        Label1.Text = "Type your favorite number here" & vbCrLf & "Note: ANYTHING EXCEPT NUMBERS WILL BREAK THIS"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(268, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(192, 52)
        Button1.TabIndex = 2
        Button1.Text = "Confirm"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(230, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(292, 30)
        Label2.TabIndex = 4
        Label2.Text = "Type your second favorite number here" & vbCrLf & "Note: ANYTHING EXCEPT NUMBERS WILL BREAK THIS" & vbCrLf
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(258, 154)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(216, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox

End Class
