<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AcceptForm
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
        Me.cbTerms = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.cbPolicy = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.lblprivacy = New System.Windows.Forms.LinkLabel()
        Me.lblterms = New System.Windows.Forms.LinkLabel()
        Me.cbAll = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnregister = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTerms
        '
        Me.cbTerms.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbTerms.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbTerms.Checked = False
        Me.cbTerms.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cbTerms.ForeColor = System.Drawing.Color.White
        Me.cbTerms.Location = New System.Drawing.Point(62, 179)
        Me.cbTerms.Name = "cbTerms"
        Me.cbTerms.Size = New System.Drawing.Size(20, 20)
        Me.cbTerms.TabIndex = 45
        '
        'cbPolicy
        '
        Me.cbPolicy.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbPolicy.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbPolicy.Checked = False
        Me.cbPolicy.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cbPolicy.ForeColor = System.Drawing.Color.White
        Me.cbPolicy.Location = New System.Drawing.Point(62, 137)
        Me.cbPolicy.Name = "cbPolicy"
        Me.cbPolicy.Size = New System.Drawing.Size(20, 20)
        Me.cbPolicy.TabIndex = 44
        '
        'lblprivacy
        '
        Me.lblprivacy.AutoSize = True
        Me.lblprivacy.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprivacy.LinkColor = System.Drawing.Color.Black
        Me.lblprivacy.Location = New System.Drawing.Point(191, 137)
        Me.lblprivacy.Name = "lblprivacy"
        Me.lblprivacy.Size = New System.Drawing.Size(121, 19)
        Me.lblprivacy.TabIndex = 43
        Me.lblprivacy.TabStop = True
        Me.lblprivacy.Text = "Privacy Policy"
        Me.lblprivacy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblterms
        '
        Me.lblterms.AutoSize = True
        Me.lblterms.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblterms.LinkColor = System.Drawing.Color.Black
        Me.lblterms.Location = New System.Drawing.Point(164, 178)
        Me.lblterms.Name = "lblterms"
        Me.lblterms.Size = New System.Drawing.Size(186, 19)
        Me.lblterms.TabIndex = 42
        Me.lblterms.TabStop = True
        Me.lblterms.Text = "Terms and Conditions"
        Me.lblterms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbAll
        '
        Me.cbAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbAll.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbAll.Checked = False
        Me.cbAll.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cbAll.ForeColor = System.Drawing.Color.White
        Me.cbAll.Location = New System.Drawing.Point(62, 225)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(20, 20)
        Me.cbAll.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "provided by the compony."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 19)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "I agree to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "I agree to the"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 56)
        Me.Panel1.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Registry"
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
        'btnregister
        '
        Me.btnregister.BackColor = System.Drawing.Color.DarkCyan
        Me.btnregister.FlatAppearance.BorderSize = 0
        Me.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnregister.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnregister.ForeColor = System.Drawing.Color.White
        Me.btnregister.Location = New System.Drawing.Point(460, 321)
        Me.btnregister.Margin = New System.Windows.Forms.Padding(2)
        Me.btnregister.Name = "btnregister"
        Me.btnregister.Size = New System.Drawing.Size(175, 37)
        Me.btnregister.TabIndex = 52
        Me.btnregister.Text = "Create"
        Me.btnregister.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(350, 321)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 37)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Accept All"
        '
        'AcceptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 376)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnregister)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbAll)
        Me.Controls.Add(Me.cbTerms)
        Me.Controls.Add(Me.cbPolicy)
        Me.Controls.Add(Me.lblprivacy)
        Me.Controls.Add(Me.lblterms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AcceptForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUserAcceptForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTerms As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents cbPolicy As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents lblprivacy As LinkLabel
    Friend WithEvents lblterms As LinkLabel
    Friend WithEvents cbAll As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnregister As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class
