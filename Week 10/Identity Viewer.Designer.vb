<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Identity_Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        storylbl = New Label()
        namelbl = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        idbox = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' storylbl
        ' 
        storylbl.Location = New Point(64, 112)
        storylbl.Name = "storylbl"
        storylbl.Size = New Size(280, 232)
        storylbl.TabIndex = 2
        ' 
        ' namelbl
        ' 
        namelbl.AutoSize = True
        namelbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        namelbl.Location = New Point(176, 48)
        namelbl.Name = "namelbl"
        namelbl.Size = New Size(0, 21)
        namelbl.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(168, 16)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(88, 23)
        TextBox1.TabIndex = 4
        TextBox1.Text = "Identity Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(168, 80)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(80, 23)
        TextBox2.TabIndex = 5
        TextBox2.Text = "Identity Info"
        ' 
        ' idbox
        ' 
        idbox.Location = New Point(120, 368)
        idbox.Name = "idbox"
        idbox.ReadOnly = True
        idbox.Size = New Size(152, 23)
        idbox.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(160, 352)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 7
        Label1.Text = "random stuff"
        ' 
        ' Identity_Viewer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(462, 423)
        Controls.Add(Label1)
        Controls.Add(idbox)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(namelbl)
        Controls.Add(storylbl)
        Name = "Identity_Viewer"
        Text = "Identity Viewer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents storylbl As Label
    Friend WithEvents namelbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents idbox As TextBox
    Friend WithEvents Label1 As Label
End Class
