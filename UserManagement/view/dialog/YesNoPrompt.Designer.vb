<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YesNoPrompt
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
        Me.btnyes = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AppName = New System.Windows.Forms.Label()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.MsgText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnyes
        '
        Me.btnyes.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnyes.FlatAppearance.BorderSize = 0
        Me.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyes.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.btnyes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnyes.Location = New System.Drawing.Point(258, 237)
        Me.btnyes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(150, 45)
        Me.btnyes.TabIndex = 25
        Me.btnyes.Text = "Yes"
        Me.btnyes.UseVisualStyleBackColor = False
        '
        'btnno
        '
        Me.btnno.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnno.FlatAppearance.BorderSize = 0
        Me.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnno.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.btnno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnno.Location = New System.Drawing.Point(470, 237)
        Me.btnno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(150, 45)
        Me.btnno.TabIndex = 26
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = False
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
        Me.Panel1.TabIndex = 27
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
        'TitleText
        '
        Me.TitleText.AutoSize = True
        Me.TitleText.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.TitleText.ForeColor = System.Drawing.Color.White
        Me.TitleText.Location = New System.Drawing.Point(351, 21)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(173, 36)
        Me.TitleText.TabIndex = 28
        Me.TitleText.Text = "TITLE TEXT"
        '
        'MsgText
        '
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.MsgText.Location = New System.Drawing.Point(206, 66)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(459, 154)
        Me.MsgText.TabIndex = 29
        Me.MsgText.Text = "MESSAGE"
        Me.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
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
        'YesNoPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(665, 311)
        Me.Controls.Add(Me.MsgText)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnyes)
        Me.Controls.Add(Me.TitleText)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "YesNoPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomMessage"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnyes As Button
    Friend WithEvents btnno As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitleText As Label
    Friend WithEvents AppName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MsgText As Label
    Friend WithEvents Timer1 As Timer
End Class
