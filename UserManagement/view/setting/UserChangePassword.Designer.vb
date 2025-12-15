<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserChangePassword
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtnewpassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcurrentpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtrepassword = New System.Windows.Forms.TextBox()
        Me.btnclose = New System.Windows.Forms.LinkLabel()
        Me.btnchangepassword = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblcurrent = New System.Windows.Forms.Label()
        Me.lblrepass = New System.Windows.Forms.Label()
        Me.btneye = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btneye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "New Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtnewpassword
        '
        Me.txtnewpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtnewpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnewpassword.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.txtnewpassword.Location = New System.Drawing.Point(187, 165)
        Me.txtnewpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.Size = New System.Drawing.Size(290, 26)
        Me.txtnewpassword.TabIndex = 28
        Me.txtnewpassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Current Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtcurrentpassword
        '
        Me.txtcurrentpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtcurrentpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcurrentpassword.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrentpassword.Location = New System.Drawing.Point(187, 90)
        Me.txtcurrentpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcurrentpassword.Name = "txtcurrentpassword"
        Me.txtcurrentpassword.Size = New System.Drawing.Size(250, 26)
        Me.txtcurrentpassword.TabIndex = 27
        Me.txtcurrentpassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Retype Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtrepassword
        '
        Me.txtrepassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtrepassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrepassword.Font = New System.Drawing.Font("Tahoma", 15.75!)
        Me.txtrepassword.Location = New System.Drawing.Point(187, 226)
        Me.txtrepassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtrepassword.Name = "txtrepassword"
        Me.txtrepassword.Size = New System.Drawing.Size(290, 26)
        Me.txtrepassword.TabIndex = 31
        Me.txtrepassword.UseSystemPasswordChar = True
        '
        'btnclose
        '
        Me.btnclose.AutoSize = True
        Me.btnclose.Location = New System.Drawing.Point(596, 343)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(33, 13)
        Me.btnclose.TabIndex = 34
        Me.btnclose.TabStop = True
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnchangepassword
        '
        Me.btnchangepassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnchangepassword.FlatAppearance.BorderSize = 0
        Me.btnchangepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchangepassword.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnchangepassword.ForeColor = System.Drawing.Color.White
        Me.btnchangepassword.Location = New System.Drawing.Point(187, 293)
        Me.btnchangepassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnchangepassword.Name = "btnchangepassword"
        Me.btnchangepassword.Size = New System.Drawing.Size(290, 37)
        Me.btnchangepassword.TabIndex = 33
        Me.btnchangepassword.Text = "Change"
        Me.btnchangepassword.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 35)
        Me.Panel1.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Change User Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(28, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 154)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Sign" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "up"
        '
        'lblcurrent
        '
        Me.lblcurrent.AutoSize = True
        Me.lblcurrent.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrent.ForeColor = System.Drawing.Color.Red
        Me.lblcurrent.Location = New System.Drawing.Point(187, 118)
        Me.lblcurrent.Name = "lblcurrent"
        Me.lblcurrent.Size = New System.Drawing.Size(214, 13)
        Me.lblcurrent.TabIndex = 36
        Me.lblcurrent.Text = "password did match from current password"
        '
        'lblrepass
        '
        Me.lblrepass.AutoSize = True
        Me.lblrepass.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrepass.ForeColor = System.Drawing.Color.Red
        Me.lblrepass.Location = New System.Drawing.Point(186, 255)
        Me.lblrepass.Name = "lblrepass"
        Me.lblrepass.Size = New System.Drawing.Size(102, 13)
        Me.lblrepass.TabIndex = 37
        Me.lblrepass.Text = "password did match"
        '
        'btneye
        '
        Me.btneye.Image = Global.usermanagement.My.Resources.Resources.eye
        Me.btneye.ImageActive = Nothing
        Me.btneye.Location = New System.Drawing.Point(443, 91)
        Me.btneye.Name = "btneye"
        Me.btneye.Size = New System.Drawing.Size(35, 25)
        Me.btneye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btneye.TabIndex = 38
        Me.btneye.TabStop = False
        Me.btneye.Zoom = 10
        '
        'UserChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 376)
        Me.Controls.Add(Me.btneye)
        Me.Controls.Add(Me.lblrepass)
        Me.Controls.Add(Me.lblcurrent)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnchangepassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtrepassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcurrentpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btneye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtnewpassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcurrentpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtrepassword As TextBox
    Friend WithEvents btnclose As LinkLabel
    Friend WithEvents btnchangepassword As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblcurrent As Label
    Friend WithEvents lblrepass As Label
    Friend WithEvents btneye As Bunifu.Framework.UI.BunifuImageButton
End Class
