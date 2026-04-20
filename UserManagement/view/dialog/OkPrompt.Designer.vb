<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OkPrompt
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
        Me.btnclose = New System.Windows.Forms.Button()
        Me.MsgText = New System.Windows.Forms.Label()
        Me.TitleText = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(160, 214)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(150, 45)
        Me.btnclose.TabIndex = 30
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'MsgText
        '
        Me.MsgText.BackColor = System.Drawing.Color.Transparent
        Me.MsgText.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsgText.ForeColor = System.Drawing.Color.Black
        Me.MsgText.Location = New System.Drawing.Point(13, 68)
        Me.MsgText.Name = "MsgText"
        Me.MsgText.Size = New System.Drawing.Size(459, 122)
        Me.MsgText.TabIndex = 34
        Me.MsgText.Text = "MESSAGE"
        Me.MsgText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleText
        '
        Me.TitleText.AutoSize = True
        Me.TitleText.Font = New System.Drawing.Font("Tahoma", 22.0!)
        Me.TitleText.ForeColor = System.Drawing.Color.Black
        Me.TitleText.Location = New System.Drawing.Point(154, 18)
        Me.TitleText.Name = "TitleText"
        Me.TitleText.Size = New System.Drawing.Size(173, 36)
        Me.TitleText.TabIndex = 33
        Me.TitleText.Text = "TITLE TEXT"
        Me.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        '
        'OkPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 289)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.MsgText)
        Me.Controls.Add(Me.TitleText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OkPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OkPrompt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnclose As Button
    Friend WithEvents MsgText As Label
    Friend WithEvents TitleText As Label
    Friend WithEvents Timer1 As Timer
End Class
