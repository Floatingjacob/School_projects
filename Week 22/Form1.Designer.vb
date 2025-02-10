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
        cbGame = New ComboBox()
        GameDeveloper = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        btnAdd = New Button()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' cbGame
        ' 
        cbGame.DisplayMember = "FirstName"
        cbGame.FormattingEnabled = True
        cbGame.Location = New Point(8, 66)
        cbGame.Name = "cbGame"
        cbGame.Size = New Size(216, 23)
        cbGame.TabIndex = 1
        ' 
        ' GameDeveloper
        ' 
        GameDeveloper.DisplayMember = "Name"
        GameDeveloper.FormattingEnabled = True
        GameDeveloper.Location = New Point(240, 66)
        GameDeveloper.Name = "GameDeveloper"
        GameDeveloper.Size = New Size(200, 23)
        GameDeveloper.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(8, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 3
        Label1.Text = "Game name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(240, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 15)
        Label2.TabIndex = 4
        Label2.Text = "Game Dev"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(146, 98)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(242, 98)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 6
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(461, 157)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GameDeveloper)
        Controls.Add(cbGame)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents cbGame As ComboBox
    Friend WithEvents GameDeveloper As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button

End Class
