<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class usersetting
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtemail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnchangepassword = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtjobposition = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtusername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtoffice = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlastname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtfirstname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtmiddlename = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 39)
        Me.Panel1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "User Information Setting"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(10, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 240)
        Me.Panel2.TabIndex = 4
        '
        'BunifuCards1
        '
        Me.BunifuCards1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 10
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.White
        Me.BunifuCards1.Controls.Add(Me.txtemail)
        Me.BunifuCards1.Controls.Add(Me.Label6)
        Me.BunifuCards1.Controls.Add(Me.btnchangepassword)
        Me.BunifuCards1.Controls.Add(Me.btnUpdate)
        Me.BunifuCards1.Controls.Add(Me.txtjobposition)
        Me.BunifuCards1.Controls.Add(Me.Label7)
        Me.BunifuCards1.Controls.Add(Me.txtusername)
        Me.BunifuCards1.Controls.Add(Me.Label5)
        Me.BunifuCards1.Controls.Add(Me.txtoffice)
        Me.BunifuCards1.Controls.Add(Me.Label4)
        Me.BunifuCards1.Controls.Add(Me.txtlastname)
        Me.BunifuCards1.Controls.Add(Me.txtfirstname)
        Me.BunifuCards1.Controls.Add(Me.txtmiddlename)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(94, 113)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 50
        Me.BunifuCards1.Size = New System.Drawing.Size(722, 762)
        Me.BunifuCards1.TabIndex = 35
        '
        'txtemail
        '
        Me.txtemail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtemail.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtemail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemail.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtemail.BorderThickness = 1
        Me.txtemail.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemail.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemail.isPassword = False
        Me.txtemail.Location = New System.Drawing.Point(84, 432)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.MaxLength = 32767
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtemail.Size = New System.Drawing.Size(571, 33)
        Me.txtemail.TabIndex = 62
        Me.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(83, 409)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Email"
        '
        'btnchangepassword
        '
        Me.btnchangepassword.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnchangepassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnchangepassword.FlatAppearance.BorderSize = 0
        Me.btnchangepassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchangepassword.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnchangepassword.ForeColor = System.Drawing.Color.White
        Me.btnchangepassword.Location = New System.Drawing.Point(81, 149)
        Me.btnchangepassword.Margin = New System.Windows.Forms.Padding(2)
        Me.btnchangepassword.Name = "btnchangepassword"
        Me.btnchangepassword.Size = New System.Drawing.Size(571, 37)
        Me.btnchangepassword.TabIndex = 2
        Me.btnchangepassword.Text = "Change Password"
        Me.btnchangepassword.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(81, 684)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(571, 37)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtjobposition
        '
        Me.txtjobposition.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtjobposition.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtjobposition.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtjobposition.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtjobposition.BorderThickness = 1
        Me.txtjobposition.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtjobposition.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtjobposition.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtjobposition.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtjobposition.isPassword = False
        Me.txtjobposition.Location = New System.Drawing.Point(84, 587)
        Me.txtjobposition.Margin = New System.Windows.Forms.Padding(4)
        Me.txtjobposition.MaxLength = 32767
        Me.txtjobposition.Name = "txtjobposition"
        Me.txtjobposition.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtjobposition.Size = New System.Drawing.Size(571, 33)
        Me.txtjobposition.TabIndex = 7
        Me.txtjobposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(80, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 19)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Job Position"
        '
        'txtusername
        '
        Me.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtusername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtusername.BorderColorFocused = System.Drawing.Color.Red
        Me.txtusername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.BorderColorMouseHover = System.Drawing.Color.Red
        Me.txtusername.BorderThickness = 1
        Me.txtusername.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtusername.Enabled = False
        Me.txtusername.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtusername.isPassword = False
        Me.txtusername.Location = New System.Drawing.Point(81, 98)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtusername.Size = New System.Drawing.Size(571, 33)
        Me.txtusername.TabIndex = 1
        Me.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(77, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Username"
        '
        'txtoffice
        '
        Me.txtoffice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtoffice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtoffice.BorderColorFocused = System.Drawing.Color.Red
        Me.txtoffice.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoffice.BorderColorMouseHover = System.Drawing.Color.Red
        Me.txtoffice.BorderThickness = 1
        Me.txtoffice.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtoffice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoffice.Enabled = False
        Me.txtoffice.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtoffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoffice.isPassword = False
        Me.txtoffice.Location = New System.Drawing.Point(84, 527)
        Me.txtoffice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtoffice.MaxLength = 32767
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtoffice.Size = New System.Drawing.Size(571, 33)
        Me.txtoffice.TabIndex = 6
        Me.txtoffice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(80, 504)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Office"
        '
        'txtlastname
        '
        Me.txtlastname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtlastname.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtlastname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtlastname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtlastname.BorderThickness = 1
        Me.txtlastname.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtlastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtlastname.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtlastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtlastname.isPassword = False
        Me.txtlastname.Location = New System.Drawing.Point(81, 372)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtlastname.MaxLength = 32767
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtlastname.Size = New System.Drawing.Size(571, 33)
        Me.txtlastname.TabIndex = 5
        Me.txtlastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtfirstname
        '
        Me.txtfirstname.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtfirstname.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtfirstname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtfirstname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtfirstname.BorderThickness = 1
        Me.txtfirstname.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtfirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfirstname.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtfirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtfirstname.isPassword = False
        Me.txtfirstname.Location = New System.Drawing.Point(81, 247)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfirstname.MaxLength = 32767
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtfirstname.Size = New System.Drawing.Size(571, 33)
        Me.txtfirstname.TabIndex = 3
        Me.txtfirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtmiddlename
        '
        Me.txtmiddlename.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtmiddlename.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtmiddlename.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmiddlename.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtmiddlename.BorderThickness = 1
        Me.txtmiddlename.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtmiddlename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmiddlename.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmiddlename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtmiddlename.isPassword = False
        Me.txtmiddlename.Location = New System.Drawing.Point(81, 308)
        Me.txtmiddlename.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtmiddlename.MaxLength = 32767
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtmiddlename.Size = New System.Drawing.Size(571, 33)
        Me.txtmiddlename.TabIndex = 4
        Me.txtmiddlename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(80, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Lastname"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(80, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Firstname"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(80, 284)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 19)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Middlename"
        '
        'usersetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "usersetting"
        Me.Size = New System.Drawing.Size(905, 894)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents txtoffice As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtlastname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtfirstname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtmiddlename As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtjobposition As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnchangepassword As Button
    Friend WithEvents txtemail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
End Class
