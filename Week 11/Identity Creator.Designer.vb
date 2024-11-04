<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class idc
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
        components = New ComponentModel.Container()
        namebox = New TextBox()
        infobox = New TextBox()
        Export = New Button()
        idbox = New TextBox()
        dotlbl = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' namebox
        ' 
        namebox.Location = New Point(48, 24)
        namebox.Name = "namebox"
        namebox.PlaceholderText = "Name"
        namebox.Size = New Size(208, 23)
        namebox.TabIndex = 0
        ' 
        ' infobox
        ' 
        infobox.Location = New Point(16, 80)
        infobox.Multiline = True
        infobox.Name = "infobox"
        infobox.PlaceholderText = "info such as: address, birthday, age, email, habits, etc."
        infobox.Size = New Size(288, 136)
        infobox.TabIndex = 1
        ' 
        ' Export
        ' 
        Export.Location = New Point(120, 280)
        Export.Name = "Export"
        Export.Size = New Size(56, 40)
        Export.TabIndex = 2
        Export.Text = "Export Identity"
        Export.UseVisualStyleBackColor = True
        ' 
        ' idbox
        ' 
        idbox.Location = New Point(72, 224)
        idbox.Name = "idbox"
        idbox.PlaceholderText = "type random stuff here"
        idbox.Size = New Size(152, 23)
        idbox.TabIndex = 3
        ' 
        ' dotlbl
        ' 
        dotlbl.AutoSize = True
        dotlbl.BackColor = SystemColors.ControlLightLight
        dotlbl.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        dotlbl.Location = New Point(232, 224)
        dotlbl.Name = "dotlbl"
        dotlbl.Size = New Size(0, 21)
        dotlbl.TabIndex = 4
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 70
        ' 
        ' idc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(321, 327)
        Controls.Add(dotlbl)
        Controls.Add(idbox)
        Controls.Add(Export)
        Controls.Add(infobox)
        Controls.Add(namebox)
        Name = "idc"
        Text = "Identity Creator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents namebox As TextBox
    Friend WithEvents infobox As TextBox
    Friend WithEvents Export As Button
    Friend WithEvents idbox As TextBox
    Friend WithEvents dotlbl As Label
    Friend WithEvents Timer1 As Timer
End Class
