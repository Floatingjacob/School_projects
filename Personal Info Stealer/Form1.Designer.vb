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
        LastName = New TextBox()
        FirstName = New TextBox()
        FavoriteColor = New TextBox()
        info = New TextBox()
        DateOfBirth = New TextBox()
        SuspendLayout()
        ' 
        ' LastName
        ' 
        LastName.Location = New Point(328, 56)
        LastName.Name = "LastName"
        LastName.PlaceholderText = "Last Name"
        LastName.Size = New Size(112, 23)
        LastName.TabIndex = 0
        ' 
        ' FirstName
        ' 
        FirstName.Location = New Point(328, 16)
        FirstName.Name = "FirstName"
        FirstName.PlaceholderText = "First Name"
        FirstName.Size = New Size(112, 23)
        FirstName.TabIndex = 1
        ' 
        ' FavoriteColor
        ' 
        FavoriteColor.Location = New Point(320, 120)
        FavoriteColor.Name = "FavoriteColor"
        FavoriteColor.PlaceholderText = "Your Favorite Color"
        FavoriteColor.Size = New Size(128, 23)
        FavoriteColor.TabIndex = 2
        ' 
        ' info
        ' 
        info.Location = New Point(168, 144)
        info.Name = "info"
        info.ReadOnly = True
        info.Size = New Size(480, 23)
        info.TabIndex = 5
        ' 
        ' DateOfBirth
        ' 
        DateOfBirth.Location = New Point(288, 88)
        DateOfBirth.Name = "DateOfBirth"
        DateOfBirth.PlaceholderText = "Your Birthday"
        DateOfBirth.Size = New Size(184, 23)
        DateOfBirth.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(743, 202)
        Controls.Add(DateOfBirth)
        Controls.Add(info)
        Controls.Add(FavoriteColor)
        Controls.Add(FirstName)
        Controls.Add(LastName)
        Name = "Form1"
        Text = "Personal Info Stealer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LastName As TextBox
    Friend WithEvents FirstName As TextBox
    Friend WithEvents FavoriteColor As TextBox
    Friend WithEvents info As TextBox
    Friend WithEvents DateOfBirth As TextBox

End Class
