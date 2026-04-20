Public Class usersetting
    Dim userid As Integer = Variables.login_userid
    Dim usersDT As DataTable
    Dim officeDT As DataTable
    Dim officeid As Integer
    Private Sub usersetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_user()
        load_offices()
    End Sub
    Sub load_user()
        Dim SqlLoad As New MySQLCore
        usersDT = SqlLoad.MySql_SelectString("*", "gl_users", "", $"where id = {userid}")
        txtusername.Text = usersDT.Rows(0)("username").ToString()
        txtfirstname.Text = usersDT.Rows(0)("firstname").ToString()
        txtmiddlename.Text = usersDT.Rows(0)("middlename").ToString()
        txtlastname.Text = usersDT.Rows(0)("lastname").ToString()
        officeid = usersDT.Rows(0)("officeid").ToString()
        txtjobposition.Text = usersDT.Rows(0)("jobposition").ToString()
    End Sub
    Sub load_offices()
        Dim SqlLoad As New MySQLCore
        officeDT = SqlLoad.MySql_SelectString("*", "gl_offices",, $"where officeid={officeid}")
        txtoffice.Text = officeDT.Rows(0)("officedescription").ToString()
    End Sub
    Private Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        Opaque.Show()
        Dim result As DialogResult =  UserChangePassword.ShowDialog()
        If result = DialogResult.OK Then
            Opaque.Close()
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Opaque.Show()
        Dim SqlLoad As New MySQLCore
        CustomYesNoPrompt("Update User", "Do you want to Update Your Information?")
        If YesNoPrompt.YesOption = True Then
            'Dim user_colvals As New Dictionary(Of String, String)()
            'user_colvals.Add("firstname", $"{txtfirstname.Text}")
            'user_colvals.Add("middlename", $"{txtmiddlename.Text}")
            'user_colvals.Add("lastname", $"{txtlastname.Text}")
            'user_colvals.Add("jobposition", $"{txtjobposition.Text}")
            Dim user_colvals As New Dictionary(Of String, String) From {
                {"firstname", $"{txtfirstname.Text}"},
                {"middlename", $"{txtmiddlename.Text}"},
                {"lastname", $"{txtlastname.Text}"},
                {"jobposition", $"{txtjobposition.Text}"}
            }
            SqlLoad.MySql_ExecuteNonQueryString("gl_users", user_colvals, $"id={Variables.login_userid}", 2)
            CustomMsg("Successfully Update", "Your Information is Successfully Update")
            load_user()
        End If
        Opaque.Close()
    End Sub
End Class
