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
        Label1 = New Label()
        Button1 = New Button()
        IdentityPicker = New OpenFileDialog()
        Button2 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SimSun-ExtB", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(8, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 21)
        Label1.TabIndex = 0
        Label1.Text = "Identity Manager"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(48, 88)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 23)
        Button1.TabIndex = 1
        Button1.Text = "Load Identity Card"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' IdentityPicker
        ' 
        IdentityPicker.Filter = "User Identity Card( *.uic)|*.uic"
        IdentityPicker.InitialDirectory = "."
        IdentityPicker.ShowHiddenFiles = True
        IdentityPicker.ShowPreview = True
        IdentityPicker.ShowReadOnly = True
        IdentityPicker.SupportMultiDottedExtensions = True
        IdentityPicker.Title = "IdentityPicker"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(40, 128)
        Button2.Name = "Button2"
        Button2.Size = New Size(124, 23)
        Button2.TabIndex = 2
        Button2.Text = "Create New Identity"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(0, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(230, 15)
        Label2.TabIndex = 3
        Label2.Text = "(Just a bunch of info on people you know)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(226, 182)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Identity Manager"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IdentityPicker As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label

End Class
