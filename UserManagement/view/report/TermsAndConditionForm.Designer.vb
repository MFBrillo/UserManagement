<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TermsAndConditionForm
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btncancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnaccept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbterms = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(931, 905)
        Me.WebBrowser1.TabIndex = 0
        '
        'btncancel
        '
        Me.btncancel.Active = False
        Me.btncancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btncancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncancel.BorderRadius = 0
        Me.btncancel.ButtonText = "Cancel"
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.DisabledColor = System.Drawing.Color.Gray
        Me.btncancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btncancel.Iconimage = Nothing
        Me.btncancel.Iconimage_right = Nothing
        Me.btncancel.Iconimage_right_Selected = Nothing
        Me.btncancel.Iconimage_Selected = Nothing
        Me.btncancel.IconMarginLeft = 0
        Me.btncancel.IconMarginRight = 0
        Me.btncancel.IconRightVisible = True
        Me.btncancel.IconRightZoom = 0R
        Me.btncancel.IconVisible = True
        Me.btncancel.IconZoom = 90.0R
        Me.btncancel.IsTab = False
        Me.btncancel.Location = New System.Drawing.Point(486, 924)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btncancel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btncancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btncancel.selected = False
        Me.btncancel.Size = New System.Drawing.Size(170, 48)
        Me.btncancel.TabIndex = 9
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btncancel.Textcolor = System.Drawing.Color.White
        Me.btncancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnaccept
        '
        Me.btnaccept.Active = False
        Me.btnaccept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnaccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnaccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnaccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnaccept.BorderRadius = 0
        Me.btnaccept.ButtonText = "Accept Terms and Condition"
        Me.btnaccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaccept.DisabledColor = System.Drawing.Color.Gray
        Me.btnaccept.Iconcolor = System.Drawing.Color.Transparent
        Me.btnaccept.Iconimage = Nothing
        Me.btnaccept.Iconimage_right = Nothing
        Me.btnaccept.Iconimage_right_Selected = Nothing
        Me.btnaccept.Iconimage_Selected = Nothing
        Me.btnaccept.IconMarginLeft = 0
        Me.btnaccept.IconMarginRight = 0
        Me.btnaccept.IconRightVisible = True
        Me.btnaccept.IconRightZoom = 0R
        Me.btnaccept.IconVisible = True
        Me.btnaccept.IconZoom = 90.0R
        Me.btnaccept.IsTab = False
        Me.btnaccept.Location = New System.Drawing.Point(671, 924)
        Me.btnaccept.Name = "btnaccept"
        Me.btnaccept.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnaccept.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnaccept.OnHoverTextColor = System.Drawing.Color.White
        Me.btnaccept.selected = False
        Me.btnaccept.Size = New System.Drawing.Size(241, 48)
        Me.btnaccept.TabIndex = 8
        Me.btnaccept.Text = "Accept Terms and Condition"
        Me.btnaccept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnaccept.Textcolor = System.Drawing.Color.White
        Me.btnaccept.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 945)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "I have read and agree to Terms and Condition"
        '
        'cbterms
        '
        Me.cbterms.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbterms.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cbterms.Checked = False
        Me.cbterms.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cbterms.ForeColor = System.Drawing.Color.White
        Me.cbterms.Location = New System.Drawing.Point(42, 942)
        Me.cbterms.Name = "cbterms"
        Me.cbterms.Size = New System.Drawing.Size(20, 20)
        Me.cbterms.TabIndex = 6
        '
        'TermsAndConditionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(931, 986)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnaccept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbterms)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Name = "TermsAndConditionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Terms And Condition Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btncancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnaccept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cbterms As Bunifu.Framework.UI.BunifuCheckbox
End Class
