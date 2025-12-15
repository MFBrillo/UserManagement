Public Class VerifyChangePassword
    Dim newpassword As String
    Dim userid As Integer
    Dim usersDT As DataTable
    Dim username As String
    Dim emailfrom As String
    Private Sub VerifyChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Variables.newpassword = RandomPassword.GenerateRandomPassword(6)
        lblpassword.Text = Variables.newpassword
    End Sub
    Private Sub lblclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblclose.LinkClicked
        Opaque.Close()
        Me.Close()
        Main.Activate()
        ' Make sure to dispose the form after use
        Using frm As New EditVerifiedUser()
            Opaque.Show()
            frm.ShowDialog()
            Opaque.Close()
        End Using
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SqlLoad As New MySQLCore
        CustomYesNoPrompt("Update Password", "Do you want to Change Password?")
        If YesNoPrompt.YesOption = True Then
            Dim HashPassword = MD5Password(Variables.newpassword)
            Variables.emailfrom = txtemail.Text
            Me.DialogResult = DialogResult.OK
        ElseIf YesNoPrompt.NoOption Then
            Dim frm As New VerifyChangePassword()
            Opaque.Show()
            frm.ShowDialog()
        End If
    End Sub
    Sub Custom_LoadUser()
        Dim SqlLoad As New MySQLCore
        userid = Variables.id
        usersDT = SqlLoad.MySql_SelectString("*", "gl_users", "", $"where id = {userid}")
        username = usersDT.Rows(0)("username").ToString()
    End Sub
    Sub no_email()
        If emailfrom = "" Then
            emailfrom = "crushneq@gmail.com"
        End If
    End Sub
End Class