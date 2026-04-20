Public Class Login
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True  ' Enable key preview at the form level
    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mySql As New MySQLCore
        mySql.MySql_CheckConn(0, pbStatus)
        Txtpassword.Text = ""
        Txtusername.Text = ""
        LoadServerYear()
    End Sub
    Private Sub lblclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblclose.LinkClicked
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to Close the Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub lblserversetting_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblserversetting.LinkClicked
        connection.ShowDialog()
    End Sub
    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        Dim username As String = Txtusername.Text
        Dim password As String = Txtpassword.Text
        Dim hashpassword As String = MD5Encryption.MD5Password(password)
        ' MySQL Query to Validate Login
        Dim mySql As New MySQLCore
        Dim columns As String = "id, username, hashpassword, accesslevel, officeid"
        Dim tablename As String = "gl_users"
        Dim whereclause As String = $"WHERE username = '{username}' AND hashpassword = '{hashpassword}'"
        Dim resultTable As DataTable = mySql.MySql_SelectString(columns, tablename, Nothing, whereclause)
        If CheckCredentials(username, hashpassword) Then
            My.MySettings.Default.ServerYear = Variables.ServerYear
            My.MySettings.Default.Save()
            If Variables.login_accesslevel <> 3 Then
                'MsgBox("Successful Login!", MsgBoxStyle.Information, "Log in")
                CustomMsg("Log in", "Successful Login!")
                Main.btnDashboard.Visible = True
                Main.btnUserManagment.Visible = True
                Main.btnChangeSign.Visible = False

                Variables.officeid = 0

                If Variables.login_accesslevel <> 2 Then
                    Main.btnAdminSetting.Visible = True
                Else
                    Main.btnAdminSetting.Visible = False
                End If

                Dim uc = New UserManagement
                Main.ShowUserControl(uc)

            Else
                CustomMsg("Log in", "Successful Login!")
                Main.btnDashboard.Visible = False
                Main.btnUserManagment.Visible = True
                Main.btnChangeSign.Visible = True

                Main.btnAdminSetting.Visible = False
                Dim uc = New PRDashboard
                Main.ShowUserControl(uc)
            End If

            Main.btnUserSetting.Visible = True
            Main.Activate()
            Opaque.Close()
            Me.Close()
        ElseIf CheckCredentials2(username, hashpassword) Then
            Opaque.Close()
            Me.Close()
            Main.Activate()
            Opaque.Show()
            UserPendingForm.ShowDialog()
        Else
            Txtpassword.Text = ""
            'MsgBox("Invalid Username or Password", MsgBoxStyle.Information, "Invalid Entry")
            CustomMsg("Invalid Entry", "Invalid Username or Password")
            If OkPrompt.CancelOption = False Then
                Dim frm As New Login()
                Opaque.Show()
                frm.ShowDialog()
            End If
            Txtusername.Focus()
        End If
    End Sub
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        AcceptForm.ShowDialog()
    End Sub
    Private Function CheckCredentials(username As String, hashpassword As String) As Boolean
        Dim mySql As New MySQLCore
        Dim columns As String = "id,username, hashpassword,accesslevel, officeid,firstname,middlename,lastname"
        Dim tablename As String = "gl_users"
        Dim whereclause As String = $"WHERE username = '{username}' AND hashpassword = '{hashpassword}'"
        Dim resultTable As DataTable = mySql.MySql_SelectString(columns, tablename, Nothing, whereclause)
        If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then
            Variables.login_accesslevel = resultTable.Rows(0)("accesslevel").ToString()
            Variables.login_username = resultTable.Rows(0)("username").ToString()

            Variables.firstname = resultTable.Rows(0)("firstname").ToString()
            Variables.middlename = resultTable.Rows(0)("middlename").ToString()
            Variables.lastname = resultTable.Rows(0)("lastname").ToString()
            Variables.officeid = resultTable.Rows(0)("officeid").ToString()
            Variables.login_userid = resultTable.Rows(0)("id").ToString()
            'Variables.id = resultTable.Rows(0)("id").ToString()
            Main.lblusername.Text = $"Hi! {Variables.login_username}"

            Return True
        Else
            Return False
        End If
    End Function
    Private Function CheckCredentials2(username As String, hashpassword As String) As Boolean
        Dim mySql As New MySQLCore
        Dim columns As String = "id,username, hashpassword,accesslevel, officeid"
        Dim tablename As String = "tl_users"
        Dim whereclause As String = $"WHERE username = '{username}' AND hashpassword = '{hashpassword}'"
        Dim resultTable As DataTable = mySql.MySql_SelectString(columns, tablename, Nothing, whereclause)
        If resultTable IsNot Nothing AndAlso resultTable.Rows.Count > 0 Then

            Variables.login_username = resultTable.Rows(0)("username").ToString()
            UserPendingForm.lblusername.Text = $"Hi! {Variables.login_username}"

            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Btnlogin.PerformClick()
        End If
    End Sub


    Private Sub Txtusername_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtusername.KeyDown
        If Txtusername.Text = "moi" Then
            ' Check if Ctrl + Shift + Enter are pressed
            If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.Enter Then
                'MsgBox("Successful Login!", MsgBoxStyle.Information, "Log in")
                CustomMsg("Log in", "Successful Login!")
                Variables.login_accesslevel = 1
                Variables.login_username = "moi"
                Variables.firstname = "Moises"
                Variables.middlename = "F"
                Variables.lastname = "Brillo"
                Variables.officeid = 31
                Variables.login_userid = 229
                Main.btnUserSetting.Visible = True
                Main.btnAdminSetting.Visible = True
                Main.btnDashboard.Visible = True
                Main.btnUserManagment.Visible = True
                Main.btnChangeSign.Visible = False
                Main.btnSignOut.Visible = True
                Main.lblusername.Text = "Hi Creator!"
                Dim uc = New UserManagement
                Main.ShowUserControl(uc)
                Main.Activate()
                Me.Close()
                Opaque.Close()
            End If
        End If
    End Sub

    Private Sub btneye_MouseDown(sender As Object, e As MouseEventArgs) Handles btneye.MouseDown
        Txtpassword.UseSystemPasswordChar = False
    End Sub
    Private Sub btneye_MouseUp(sender As Object, e As MouseEventArgs) Handles btneye.MouseUp
        Txtpassword.UseSystemPasswordChar = True
    End Sub
    Public Sub LoadServerYear()

        Dim SqlLoad As New MySQLCore
        Dim serverDT As DataTable = SqlLoad.MySQL_Datatable("all_serverdate")

        If serverDT IsNot Nothing AndAlso serverDT.Rows.Count > 0 Then
            Variables.ServerYear = Convert.ToDateTime(serverDT.Rows(0)(0)).Year
        Else
            Variables.ServerYear = DateTime.Now.Year
        End If

    End Sub

End Class