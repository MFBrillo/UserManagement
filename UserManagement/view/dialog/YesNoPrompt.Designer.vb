<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YesNoPrompt
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
        Me.components = New System.ComponentModel.Container()
        Me.btnyes = New System.Windows.Forms.Button()
        Me.btnno = New System.Windows.Forms.Button()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.MsgText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnyes
        '
        Me.btnyes.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.btnyes.FlatAppearance.BorderSize = 0
        Me.btnyes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyes.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.btnyes.ForeColor = System.Drawing.Color.White
        Me.btnyes.Location = New System.Drawing.Point(60, 216)
        Me.btnyes.Margin = New System.Windows.Forms.Padding(2)
        Me.btnyes.Name = "btnyes"
        Me.btnyes.Size = New System.Drawing.Size(150, 45)
        Me.btnyes.TabIndex = 25
        Me.btnyes.Text = "Yes"
        Me.btnyes.UseVisualStyleBackColor = False
        '
        'btnno
        '
        Me.btnno.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnno.FlatAppearance.BorderSize = 0
        Me.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnno.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.btnno.ForeColor = System.Drawing.Color.White
        Me.btnno.Location = New System.Drawing.Point(272, 216)
        Me.btnno.Margin = New System.Windows.Forms.Padding(2)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(150, 45)
        Me.btnno.TabIndex = 26
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = False
        '
        'TitleText
        '
        Me.TitleText.AutoSize = True
        Me.TitleText.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.TitleText.ForeColor = System.Drawing.Color.Black
        Me.TitleText.Location = New System.Drawing.Point(166, 18)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(173, 36)
        Me.TitleText.TabIndex = 28
        Me.TitleText.Text = "TITLE TEXT"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MsgText
        '
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgText.ForeColor = System.Drawing.Color.Black
        Me.MsgText.Location = New System.Drawing.Point(13, 75)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(459, 113)
        Me.MsgText.TabIndex = 29
        Me.MsgText.Text = "MESSAGE"
        Me.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'YesNoPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 289)
        Me.Controls.Add(Me.MsgText)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.btnyes)
        Me.Controls.Add(Me.TitleText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "YesNoPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomMessage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnyes As Button
    Friend WithEvents btnno As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents MsgText As Label
    Friend WithEvents Timer1 As Timer
End Class
