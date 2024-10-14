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
        Button1 = New Button()
        Button2 = New Button()
        LB1 = New CheckedListBox()
        donebox = New CheckBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(64, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(160, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F)
        Button1.Location = New Point(224, 128)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 40)
        Button1.TabIndex = 2
        Button1.Text = "Add Item"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(296, 200)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 40)
        Button2.TabIndex = 3
        Button2.Text = "Clear list"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LB1
        ' 
        LB1.FormattingEnabled = True
        LB1.Location = New Point(32, 200)
        LB1.Name = "LB1"
        LB1.Size = New Size(264, 166)
        LB1.TabIndex = 4
        ' 
        ' donebox
        ' 
        donebox.AutoSize = True
        donebox.Location = New Point(72, 368)
        donebox.Name = "donebox"
        donebox.Size = New Size(201, 19)
        donebox.TabIndex = 5
        donebox.Text = "I Did Everything On The Checklist"
        donebox.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Segoe Script", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(8, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(366, 40)
        Label1.TabIndex = 6
        Label1.Text = "The Not So Fancy Checklist"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(378, 537)
        Controls.Add(Label1)
        Controls.Add(donebox)
        Controls.Add(LB1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "The Not So Fancy Checklist"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LB1 As CheckedListBox
    Friend WithEvents donebox As CheckBox
    Friend WithEvents Label1 As Label

End Class
