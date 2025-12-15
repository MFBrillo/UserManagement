<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OkPrompt
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AppName = New System.Windows.Forms.Label()
        Me.MsgText = New System.Windows.Forms.Label()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.usermanagement.My.Resources.Resources.SupportLogo
        Me.PictureBox1.Location = New System.Drawing.Point(33, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnclose.Location = New System.Drawing.Point(357, 246)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(150, 45)
        Me.btnclose.TabIndex = 30
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AppName)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 311)
        Me.Panel1.TabIndex = 32
        '
        'AppName
        '
        Me.AppName.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppName.BackColor = System.Drawing.Color.Transparent
        Me.AppName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.AppName.Location = New System.Drawing.Point(3, 203)
        Me.AppName.Name = "AppName"
        Me.AppName.Size = New System.Drawing.Size(200, 62)
        Me.AppName.TabIndex = 2
        Me.AppName.Text = "APPNAME"
        Me.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MsgText
        '
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.MsgText.Location = New System.Drawing.Point(206, 75)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(459, 154)
        Me.MsgText.TabIndex = 34
        Me.MsgText.Text = "MESSAGE"
        Me.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleText
        '
        Me.TitleText.AutoSize = True
        Me.TitleText.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.TitleText.ForeColor = System.Drawing.Color.White
        Me.TitleText.Location = New System.Drawing.Point(334, 20)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(173, 36)
        Me.TitleText.TabIndex = 33
        Me.TitleText.Text = "TITLE TEXT"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'OkPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 311)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MsgText)
        Me.Controls.Add(Me.TitleText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OkPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OkPrompt"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnclose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AppName As Label
    Friend WithEvents MsgText As Label
    Friend WithEvents TitleText As Label
    Friend WithEvents Timer1 As Timer
End Class
