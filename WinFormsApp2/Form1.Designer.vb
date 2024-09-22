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
        Button1 = New Button()
        stopbutton = New Button()
        Timer1 = New Timer(components)
        Button2 = New Button()
        timelabel = New Label()
        tooltip1 = New ToolTip(components)
        cooldown = New Timer(components)
        teachermode = New CheckBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(664, 312)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 80)
        Button1.TabIndex = 0
        Button1.Text = "Play Game"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' stopbutton
        ' 
        stopbutton.BackColor = SystemColors.ControlLightLight
        stopbutton.Location = New Point(920, 264)
        stopbutton.Name = "stopbutton"
        stopbutton.Size = New Size(24, 28)
        stopbutton.TabIndex = 1
        stopbutton.Text = "⏯️"
        tooltip1.SetToolTip(stopbutton, "AAH!")
        stopbutton.UseVisualStyleBackColor = False
        stopbutton.Visible = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 20F)
        Button2.Location = New Point(448, 16)
        Button2.Name = "Button2"
        Button2.Size = New Size(32, 56)
        Button2.TabIndex = 3
        Button2.Text = "↺"
        Button2.TextAlign = ContentAlignment.TopCenter
        tooltip1.SetToolTip(Button2, "press me to reset the button")
        Button2.UseVisualStyleBackColor = True
        ' 
        ' timelabel
        ' 
        timelabel.AutoSize = True
        timelabel.Location = New Point(736, 24)
        timelabel.Name = "timelabel"
        timelabel.Size = New Size(0, 20)
        timelabel.TabIndex = 4
        ' 
        ' tooltip1
        ' 
        tooltip1.AutomaticDelay = 0
        tooltip1.AutoPopDelay = 0
        tooltip1.InitialDelay = 0
        tooltip1.IsBalloon = True
        tooltip1.ReshowDelay = 100
        tooltip1.ShowAlways = True
        ' 
        ' cooldown
        ' 
        cooldown.Enabled = True
        cooldown.Interval = 500
        ' 
        ' teachermode
        ' 
        teachermode.AutoSize = True
        teachermode.Location = New Point(552, 32)
        teachermode.Name = "teachermode"
        teachermode.Size = New Size(119, 24)
        teachermode.TabIndex = 5
        teachermode.Text = "teachermode"
        teachermode.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1557, 863)
        Controls.Add(teachermode)
        Controls.Add(timelabel)
        Controls.Add(Button2)
        Controls.Add(stopbutton)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents stopbutton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button2 As Button
    Friend WithEvents timelabel As Label
    Friend WithEvents tooltip1 As ToolTip
    Friend WithEvents cooldown As Timer
    Friend WithEvents teachermode As CheckBox

End Class
