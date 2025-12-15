<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditVerifiedUser
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnchangepassword = New System.Windows.Forms.Button()
        Me.lblclose = New System.Windows.Forms.LinkLabel()
        Me.txtoffice = New System.Windows.Forms.TextBox()
        Me.dgvOffice = New System.Windows.Forms.DataGridView()
        Me.txtposition = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.cbbaccesslevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvOffice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Edit User"
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
        'btnchangepassword
        '
        Me.btnchangepassword.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangepassword.Location = New System.Drawing.Point(321, 205)
        Me.btnchangepassword.Name = "btnchangepassword"
        Me.btnchangepassword.Size = New System.Drawing.Size(290, 34)
        Me.btnchangepassword.TabIndex = 60
        Me.btnchangepassword.Text = "Change Password"
        Me.btnchangepassword.UseVisualStyleBackColor = True
        '
        'lblclose
        '
        Me.lblclose.AutoSize = True
        Me.lblclose.Location = New System.Drawing.Point(588, 458)
        Me.lblclose.Name = "lblclose"
        Me.lblclose.Size = New System.Drawing.Size(33, 13)
        Me.lblclose.TabIndex = 59
        Me.lblclose.TabStop = True
        Me.lblclose.Text = "Close"
        Me.lblclose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtoffice
        '
        Me.txtoffice.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtoffice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtoffice.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtoffice.Location = New System.Drawing.Point(18, 95)
        Me.txtoffice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtoffice.Name = "txtoffice"
        Me.txtoffice.Size = New System.Drawing.Size(596, 23)
        Me.txtoffice.TabIndex = 41
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
        Me.dgvOffice.Location = New System.Drawing.Point(18, 119)
        Me.dgvOffice.Name = "dgvOffice"
        Me.dgvOffice.ReadOnly = True
        Me.dgvOffice.RowHeadersVisible = False
        Me.dgvOffice.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dgvOffice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOffice.Size = New System.Drawing.Size(596, 102)
        Me.dgvOffice.TabIndex = 42
        Me.dgvOffice.Visible = False
        '
        'txtposition
        '
        Me.txtposition.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtposition.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtposition.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtposition.Location = New System.Drawing.Point(18, 337)
        Me.txtposition.Margin = New System.Windows.Forms.Padding(2)
        Me.txtposition.Name = "txtposition"
        Me.txtposition.Size = New System.Drawing.Size(288, 23)
        Me.txtposition.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 320)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Position"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtusername.Location = New System.Drawing.Point(320, 149)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(2)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(291, 23)
        Me.txtusername.TabIndex = 47
        '
        'txtlastname
        '
        Me.txtlastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtlastname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlastname.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtlastname.Location = New System.Drawing.Point(18, 277)
        Me.txtlastname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(288, 23)
        Me.txtlastname.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(318, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 52
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
        Me.btnUpdate.Location = New System.Drawing.Point(16, 423)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(290, 37)
        Me.btnUpdate.TabIndex = 50
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 260)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Lastname"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtmiddlename
        '
        Me.txtmiddlename.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtmiddlename.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmiddlename.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtmiddlename.Location = New System.Drawing.Point(18, 215)
        Me.txtmiddlename.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmiddlename.Name = "txtmiddlename"
        Me.txtmiddlename.Size = New System.Drawing.Size(288, 23)
        Me.txtmiddlename.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 198)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Middlename"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Office"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtfirstname
        '
        Me.txtfirstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtfirstname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtfirstname.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txtfirstname.Location = New System.Drawing.Point(18, 149)
        Me.txtfirstname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(288, 23)
        Me.txtfirstname.TabIndex = 43
        '
        'txtport
        '
        Me.txtport.AutoSize = True
        Me.txtport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtport.Location = New System.Drawing.Point(18, 132)
        Me.txtport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtport.Name = "txtport"
        Me.txtport.Size = New System.Drawing.Size(54, 13)
        Me.txtport.TabIndex = 53
        Me.txtport.Text = "Firstname"
        Me.txtport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbbaccesslevel
        '
        Me.cbbaccesslevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cbbaccesslevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbaccesslevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbbaccesslevel.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.cbbaccesslevel.FormattingEnabled = True
        Me.cbbaccesslevel.Location = New System.Drawing.Point(321, 274)
        Me.cbbaccesslevel.Name = "cbbaccesslevel"
        Me.cbbaccesslevel.Size = New System.Drawing.Size(290, 27)
        Me.cbbaccesslevel.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Access Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EditVerifiedUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 484)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbbaccesslevel)
        Me.Controls.Add(Me.lblclose)
        Me.Controls.Add(Me.txtoffice)
        Me.Controls.Add(Me.dgvOffice)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtmiddlename)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.txtport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnchangepassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditVerifiedUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditVerifiedUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvOffice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnchangepassword As Button
    Friend WithEvents lblclose As LinkLabel
    Friend WithEvents txtoffice As TextBox
    Friend WithEvents dgvOffice As DataGridView
    Friend WithEvents txtposition As TextBox
    Friend WithEvents Label6 As Label
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
    Friend WithEvents cbbaccesslevel As ComboBox
    Friend WithEvents Label2 As Label
End Class
