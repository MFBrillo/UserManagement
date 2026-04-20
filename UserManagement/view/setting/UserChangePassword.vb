Public Class UserChangePassword
    Dim usersDT As DataTable
    Dim userid As Integer = Variables.login_userid
    Dim username As String
    Dim hashpassword As String
    Private Sub btnclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnclose.LinkClicked
        Opaque.Close()
        Me.Close()
        Main.Activate()
    End Sub
    Private Sub UserChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnewpassword.Text = ""
        txtrepassword.Text = ""
        txtcurrentpassword.Text = ""
        load_user()
    End Sub
    Private Function CheckCredentials(username As String, hashpassword As String) As Boolean
        Dim mySql As New MySQLCore
        Dim columns As String = "id,username, hashpassword,accesslevel, officeid,firstname,middlename,lastname"
        Dim tablename As String = "gl_users"
        Dim whereclause As String = $"WHERE username = '{username}' AND hashpassword = '{hashpassword}'"
        Dim resultTable As DataTable = mySql.MySql_SelectString(columns, tablename, Nothing, whereclause)
        If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Update this data?", "Update User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim SqlLoad As New MySQLCore
        If lblcurrent.Text = "current password match" Then
            If lblrepass.Text = "new password match" Then
                If result = DialogResult.Yes Then
                    Dim HashPassword = MD5Password(txtnewpassword.Text)
                    'Variables.hashpassword = HashPassword
                    Dim user_colvals As New Dictionary(Of String, String) From {
                        {"hashpassword", HashPassword}
                    }
                    SqlLoad.MySql_ExecuteNonQueryString("gl_users", user_colvals, $"id={ Variables.login_userid}", 2)
                    Me.DialogResult = DialogResult.OK
                End If
            Else
                MsgBox("password did match from current password")
            End If
        Else
            MsgBox("password did not match")
        End If
    End Sub
    Sub load_user()
        Dim SqlLoad As New MySQLCore
        usersDT = SqlLoad.MySql_SelectString("*", "gl_users",, $"where id={userid}")
        username = usersDT.Rows(0)("username").ToString()
        hashpassword = usersDT.Rows(0)("hashpassword").ToString()
    End Sub
    Private Sub txtcurrentpassword_TextChanged(sender As Object, e As EventArgs) Handles txtcurrentpassword.TextChanged
        Dim password As String = txtcurrentpassword.Text
        Dim hashpassword2 As String = MD5Encryption.MD5Password(password)
        If hashpassword2 = hashpassword Then
            lblcurrent.Text = "current password match"
            lblcurrent.ForeColor = Color.Green
        Else
            lblcurrent.Text = "password did match from current password"
            lblcurrent.ForeColor = Color.Red
        End If
    End Sub
    Private Sub txtrepassword_TextChanged(sender As Object, e As EventArgs) Handles txtrepassword.TextChanged
        If txtrepassword.Text = txtnewpassword.Text Then
            lblrepass.Text = "new password match"
            lblrepass.ForeColor = Color.Green
        Else
            lblrepass.Text = "password did not match"
            lblrepass.ForeColor = Color.Red
        End If
    End Sub
    Private Sub btneye_Click(sender As Object, e As EventArgs) Handles btneye.Click
        If txtcurrentpassword.UseSystemPasswordChar Then
            txtcurrentpassword.UseSystemPasswordChar = False
        Else
            txtcurrentpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtnewpassword_TextChanged(sender As Object, e As EventArgs) Handles txtnewpassword.TextChanged
        If txtrepassword.Text = txtnewpassword.Text Then
            lblrepass.Text = "new password match"
            lblrepass.ForeColor = Color.Green
        Else
            lblrepass.Text = "password did not match"
            lblrepass.ForeColor = Color.Red
        End If
    End Sub
End Class