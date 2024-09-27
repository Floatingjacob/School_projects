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
        components = New ComponentModel.Container()
        recentbox = New ComboBox()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        TextBox2 = New TextBox()
        Timer1 = New Timer(components)
        yeetbox = New ComboBox()
        Nyeet = New RadioButton()
        Megayeet = New RadioButton()
        Label2 = New Label()
        Cyeet = New RadioButton()
        SuspendLayout()
        ' 
        ' recentbox
        ' 
        recentbox.DropDownWidth = 300
        recentbox.FormattingEnabled = True
        recentbox.Location = New Point(464, 80)
        recentbox.Name = "recentbox"
        recentbox.Size = New Size(24, 28)
        recentbox.TabIndex = 0
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(320, 80)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "the yeeted's name"
        TextBox1.Size = New Size(144, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(328, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 20)
        Label1.TabIndex = 2
        Label1.Text = "YEET somebody"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(296, 240)
        Label3.Name = "Label3"
        Label3.Size = New Size(253, 20)
        Label3.TabIndex = 6
        Label3.Text = "How many times should i yeet them?"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(336, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 32)
        Button1.TabIndex = 9
        Button1.Text = "YEET"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(272, 216)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "yeet them to"
        TextBox2.Size = New Size(280, 27)
        TextBox2.TabIndex = 11
        ' 
        ' yeetbox
        ' 
        yeetbox.FormattingEnabled = True
        yeetbox.Location = New Point(320, 264)
        yeetbox.Name = "yeetbox"
        yeetbox.Size = New Size(184, 28)
        yeetbox.TabIndex = 4
        ' 
        ' Nyeet
        ' 
        Nyeet.AutoSize = True
        Nyeet.Checked = True
        Nyeet.Location = New Point(352, 120)
        Nyeet.Name = "Nyeet"
        Nyeet.Size = New Size(112, 24)
        Nyeet.TabIndex = 14
        Nyeet.TabStop = True
        Nyeet.Text = "Normal Yeet"
        Nyeet.UseVisualStyleBackColor = True
        ' 
        ' Megayeet
        ' 
        Megayeet.AutoSize = True
        Megayeet.Location = New Point(352, 144)
        Megayeet.Name = "Megayeet"
        Megayeet.Size = New Size(100, 24)
        Megayeet.TabIndex = 15
        Megayeet.Text = "Mega Yeet"
        Megayeet.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(320, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(162, 20)
        Label2.TabIndex = 16
        Label2.Text = "Yeet them somewhere?"
        ' 
        ' Cyeet
        ' 
        Cyeet.AutoSize = True
        Cyeet.Location = New Point(352, 168)
        Cyeet.Name = "Cyeet"
        Cyeet.Size = New Size(112, 24)
        Cyeet.TabIndex = 17
        Cyeet.Text = "Custom Yeet"
        Cyeet.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Cyeet)
        Controls.Add(Label2)
        Controls.Add(Megayeet)
        Controls.Add(Nyeet)
        Controls.Add(TextBox2)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(yeetbox)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(recentbox)
        Name = "Form1"
        Text = "The Yeet Machine"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents recentbox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents yeetbox As ComboBox
    Friend WithEvents Nyeet As RadioButton
    Friend WithEvents Megayeet As RadioButton
    Friend WithEvents Label2 As Label
    Private WithEvents Cyeet As RadioButton

End Class
