<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagement))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnverifieduser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnnewuser = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 784)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnverifieduser)
        Me.Panel2.Controls.Add(Me.btnnewuser)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 784)
        Me.Panel2.TabIndex = 1
        '
        'btnverifieduser
        '
        Me.btnverifieduser.Active = False
        Me.btnverifieduser.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnverifieduser.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnverifieduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnverifieduser.BorderRadius = 0
        Me.btnverifieduser.ButtonText = "    Verified User"
        Me.btnverifieduser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnverifieduser.DisabledColor = System.Drawing.Color.Gray
        Me.btnverifieduser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnverifieduser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnverifieduser.Iconimage = Global.usermanagement.My.Resources.Resources.User_Setting
        Me.btnverifieduser.Iconimage_right = Nothing
        Me.btnverifieduser.Iconimage_right_Selected = Nothing
        Me.btnverifieduser.Iconimage_Selected = Nothing
        Me.btnverifieduser.IconMarginLeft = 30
        Me.btnverifieduser.IconMarginRight = 0
        Me.btnverifieduser.IconRightVisible = True
        Me.btnverifieduser.IconRightZoom = 0R
        Me.btnverifieduser.IconVisible = True
        Me.btnverifieduser.IconZoom = 50.0R
        Me.btnverifieduser.IsTab = False
        Me.btnverifieduser.Location = New System.Drawing.Point(0, 311)
        Me.btnverifieduser.Name = "btnverifieduser"
        Me.btnverifieduser.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnverifieduser.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnverifieduser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnverifieduser.selected = False
        Me.btnverifieduser.Size = New System.Drawing.Size(200, 48)
        Me.btnverifieduser.TabIndex = 8
        Me.btnverifieduser.Text = "    Verified User"
        Me.btnverifieduser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnverifieduser.Textcolor = System.Drawing.Color.White
        Me.btnverifieduser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnverifieduser.Visible = False
        '
        'btnnewuser
        '
        Me.btnnewuser.Active = False
        Me.btnnewuser.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnnewuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnnewuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnewuser.BorderRadius = 0
        Me.btnnewuser.ButtonText = "    New User"
        Me.btnnewuser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnnewuser.DisabledColor = System.Drawing.Color.Gray
        Me.btnnewuser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnnewuser.Iconcolor = System.Drawing.Color.Transparent
        Me.btnnewuser.Iconimage = Global.usermanagement.My.Resources.Resources.User_Setting
        Me.btnnewuser.Iconimage_right = Nothing
        Me.btnnewuser.Iconimage_right_Selected = Nothing
        Me.btnnewuser.Iconimage_Selected = Nothing
        Me.btnnewuser.IconMarginLeft = 30
        Me.btnnewuser.IconMarginRight = 0
        Me.btnnewuser.IconRightVisible = True
        Me.btnnewuser.IconRightZoom = 0R
        Me.btnnewuser.IconVisible = True
        Me.btnnewuser.IconZoom = 50.0R
        Me.btnnewuser.IsTab = False
        Me.btnnewuser.Location = New System.Drawing.Point(0, 263)
        Me.btnnewuser.Name = "btnnewuser"
        Me.btnnewuser.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnnewuser.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnnewuser.OnHoverTextColor = System.Drawing.Color.White
        Me.btnnewuser.selected = False
        Me.btnnewuser.Size = New System.Drawing.Size(200, 48)
        Me.btnnewuser.TabIndex = 7
        Me.btnnewuser.Text = "    New User"
        Me.btnnewuser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnnewuser.Textcolor = System.Drawing.Color.White
        Me.btnnewuser.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 263)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(39, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MANAGEMENT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USER"
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(205, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(915, 784)
        Me.MainPanel.TabIndex = 0
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "UserManagement"
        Me.Size = New System.Drawing.Size(1120, 784)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainPanel As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnverifieduser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnnewuser As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
