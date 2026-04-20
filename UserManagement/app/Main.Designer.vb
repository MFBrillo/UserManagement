<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnPr = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUserSetting = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdminSetting = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSignOut = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnChangeSign = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUserManagment = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(212, 755)
        Me.Panel1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnPr)
        Me.Panel5.Controls.Add(Me.btnUserSetting)
        Me.Panel5.Controls.Add(Me.btnAdminSetting)
        Me.Panel5.Controls.Add(Me.btnSignOut)
        Me.Panel5.Controls.Add(Me.btnChangeSign)
        Me.Panel5.Controls.Add(Me.btnUserManagment)
        Me.Panel5.Controls.Add(Me.btnDashboard)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 129)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(212, 577)
        Me.Panel5.TabIndex = 2
        '
        'btnPr
        '
        Me.btnPr.Active = False
        Me.btnPr.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnPr.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPr.BorderRadius = 0
        Me.btnPr.ButtonText = "     Purchase Request"
        Me.btnPr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPr.DisabledColor = System.Drawing.Color.Gray
        Me.btnPr.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPr.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPr.Iconimage = CType(resources.GetObject("btnPr.Iconimage"), System.Drawing.Image)
        Me.btnPr.Iconimage_right = Nothing
        Me.btnPr.Iconimage_right_Selected = Nothing
        Me.btnPr.Iconimage_Selected = Nothing
        Me.btnPr.IconMarginLeft = 30
        Me.btnPr.IconMarginRight = 0
        Me.btnPr.IconRightVisible = True
        Me.btnPr.IconRightZoom = 0R
        Me.btnPr.IconVisible = True
        Me.btnPr.IconZoom = 50.0R
        Me.btnPr.IsTab = False
        Me.btnPr.Location = New System.Drawing.Point(0, 144)
        Me.btnPr.Name = "btnPr"
        Me.btnPr.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnPr.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnPr.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPr.selected = False
        Me.btnPr.Size = New System.Drawing.Size(212, 48)
        Me.btnPr.TabIndex = 11
        Me.btnPr.Text = "     Purchase Request"
        Me.btnPr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPr.Textcolor = System.Drawing.Color.White
        Me.btnPr.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUserSetting
        '
        Me.btnUserSetting.Active = False
        Me.btnUserSetting.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnUserSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUserSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserSetting.BorderRadius = 0
        Me.btnUserSetting.ButtonText = "     User Setting"
        Me.btnUserSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserSetting.DisabledColor = System.Drawing.Color.Gray
        Me.btnUserSetting.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnUserSetting.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUserSetting.Iconimage = Global.usermanagement.My.Resources.Resources.usersetting
        Me.btnUserSetting.Iconimage_right = Nothing
        Me.btnUserSetting.Iconimage_right_Selected = Nothing
        Me.btnUserSetting.Iconimage_Selected = Nothing
        Me.btnUserSetting.IconMarginLeft = 30
        Me.btnUserSetting.IconMarginRight = 0
        Me.btnUserSetting.IconRightVisible = True
        Me.btnUserSetting.IconRightZoom = 0R
        Me.btnUserSetting.IconVisible = True
        Me.btnUserSetting.IconZoom = 50.0R
        Me.btnUserSetting.IsTab = False
        Me.btnUserSetting.Location = New System.Drawing.Point(0, 433)
        Me.btnUserSetting.Name = "btnUserSetting"
        Me.btnUserSetting.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUserSetting.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnUserSetting.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUserSetting.selected = False
        Me.btnUserSetting.Size = New System.Drawing.Size(212, 48)
        Me.btnUserSetting.TabIndex = 10
        Me.btnUserSetting.Text = "     User Setting"
        Me.btnUserSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserSetting.Textcolor = System.Drawing.Color.White
        Me.btnUserSetting.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserSetting.Visible = False
        '
        'btnAdminSetting
        '
        Me.btnAdminSetting.Active = False
        Me.btnAdminSetting.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnAdminSetting.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAdminSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdminSetting.BorderRadius = 0
        Me.btnAdminSetting.ButtonText = "     Admin Setting"
        Me.btnAdminSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdminSetting.DisabledColor = System.Drawing.Color.Gray
        Me.btnAdminSetting.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAdminSetting.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdminSetting.Iconimage = Global.usermanagement.My.Resources.Resources.setting
        Me.btnAdminSetting.Iconimage_right = Nothing
        Me.btnAdminSetting.Iconimage_right_Selected = Nothing
        Me.btnAdminSetting.Iconimage_Selected = Nothing
        Me.btnAdminSetting.IconMarginLeft = 30
        Me.btnAdminSetting.IconMarginRight = 0
        Me.btnAdminSetting.IconRightVisible = True
        Me.btnAdminSetting.IconRightZoom = 0R
        Me.btnAdminSetting.IconVisible = True
        Me.btnAdminSetting.IconZoom = 50.0R
        Me.btnAdminSetting.IsTab = False
        Me.btnAdminSetting.Location = New System.Drawing.Point(0, 481)
        Me.btnAdminSetting.Name = "btnAdminSetting"
        Me.btnAdminSetting.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnAdminSetting.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnAdminSetting.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdminSetting.selected = False
        Me.btnAdminSetting.Size = New System.Drawing.Size(212, 48)
        Me.btnAdminSetting.TabIndex = 9
        Me.btnAdminSetting.Text = "     Admin Setting"
        Me.btnAdminSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdminSetting.Textcolor = System.Drawing.Color.White
        Me.btnAdminSetting.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdminSetting.Visible = False
        '
        'btnSignOut
        '
        Me.btnSignOut.Active = False
        Me.btnSignOut.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnSignOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSignOut.BorderRadius = 0
        Me.btnSignOut.ButtonText = "     Sign Out"
        Me.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSignOut.DisabledColor = System.Drawing.Color.Gray
        Me.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSignOut.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSignOut.Iconimage = Global.usermanagement.My.Resources.Resources.signout
        Me.btnSignOut.Iconimage_right = Nothing
        Me.btnSignOut.Iconimage_right_Selected = Nothing
        Me.btnSignOut.Iconimage_Selected = Nothing
        Me.btnSignOut.IconMarginLeft = 30
        Me.btnSignOut.IconMarginRight = 0
        Me.btnSignOut.IconRightVisible = True
        Me.btnSignOut.IconRightZoom = 0R
        Me.btnSignOut.IconVisible = True
        Me.btnSignOut.IconZoom = 50.0R
        Me.btnSignOut.IsTab = False
        Me.btnSignOut.Location = New System.Drawing.Point(0, 529)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnSignOut.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnSignOut.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSignOut.selected = False
        Me.btnSignOut.Size = New System.Drawing.Size(212, 48)
        Me.btnSignOut.TabIndex = 8
        Me.btnSignOut.Text = "     Sign Out"
        Me.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSignOut.Textcolor = System.Drawing.Color.White
        Me.btnSignOut.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnChangeSign
        '
        Me.btnChangeSign.Active = False
        Me.btnChangeSign.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnChangeSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnChangeSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeSign.BorderRadius = 0
        Me.btnChangeSign.ButtonText = "     Change Signatory"
        Me.btnChangeSign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChangeSign.DisabledColor = System.Drawing.Color.Gray
        Me.btnChangeSign.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnChangeSign.Iconcolor = System.Drawing.Color.Transparent
        Me.btnChangeSign.Iconimage = CType(resources.GetObject("btnChangeSign.Iconimage"), System.Drawing.Image)
        Me.btnChangeSign.Iconimage_right = Nothing
        Me.btnChangeSign.Iconimage_right_Selected = Nothing
        Me.btnChangeSign.Iconimage_Selected = Nothing
        Me.btnChangeSign.IconMarginLeft = 30
        Me.btnChangeSign.IconMarginRight = 0
        Me.btnChangeSign.IconRightVisible = True
        Me.btnChangeSign.IconRightZoom = 0R
        Me.btnChangeSign.IconVisible = True
        Me.btnChangeSign.IconZoom = 50.0R
        Me.btnChangeSign.IsTab = False
        Me.btnChangeSign.Location = New System.Drawing.Point(0, 96)
        Me.btnChangeSign.Name = "btnChangeSign"
        Me.btnChangeSign.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnChangeSign.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnChangeSign.OnHoverTextColor = System.Drawing.Color.White
        Me.btnChangeSign.selected = False
        Me.btnChangeSign.Size = New System.Drawing.Size(212, 48)
        Me.btnChangeSign.TabIndex = 7
        Me.btnChangeSign.Text = "     Change Signatory"
        Me.btnChangeSign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChangeSign.Textcolor = System.Drawing.Color.White
        Me.btnChangeSign.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeSign.Visible = False
        '
        'btnUserManagment
        '
        Me.btnUserManagment.Active = False
        Me.btnUserManagment.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnUserManagment.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUserManagment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserManagment.BorderRadius = 0
        Me.btnUserManagment.ButtonText = "    User Management"
        Me.btnUserManagment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserManagment.DisabledColor = System.Drawing.Color.Gray
        Me.btnUserManagment.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserManagment.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUserManagment.Iconimage = Global.usermanagement.My.Resources.Resources.User_Setting
        Me.btnUserManagment.Iconimage_right = Nothing
        Me.btnUserManagment.Iconimage_right_Selected = Nothing
        Me.btnUserManagment.Iconimage_Selected = Nothing
        Me.btnUserManagment.IconMarginLeft = 30
        Me.btnUserManagment.IconMarginRight = 0
        Me.btnUserManagment.IconRightVisible = True
        Me.btnUserManagment.IconRightZoom = 0R
        Me.btnUserManagment.IconVisible = True
        Me.btnUserManagment.IconZoom = 50.0R
        Me.btnUserManagment.IsTab = False
        Me.btnUserManagment.Location = New System.Drawing.Point(0, 48)
        Me.btnUserManagment.Name = "btnUserManagment"
        Me.btnUserManagment.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnUserManagment.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnUserManagment.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUserManagment.selected = False
        Me.btnUserManagment.Size = New System.Drawing.Size(212, 48)
        Me.btnUserManagment.TabIndex = 6
        Me.btnUserManagment.Text = "    User Management"
        Me.btnUserManagment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagment.Textcolor = System.Drawing.Color.White
        Me.btnUserManagment.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagment.Visible = False
        '
        'btnDashboard
        '
        Me.btnDashboard.Active = False
        Me.btnDashboard.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDashboard.BorderRadius = 0
        Me.btnDashboard.ButtonText = "   Dashboard"
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.DisabledColor = System.Drawing.Color.Gray
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDashboard.Iconimage = CType(resources.GetObject("btnDashboard.Iconimage"), System.Drawing.Image)
        Me.btnDashboard.Iconimage_right = Nothing
        Me.btnDashboard.Iconimage_right_Selected = Nothing
        Me.btnDashboard.Iconimage_Selected = Nothing
        Me.btnDashboard.IconMarginLeft = 30
        Me.btnDashboard.IconMarginRight = 0
        Me.btnDashboard.IconRightVisible = True
        Me.btnDashboard.IconRightZoom = 0R
        Me.btnDashboard.IconVisible = True
        Me.btnDashboard.IconZoom = 50.0R
        Me.btnDashboard.IsTab = False
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnDashboard.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnDashboard.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDashboard.selected = False
        Me.btnDashboard.Size = New System.Drawing.Size(212, 48)
        Me.btnDashboard.TabIndex = 5
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Textcolor = System.Drawing.Color.White
        Me.btnDashboard.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Panel4.Controls.Add(Me.btnclose)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 706)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 49)
        Me.Panel4.TabIndex = 1
        '
        'btnclose
        '
        Me.btnclose.Active = False
        Me.btnclose.Activecolor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.BorderRadius = 0
        Me.btnclose.ButtonText = "               Close"
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.DisabledColor = System.Drawing.Color.Gray
        Me.btnclose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnclose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnclose.Iconimage = CType(resources.GetObject("btnclose.Iconimage"), System.Drawing.Image)
        Me.btnclose.Iconimage_right = Nothing
        Me.btnclose.Iconimage_right_Selected = Nothing
        Me.btnclose.Iconimage_Selected = Nothing
        Me.btnclose.IconMarginLeft = 10
        Me.btnclose.IconMarginRight = 0
        Me.btnclose.IconRightVisible = True
        Me.btnclose.IconRightZoom = 0R
        Me.btnclose.IconVisible = True
        Me.btnclose.IconZoom = 70.0R
        Me.btnclose.IsTab = False
        Me.btnclose.Location = New System.Drawing.Point(0, 1)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.btnclose.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.btnclose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnclose.selected = False
        Me.btnclose.Size = New System.Drawing.Size(212, 48)
        Me.btnclose.TabIndex = 0
        Me.btnclose.Text = "               Close"
        Me.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclose.Textcolor = System.Drawing.Color.White
        Me.btnclose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.BunifuGradientPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(212, 129)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Capiz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Provincial " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Government "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.lblusername)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(212, 39)
        Me.BunifuGradientPanel1.TabIndex = 9
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.BackColor = System.Drawing.Color.Transparent
        Me.lblusername.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.ForeColor = System.Drawing.Color.White
        Me.lblusername.Location = New System.Drawing.Point(4, 7)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(72, 25)
        Me.lblusername.TabIndex = 0
        Me.lblusername.Text = "Label2"
        '
        'MainPanel
        '
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(212, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(978, 755)
        Me.MainPanel.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 755)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents btnChangeSign As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUserManagment As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSignOut As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lblusername As Label
    Friend WithEvents btnAdminSetting As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUserSetting As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPr As Bunifu.Framework.UI.BunifuFlatButton
End Class
