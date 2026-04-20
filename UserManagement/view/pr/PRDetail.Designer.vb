<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRDetail
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvPrRegular = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDate = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPRNumber = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPurpose = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAccountCode = New System.Windows.Forms.Label()
        Me.lblAccountName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrRegular, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1428, 43)
        Me.Panel1.TabIndex = 29
        '
        'btnclose
        '
        Me.btnclose.Image = Global.usermanagement.My.Resources.Resources.close
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(1396, 7)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(32, 31)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 15
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 10)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Purchase Request Detail"
        '
        'dgvPrRegular
        '
        Me.dgvPrRegular.AllowUserToAddRows = False
        Me.dgvPrRegular.AllowUserToDeleteRows = False
        Me.dgvPrRegular.AllowUserToResizeColumns = False
        Me.dgvPrRegular.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvPrRegular.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPrRegular.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvPrRegular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrRegular.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvPrRegular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrRegular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPrRegular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrRegular.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPrRegular.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrRegular.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPrRegular.EnableHeadersVisualStyles = False
        Me.dgvPrRegular.Location = New System.Drawing.Point(6, 8)
        Me.dgvPrRegular.Name = "dgvPrRegular"
        Me.dgvPrRegular.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrRegular.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPrRegular.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPrRegular.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPrRegular.RowTemplate.DividerHeight = 1
        Me.dgvPrRegular.RowTemplate.Height = 40
        Me.dgvPrRegular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrRegular.Size = New System.Drawing.Size(1400, 431)
        Me.dgvPrRegular.TabIndex = 157
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.txtPRNumber)
        Me.Panel2.Controls.Add(Me.txtPurpose)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1428, 207)
        Me.Panel2.TabIndex = 159
        '
        'txtDate
        '
        Me.txtDate.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtDate.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtDate.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtDate.BorderThickness = 1
        Me.txtDate.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDate.isPassword = False
        Me.txtDate.Location = New System.Drawing.Point(811, 140)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDate.MaxLength = 32767
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtDate.Size = New System.Drawing.Size(602, 54)
        Me.txtDate.TabIndex = 3
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPRNumber
        '
        Me.txtPRNumber.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtPRNumber.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtPRNumber.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPRNumber.BorderThickness = 1
        Me.txtPRNumber.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPRNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPRNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPRNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPRNumber.isPassword = False
        Me.txtPRNumber.Location = New System.Drawing.Point(13, 140)
        Me.txtPRNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPRNumber.MaxLength = 32767
        Me.txtPRNumber.Name = "txtPRNumber"
        Me.txtPRNumber.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtPRNumber.Size = New System.Drawing.Size(745, 54)
        Me.txtPRNumber.TabIndex = 2
        Me.txtPRNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPurpose
        '
        Me.txtPurpose.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtPurpose.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtPurpose.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPurpose.BorderThickness = 1
        Me.txtPurpose.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurpose.Enabled = False
        Me.txtPurpose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPurpose.isPassword = False
        Me.txtPurpose.Location = New System.Drawing.Point(13, 47)
        Me.txtPurpose.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPurpose.MaxLength = 32767
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtPurpose.Size = New System.Drawing.Size(1750, 54)
        Me.txtPurpose.TabIndex = 1
        Me.txtPurpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(807, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PR Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purpose:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Account Code:"
        '
        'lblAccountCode
        '
        Me.lblAccountCode.AutoSize = True
        Me.lblAccountCode.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblAccountCode.ForeColor = System.Drawing.Color.White
        Me.lblAccountCode.Location = New System.Drawing.Point(179, 8)
        Me.lblAccountCode.Name = "lblAccountCode"
        Me.lblAccountCode.Size = New System.Drawing.Size(113, 18)
        Me.lblAccountCode.TabIndex = 161
        Me.lblAccountCode.Text = "Account Code:"
        '
        'lblAccountName
        '
        Me.lblAccountName.AutoSize = True
        Me.lblAccountName.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAccountName.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountName.ForeColor = System.Drawing.Color.White
        Me.lblAccountName.Location = New System.Drawing.Point(1294, 0)
        Me.lblAccountName.Name = "lblAccountName"
        Me.lblAccountName.Padding = New System.Windows.Forms.Padding(5, 10, 10, 10)
        Me.lblAccountName.Size = New System.Drawing.Size(134, 38)
        Me.lblAccountName.TabIndex = 162
        Me.lblAccountName.Text = "Account Name:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblAccountName)
        Me.Panel3.Controls.Add(Me.lblAccountCode)
        Me.Panel3.Location = New System.Drawing.Point(0, 46)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1428, 34)
        Me.Panel3.TabIndex = 163
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.dgvPrRegular)
        Me.Panel4.Location = New System.Drawing.Point(7, 290)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1409, 447)
        Me.Panel4.TabIndex = 164
        '
        'PRDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 749)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PRDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRDetail"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrRegular, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvPrRegular As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAccountCode As Label
    Friend WithEvents lblAccountName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtPurpose As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDate As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPRNumber As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
End Class
