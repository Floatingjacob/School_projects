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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Button3 = New Button()
        GroupBox2 = New GroupBox()
        TextBox2 = New TextBox()
        GroupBox3 = New GroupBox()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Desktop = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        FileExplorerToolStripMenuItem = New ToolStripMenuItem()
        Timer1 = New Timer(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.HotTrack = True
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 456)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Button3)
        TabPage1.Controls.Add(GroupBox2)
        TabPage1.Controls.Add(GroupBox3)
        TabPage1.Controls.Add(GroupBox1)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(PictureBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 428)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Desktop1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(716, 378)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 1
        Button3.Text = "Empty Bin"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Window
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Location = New Point(44, 26)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(518, 254)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Downloads"
        GroupBox2.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Window
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(120, 82)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 16)
        TextBox2.TabIndex = 0
        TextBox2.Text = "Empty"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.White
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Location = New Point(30, 106)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(508, 266)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Recycle Bin"
        GroupBox3.Visible = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(6, 20)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(498, 244)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonHighlight
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Desktop)
        GroupBox1.Location = New Point(112, 10)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(516, 258)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "File Explorer"
        GroupBox1.Visible = False
        ' 
        ' Button2
        ' 
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(102, 24)
        Button2.Name = "Button2"
        Button2.Size = New Size(108, 48)
        Button2.TabIndex = 1
        Button2.Text = "Downloads"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Desktop
        ' 
        Desktop.Image = CType(resources.GetObject("Desktop.Image"), Image)
        Desktop.ImageAlign = ContentAlignment.MiddleLeft
        Desktop.Location = New Point(6, 24)
        Desktop.Name = "Desktop"
        Desktop.Size = New Size(94, 48)
        Desktop.TabIndex = 0
        Desktop.Text = "Desktop"
        Desktop.TextAlign = ContentAlignment.MiddleRight
        Desktop.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 5.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(608, 278)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 60)
        Button1.TabIndex = 3
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.ImageLocation = ""
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(0, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(794, 422)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Dock = DockStyle.Bottom
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileExplorerToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 426)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileExplorerToolStripMenuItem
        ' 
        FileExplorerToolStripMenuItem.Name = "FileExplorerToolStripMenuItem"
        FileExplorerToolStripMenuItem.Size = New Size(83, 20)
        FileExplorerToolStripMenuItem.Text = "File Explorer"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        Controls.Add(TabControl1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileExplorerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Desktop As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button

End Class
