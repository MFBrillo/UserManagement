<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminInfo
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
        Me.txtcontact = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtemailaddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtofficename = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtofficeaddress = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.dtpEffectiveDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCards1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcontact
        '
        Me.txtcontact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcontact.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtcontact.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcontact.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtcontact.BorderThickness = 1
        Me.txtcontact.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtcontact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontact.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcontact.isPassword = False
        Me.txtcontact.Location = New System.Drawing.Point(81, 331)
        Me.txtcontact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontact.MaxLength = 32767
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtcontact.Size = New System.Drawing.Size(571, 33)
        Me.txtcontact.TabIndex = 4
        Me.txtcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl3
        '
        Me.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl3.AutoSize = True
        Me.lbl3.BackColor = System.Drawing.Color.Transparent
        Me.lbl3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(80, 308)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(141, 19)
        Me.lbl3.TabIndex = 63
        Me.lbl3.Text = "Contact Number"
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(81, 535)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(571, 37)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'txtemailaddress
        '
        Me.txtemailaddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtemailaddress.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtemailaddress.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemailaddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtemailaddress.BorderThickness = 1
        Me.txtemailaddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtemailaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemailaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtemailaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemailaddress.isPassword = False
        Me.txtemailaddress.Location = New System.Drawing.Point(81, 239)
        Me.txtemailaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemailaddress.MaxLength = 32767
        Me.txtemailaddress.Name = "txtemailaddress"
        Me.txtemailaddress.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtemailaddress.Size = New System.Drawing.Size(571, 33)
        Me.txtemailaddress.TabIndex = 3
        Me.txtemailaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtofficename
        '
        Me.txtofficename.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtofficename.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtofficename.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtofficename.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtofficename.BorderThickness = 1
        Me.txtofficename.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtofficename.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtofficename.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtofficename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtofficename.isPassword = False
        Me.txtofficename.Location = New System.Drawing.Point(81, 66)
        Me.txtofficename.Margin = New System.Windows.Forms.Padding(4)
        Me.txtofficename.MaxLength = 32767
        Me.txtofficename.Name = "txtofficename"
        Me.txtofficename.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtofficename.Size = New System.Drawing.Size(571, 33)
        Me.txtofficename.TabIndex = 1
        Me.txtofficename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtofficeaddress
        '
        Me.txtofficeaddress.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtofficeaddress.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtofficeaddress.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtofficeaddress.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtofficeaddress.BorderThickness = 1
        Me.txtofficeaddress.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtofficeaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtofficeaddress.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtofficeaddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtofficeaddress.isPassword = False
        Me.txtofficeaddress.Location = New System.Drawing.Point(81, 151)
        Me.txtofficeaddress.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtofficeaddress.MaxLength = 32767
        Me.txtofficeaddress.Name = "txtofficeaddress"
        Me.txtofficeaddress.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.txtofficeaddress.Size = New System.Drawing.Size(571, 33)
        Me.txtofficeaddress.TabIndex = 2
        Me.txtofficeaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lbl2
        '
        Me.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl2.AutoSize = True
        Me.lbl2.BackColor = System.Drawing.Color.Transparent
        Me.lbl2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Black
        Me.lbl2.Location = New System.Drawing.Point(80, 216)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(124, 19)
        Me.lbl2.TabIndex = 46
        Me.lbl2.Text = "Email Address"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(80, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Office Name"
        '
        'lbl1
        '
        Me.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl1.AutoSize = True
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(80, 127)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(126, 19)
        Me.lbl1.TabIndex = 42
        Me.lbl1.Text = "Office Address"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(269, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Data Protection Officer Settings"
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
        Me.BunifuCards1.Controls.Add(Me.dtpEffectiveDate)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.Controls.Add(Me.txtcontact)
        Me.BunifuCards1.Controls.Add(Me.lbl3)
        Me.BunifuCards1.Controls.Add(Me.btnUpdate)
        Me.BunifuCards1.Controls.Add(Me.txtemailaddress)
        Me.BunifuCards1.Controls.Add(Me.txtofficename)
        Me.BunifuCards1.Controls.Add(Me.txtofficeaddress)
        Me.BunifuCards1.Controls.Add(Me.lbl2)
        Me.BunifuCards1.Controls.Add(Me.Label2)
        Me.BunifuCards1.Controls.Add(Me.lbl1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(94, 123)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 50
        Me.BunifuCards1.Size = New System.Drawing.Size(722, 762)
        Me.BunifuCards1.TabIndex = 38
        '
        'dtpEffectiveDate
        '
        Me.dtpEffectiveDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dtpEffectiveDate.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.dtpEffectiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEffectiveDate.Location = New System.Drawing.Point(81, 427)
        Me.dtpEffectiveDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEffectiveDate.Name = "dtpEffectiveDate"
        Me.dtpEffectiveDate.Size = New System.Drawing.Size(571, 27)
        Me.dtpEffectiveDate.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(80, 405)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Effective Date"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(10, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 240)
        Me.Panel2.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 39)
        Me.Panel1.TabIndex = 36
        '
        'AdminInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminInfo"
        Me.Size = New System.Drawing.Size(905, 894)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtcontact As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtemailaddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtofficename As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtofficeaddress As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents lbl2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpEffectiveDate As DateTimePicker
End Class
