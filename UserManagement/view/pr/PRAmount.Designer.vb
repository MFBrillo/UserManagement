<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PRAmount
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvPrRegular = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPurpose = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtVerifiedBy = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtVerifiedPositionBy = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtTotal = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnclose = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvPrRegular, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(632, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 18)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Position:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Verified By:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Purpose:"
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
        Me.Label7.Size = New System.Drawing.Size(180, 23)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Purchase Request"
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
        Me.Panel1.Size = New System.Drawing.Size(1230, 43)
        Me.Panel1.TabIndex = 28
        '
        'dgvPrRegular
        '
        Me.dgvPrRegular.AllowUserToAddRows = False
        Me.dgvPrRegular.AllowUserToDeleteRows = False
        Me.dgvPrRegular.AllowUserToResizeColumns = False
        Me.dgvPrRegular.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvPrRegular.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPrRegular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPrRegular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrRegular.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvPrRegular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrRegular.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPrRegular.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrRegular.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPrRegular.ColumnHeadersHeight = 40
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Coral
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrRegular.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPrRegular.EnableHeadersVisualStyles = False
        Me.dgvPrRegular.Location = New System.Drawing.Point(13, 233)
        Me.dgvPrRegular.Name = "dgvPrRegular"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPrRegular.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPrRegular.RowHeadersVisible = False
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvPrRegular.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.dgvPrRegular.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPrRegular.RowTemplate.DividerHeight = 1
        Me.dgvPrRegular.RowTemplate.Height = 40
        Me.dgvPrRegular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrRegular.Size = New System.Drawing.Size(1205, 344)
        Me.dgvPrRegular.TabIndex = 156
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1026, 593)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(190, 44)
        Me.btnSave.TabIndex = 157
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPurpose
        '
        Me.txtPurpose.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtPurpose.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtPurpose.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtPurpose.BorderThickness = 1
        Me.txtPurpose.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurpose.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPurpose.isPassword = False
        Me.txtPurpose.Location = New System.Drawing.Point(13, 79)
        Me.txtPurpose.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPurpose.MaxLength = 32767
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtPurpose.Size = New System.Drawing.Size(1205, 54)
        Me.txtPurpose.TabIndex = 1
        Me.txtPurpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtVerifiedBy
        '
        Me.txtVerifiedBy.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtVerifiedBy.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtVerifiedBy.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtVerifiedBy.BorderThickness = 1
        Me.txtVerifiedBy.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVerifiedBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerifiedBy.Enabled = False
        Me.txtVerifiedBy.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifiedBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerifiedBy.isPassword = False
        Me.txtVerifiedBy.Location = New System.Drawing.Point(13, 171)
        Me.txtVerifiedBy.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVerifiedBy.MaxLength = 32767
        Me.txtVerifiedBy.Name = "txtVerifiedBy"
        Me.txtVerifiedBy.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtVerifiedBy.Size = New System.Drawing.Size(590, 54)
        Me.txtVerifiedBy.TabIndex = 159
        Me.txtVerifiedBy.Text = "IMEE D. ORTIZ"
        Me.txtVerifiedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtVerifiedPositionBy
        '
        Me.txtVerifiedPositionBy.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtVerifiedPositionBy.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtVerifiedPositionBy.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtVerifiedPositionBy.BorderThickness = 1
        Me.txtVerifiedPositionBy.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtVerifiedPositionBy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVerifiedPositionBy.Enabled = False
        Me.txtVerifiedPositionBy.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVerifiedPositionBy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtVerifiedPositionBy.isPassword = False
        Me.txtVerifiedPositionBy.Location = New System.Drawing.Point(635, 171)
        Me.txtVerifiedPositionBy.Margin = New System.Windows.Forms.Padding(5)
        Me.txtVerifiedPositionBy.MaxLength = 32767
        Me.txtVerifiedPositionBy.Name = "txtVerifiedPositionBy"
        Me.txtVerifiedPositionBy.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.txtVerifiedPositionBy.Size = New System.Drawing.Size(581, 54)
        Me.txtVerifiedPositionBy.TabIndex = 160
        Me.txtVerifiedPositionBy.Text = "Supervising Administrative Officer"
        Me.txtVerifiedPositionBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtTotal
        '
        Me.txtTotal.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtTotal.BorderColorIdle = System.Drawing.SystemColors.AppWorkspace
        Me.txtTotal.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtTotal.BorderThickness = 1
        Me.txtTotal.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.isPassword = False
        Me.txtTotal.Location = New System.Drawing.Point(585, 591)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Padding = New System.Windows.Forms.Padding(9, 0, 0, 0)
        Me.txtTotal.Size = New System.Drawing.Size(432, 44)
        Me.txtTotal.TabIndex = 161
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(469, 607)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Total Amount:"
        '
        'btnclose
        '
        Me.btnclose.Image = Global.usermanagement.My.Resources.Resources.close
        Me.btnclose.ImageActive = Nothing
        Me.btnclose.Location = New System.Drawing.Point(1195, 5)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(32, 31)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 14
        Me.btnclose.TabStop = False
        Me.btnclose.Zoom = 10
        '
        'PRAmount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtVerifiedPositionBy)
        Me.Controls.Add(Me.txtVerifiedBy)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvPrRegular)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PRAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase_Request"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvPrRegular, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvPrRegular As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents txtPurpose As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtVerifiedBy As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtVerifiedPositionBy As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtTotal As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnclose As Bunifu.Framework.UI.BunifuImageButton
End Class
