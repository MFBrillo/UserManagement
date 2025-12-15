<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditUser
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
        Me.txtoffice = New System.Windows.Forms.TextBox()
        Me.dgvOffice = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.LinkLabel()
        Me.txtrepassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmiddlename = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.txtport = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblclose = New System.Windows.Forms.LinkLabel()
        Me.btnchangepassword = New System.Windows.Forms.Button()
        CType(Me.dgvOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtoffice
        '
        Me.txtoffice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtoffice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtoffice.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtoffice.Location = New System.Drawing.Point(19, 99)
        Me.txtoffice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Size = New System.Drawing.Size(596, 23)
        Me.txtoffice.TabIndex = 1
        '
        'dgvOffice
        '
        Me.dgvOffice.AllowUserToAddRows = False
        Me.dgvOffice.AllowUserToDeleteRows = False
        Me.dgvOffice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOffice.BackgroundColor = System.Drawing.Color.White
        Me.dgvOffice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOffice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOffice.ColumnHeadersVisible = False
        Me.dgvOffice.Location = New System.Drawing.Point(19, 123)
        Me.dgvOffice.Name = "dgvOffice"
        Me.dgvOffice.ReadOnly = True
        Me.dgvOffice.RowHeadersVisible = False
        Me.dgvOffice.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgvOffice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOffice.Size = New System.Drawing.Size(596, 102)
        Me.dgvOffice.TabIndex = 1
        Me.dgvOffice.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 56)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Edit Verified User"
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
        'btnclose
        '
        Me.btnclose.AutoSize = True
        Me.btnclose.Location = New System.Drawing.Point(589, 491)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(33, 13)
        Me.btnclose.TabIndex = 10
        Me.btnclose.TabStop = True
        Me.btnclose.Text = "Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtrepassword
        '
        Me.txtrepassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtrepassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrepassword.Enabled = False
        Me.txtrepassword.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtrepassword.Location = New System.Drawing.Point(324, 341)
        Me.txtrepassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtrepassword.Name = "txtrepassword"
        Me.txtrepassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtrepassword.Size = New System.Drawing.Size(291, 23)
        Me.txtrepassword.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(321, 322)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Retype Password"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtposition.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtposition.Location = New System.Drawing.Point(19, 341)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(2)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(288, 23)
        Me.txtposition.TabIndex = 5
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpassword.Enabled = False
        Me.txtpassword.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtpassword.Location = New System.Drawing.Point(324, 284)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(291, 23)
        Me.txtpassword.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 324)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Position"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(322, 267)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Password"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtusername.Location = New System.Drawing.Point(321, 153)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(291, 23)
        Me.txtusername.TabIndex = 6
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlastname.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtlastname.Location = New System.Drawing.Point(19, 281)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(288, 23)
        Me.txtlastname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(319, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(24, 423)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(290, 37)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Lastname"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmiddlename
        '
        Me.txtmiddlename.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtmiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmiddlename.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtmiddlename.Location = New System.Drawing.Point(19, 219)
        Me.txtmiddlename.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(288, 23)
        Me.txtmiddlename.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Middlename"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 82)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Office"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfirstname.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtfirstname.Location = New System.Drawing.Point(19, 153)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(288, 23)
        Me.txtfirstname.TabIndex = 2
        '
        'txtport
        '
        Me.txtport.AutoSize = True
        Me.txtport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtport.Location = New System.Drawing.Point(19, 136)
        Me.txtport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(54, 13)
        Me.txtport.TabIndex = 30
        Me.txtport.Text = "Firstname"
        Me.txtport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblStatus)
        Me.Panel2.Controls.Add(Me.txtrepassword)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtpassword)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblclose)
        Me.Panel2.Controls.Add(Me.txtoffice)
        Me.Panel2.Controls.Add(Me.dgvOffice)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.txtposition)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Controls.Add(Me.txtlastname)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnUpdate)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtmiddlename)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtfirstname)
        Me.Panel2.Controls.Add(Me.txtport)
        Me.Panel2.Controls.Add(Me.btnchangepassword)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 484)
        Me.Panel2.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(491, 234)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(113, 13)
        Me.lblStatus.TabIndex = 39
        Me.lblStatus.Text = "Not Change Password"
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.Location = New System.Drawing.Point(589, 462)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(33, 13)
        Me.lblclose.TabIndex = 37
        Me.lblclose.TabStop = True
        Me.lblclose.Text = "Close"
        Me.lblclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnchangepassword
        '
        Me.btnchangepassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangepassword.Location = New System.Drawing.Point(322, 214)
        Me.btnchangepassword.Name = "btnchangepassword"
        Me.btnchangepassword.Size = New System.Drawing.Size(162, 34)
        Me.btnchangepassword.TabIndex = 38
        Me.btnchangepassword.Text = "Change Password"
        Me.btnchangepassword.UseVisualStyleBackColor = True
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 484)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvOffice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtoffice As TextBox
    Friend WithEvents dgvOffice As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnclose As LinkLabel
    Friend WithEvents txtrepassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtposition As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtmiddlename As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents txtport As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblclose As LinkLabel
    Friend WithEvents btnchangepassword As Button
    Friend WithEvents lblStatus As Label
End Class
