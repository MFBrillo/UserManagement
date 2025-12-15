<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblserversetting = New System.Windows.Forms.LinkLabel()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txtusername = New System.Windows.Forms.TextBox()
        Me.lblclose = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btneye = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pbStatus = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btneye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnSignUp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblserversetting)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(320, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 376)
        Me.Panel1.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(66, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "New here? Create an account now"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.White
        Me.BtnSignUp.FlatAppearance.BorderSize = 0
        Me.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignUp.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.BtnSignUp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.BtnSignUp.Location = New System.Drawing.Point(43, 272)
        Me.BtnSignUp.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(250, 37)
        Me.BtnSignUp.TabIndex = 30
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(278, 48)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Welcome back! We are so happy to have you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here . It's great to see you again. We" &
    " hope you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "had a safe and enjoyable time away."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(104, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Welcome back!"
        '
        'lblserversetting
        '
        Me.lblserversetting.AutoSize = True
        Me.lblserversetting.LinkColor = System.Drawing.Color.White
        Me.lblserversetting.Location = New System.Drawing.Point(244, 354)
        Me.lblserversetting.Name = "lblserversetting"
        Me.lblserversetting.Size = New System.Drawing.Size(74, 13)
        Me.lblserversetting.TabIndex = 19
        Me.lblserversetting.TabStop = True
        Me.lblserversetting.Text = "Server Setting"
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Btnlogin.FlatAppearance.BorderSize = 0
        Me.Btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlogin.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Btnlogin.ForeColor = System.Drawing.Color.White
        Me.Btnlogin.Location = New System.Drawing.Point(36, 272)
        Me.Btnlogin.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(250, 37)
        Me.Btnlogin.TabIndex = 24
        Me.Btnlogin.Text = "Login"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 164)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtpassword
        '
        Me.Txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtpassword.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.Txtpassword.Location = New System.Drawing.Point(36, 180)
        Me.Txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtpassword.Name = "Txtpassword"
        Me.Txtpassword.Size = New System.Drawing.Size(203, 26)
        Me.Txtpassword.TabIndex = 23
        Me.Txtpassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Username"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtusername
        '
        Me.Txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtusername.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtusername.Location = New System.Drawing.Point(34, 117)
        Me.Txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.Txtusername.Name = "Txtusername"
        Me.Txtusername.Size = New System.Drawing.Size(250, 26)
        Me.Txtusername.TabIndex = 22
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.Location = New System.Drawing.Point(144, 354)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(33, 13)
        Me.lblclose.TabIndex = 29
        Me.lblclose.TabStop = True
        Me.lblclose.Text = "Close"
        Me.lblclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 25)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Sign in"
        '
        'btneye
        '
        Me.btneye.Image = Global.usermanagement.My.Resources.Resources.eye
        Me.btneye.ImageActive = Nothing
        Me.btneye.Location = New System.Drawing.Point(244, 177)
        Me.btneye.Name = "btneye"
        Me.btneye.Size = New System.Drawing.Size(42, 29)
        Me.btneye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btneye.TabIndex = 31
        Me.btneye.TabStop = False
        Me.btneye.Zoom = 10
        '
        'pbStatus
        '
        Me.pbStatus.Image = Global.usermanagement.My.Resources.Resources.greenC
        Me.pbStatus.Location = New System.Drawing.Point(3, 3)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(15, 15)
        Me.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStatus.TabIndex = 30
        Me.pbStatus.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.usermanagement.My.Resources.Resources.Support
        Me.PictureBox1.Location = New System.Drawing.Point(127, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(650, 376)
        Me.Controls.Add(Me.btneye)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Txtpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txtusername)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btneye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblserversetting As LinkLabel
    Friend WithEvents Btnlogin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txtusername As TextBox
    Friend WithEvents lblclose As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pbStatus As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btneye As Bunifu.Framework.UI.BunifuImageButton
End Class
