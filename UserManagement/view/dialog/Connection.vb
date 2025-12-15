Public Class connection
    Dim userConfig As UserConfig
    Public encryptedPassword As String
    Private Sub lblclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblclose.LinkClicked
        Me.Close()
        Login.Txtusername.Focus()
    End Sub
    Sub LoadData()
        Dim decryptedPassword As String = PasswordEncryption.DecryptPassword(userConfig.Password)
        txtserver.Text = userConfig.Servername
        txtusername.Text = userConfig.Username
        txtport.Text = userConfig.Port
        txtpassword.Text = decryptedPassword
        txtdatabase.Text = userConfig.Databasename
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        userConfig = ConfigManager.LoadConfig()
        LoadData()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim plainPassword As String = txtpassword.Text
        encryptedPassword = PasswordEncryption.EncryptPassword(plainPassword)
        userConfig.Servername = txtserver.Text
        userConfig.Username = txtusername.Text
        userConfig.Port = txtport.Text
        userConfig.Password = encryptedPassword
        userConfig.Databasename = txtdatabase.Text
        ConfigManager.SaveConfig(userConfig)
        MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End
    End Sub
End Class