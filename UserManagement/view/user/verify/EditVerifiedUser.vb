Imports System.Threading.Tasks
Public Class EditVerifiedUser
    Dim userid As Integer
    Dim officeid As Integer
    Dim usersDT As DataTable
    Public OfficeDT As DataTable
    Dim passwordenable As Boolean = False
    Dim SelectedOfficeID As Integer = -1
    Public officeaccronym As String
    Public accesslevelDT As DataTable
    Dim accesslevelInt As Integer
    Dim accesslevelStr As String
    Private Sub lblclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblclose.LinkClicked
        Opaque.Close()
        Me.DialogResult = DialogResult.Cancel
        Main.Activate()
    End Sub
    Sub Custom_LoadUser()
        Dim SqlLoad As New MySQLCore
        userid = Variables.id
        usersDT = SqlLoad.MySql_SelectString("*", "gl_users", "", $"where id = {userid}")
        officeid = usersDT.Rows(0)("officeid").ToString()
        txtfirstname.Text = usersDT.Rows(0)("firstname").ToString()
        txtmiddlename.Text = usersDT.Rows(0)("middlename").ToString()
        txtlastname.Text = usersDT.Rows(0)("lastname").ToString()
        txtposition.Text = usersDT.Rows(0)("jobposition").ToString()
        txtusername.Text = usersDT.Rows(0)("username").ToString()
        accesslevelInt = usersDT.Rows(0)("accesslevel").ToString()
        Variables.username = usersDT.Rows(0)("username").ToString()

        accesslevelDT = SqlLoad.MySql_SelectString("*", "gl_users_accesslevel",, $"where id={accesslevelInt}")
        accesslevelStr = accesslevelDT.Rows(0)("accessname").ToString()
    End Sub
    Private Sub EditVerifiedUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadUser()
        Load_Accesslevel()
        LoadOffices()
        Custom_LoadOffice()
    End Sub
    Dim officeMap As New Dictionary(Of Integer, String)
    Sub LoadOffices()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices",, $"where officeid={officeid}")
        txtoffice.Text = OfficeDT.Rows(0)("officedescription").ToString()
    End Sub
    Sub Custom_LoadOffice()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        dgvOffice.DataSource = OfficeDT
        Dim oldcolumns() = {"officedescription", "officeaccronym"}
        Dim columns() = {"Officename", "Accronym"}
        Dim cols() = {"id", "officeid", "subofficeid", "is_spa", "officetypeid", "sectorid", "aipofficeid", "mandatory_aipcode", "officecode_pbo", "officecode_acctg", "officeheadpersonnel", "officeheadpos", "officename", "officeadd", "officelevelid", "open_office", "logdate"}
        Datagrid_HideColumn(dgvOffice, cols)
        Datagrid_RenameColumn(dgvOffice, oldcolumns, columns)
        dvWidthOffice()
    End Sub
    Sub dvWidthOffice()
        Dim columnWidths As New Dictionary(Of String, Integer)()
        columnWidths.Add("officeaccronym", 100)
        Set_GridColWidth(columnWidths, dgvOffice)
    End Sub
    Private Async Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        ' Ask user if they want to change password
        CustomYesNoPrompt("Change Password", "Do you want to change your password?")

        If YesNoPrompt.YesOption = True Then
            ' Open verification dialog
            Dim result As DialogResult
            Using frm As New VerifyChangePassword()
                Opaque.Show()
                result = frm.ShowDialog()
            End Using

            If result = DialogResult.OK Then
                ' Hash new password using MD5
                Dim HashPassword As String = MD5Password(Variables.newpassword)

                ' Ensure email sender is set
                EnsureEmailFrom()

                Dim recipient As String = Variables.emailfrom
                If String.IsNullOrEmpty(recipient) Then
                    CustomMsg("Warning", "No email address configured.")
                    Exit Sub
                End If

                Dim loading As New LoadingForm()
                loading.SetMessage("Checking email host...")
                loading.Show()
                loading.BringToFront()
                Application.DoEvents()
                Try
                    ' Show loading form modelessly
                    loading.Show()
                    loading.BringToFront()
                    Application.DoEvents() ' Ensure it paints

                    ' Check email host asynchronously
                    Dim isValid As Boolean = Await Task.Run(Function()
                                                                Return EmailChecker.IsValidEmailHost(recipient)
                                                            End Function)
                    loading.Close()

                    If isValid Then
                        Variables.emailto = recipient

                        Dim subject As String = "Password Reset Notification – " & Variables.username
                        Dim body As String = $"Hello {Variables.username},{vbCrLf}{vbCrLf}" &
                                         $"Your new password is: {Variables.newpassword}{vbCrLf}{vbCrLf}" &
                                         $"Please change it after logging in.{vbCrLf}{vbCrLf}" &
                                         "Regards," & vbCrLf &
                                         "PBO-DAG Team"

                        ' Send email and update DB asynchronously
                        Await Task.Run(Sub()
                                           EmailModule.SendEmail(Variables.emailto, subject, body)

                                           Dim SqlLoad As New MySQLCore()
                                           Dim columnValues As New Dictionary(Of String, String) From {{"hashpassword", HashPassword}}
                                           SqlLoad.MySql_ExecuteNonQueryString("gl_users", columnValues, $"id={Variables.id}", 2)
                                       End Sub)

                        CustomMsg("Updated", "Your password has been changed and emailed successfully.")
                    Else
                        ' Invalid email host
                        CustomMsg("Error", "Invalid email address or host. Please check your email.")
                        Using frm As New VerifyChangePassword()
                            Opaque.Show()
                            frm.ShowDialog()
                        End Using
                    End If
                Catch ex As Exception
                    CustomMsg("Error", "Failed to change password: " & ex.Message)
                Finally
                    ' Always close loading form
                    If Not loading.IsDisposed Then
                        loading.Close()
                    End If
                End Try
            End If

        ElseIf YesNoPrompt.NoOption = True Then
            ' User chose "No" → open EditVerifiedUser form
            Using frm As New EditVerifiedUser()
                Opaque.Show()
                frm.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub EnsureEmailFrom()
        If String.IsNullOrEmpty(Variables.emailfrom) Then
            Variables.emailfrom = "crushneq@gmail.com"
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        CustomYesNoPrompt("Update Use Data", "You want to Update Uset Data")
        If YesNoPrompt.YesOption = True Then
            Variables.officeid = officeid
            Variables.firstname = txtfirstname.Text
            Variables.middlename = txtmiddlename.Text
            Variables.lastname = txtlastname.Text
            Variables.jobposition = txtposition.Text
            Variables.accesslevel = accesslevelInt
            Me.DialogResult = DialogResult.OK
        ElseIf YesNoPrompt.NoOption = True Then
            Dim frm As New EditVerifiedUser()
            Opaque.Show()
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txtoffice_TextChanged(sender As Object, e As EventArgs) Handles txtoffice.TextChanged
        Custom_LoadOffice()
        Try
            If OfficeDT.Rows.Count > 0 Then
                Dim conditions As New List(Of LinQCondition)()
                conditions.Add(New LinQCondition With {
                .Column = "officedescription",
                .Value = txtoffice.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
                })
                conditions.Add(New LinQCondition With {
                .Column = "officeaccronym",
                .Value = txtoffice.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
                })
                Dim filteredDataTable1 As DataTable = Linq_Query(OfficeDT, conditions, useOrOperator:=True)
                dgvOffice.DataSource = filteredDataTable1
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
        If txtoffice.Text = "" Then
            dgvOffice.Visible = False
        End If
    End Sub
    Private Async Function CheckEmailHostAsync(email As String) As Task(Of Boolean)
        Return Await Task.Run(Function() EmailChecker.IsValidEmailHost(email))
    End Function
    Sub Load_Accesslevel()
        Dim SqlLoad As New MySQLCore
        accesslevelDT = SqlLoad.MySql_SelectString("id,accessname", "gl_users_accesslevel",,,, "limit 3 offset 0")
        Custom_ComboBox(cbbaccesslevel, accesslevelDT, "accessname", "id")
        cbbaccesslevel.Text = accesslevelStr
    End Sub
    Private Sub cbbaccesslevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbaccesslevel.SelectedIndexChanged
        If cbbaccesslevel.SelectedIndex <> -1 Then ' Ensure a valid selection
            Dim selectedRow As DataRowView = TryCast(cbbaccesslevel.SelectedItem, DataRowView)
            If selectedRow IsNot Nothing Then
                accesslevelInt = CInt(selectedRow("id")) ' Convert correctly
            End If
        End If
    End Sub

    Private Sub txtoffice_MouseClick(sender As Object, e As MouseEventArgs) Handles txtoffice.MouseClick
        dgvOffice.Visible = True
    End Sub

    Private Sub txtoffice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtoffice.KeyDown
        dgvOffice.Visible = True
        If e.KeyCode = Keys.Escape Then
            dgvOffice.Visible = False
        ElseIf txtoffice.Text = "" Then
            dgvOffice.Visible = False
        ElseIf e.KeyCode = Keys.Enter Then
            Dim selectedRowIndex As Integer = dgvOffice.CurrentCell.RowIndex
            Dim value As String = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString()
            Variables.newofficeid = dgvOffice.CurrentRow.Cells("id").Value.ToString
            Variables.newofficedescription = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString
            officeaccronym = dgvOffice.CurrentRow.Cells("officeaccronym").Value.ToString
            officeid = Variables.newofficeid
            txtoffice.Text = value
            dgvOffice.Visible = False
            txtfirstname.Focus()
        End If
    End Sub

    Private Sub dgvOffice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOffice.CellContentClick

    End Sub

    Private Sub dgvOffice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOffice.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvOffice.Rows(e.RowIndex)
            Dim value As String = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString()
            Variables.newofficedescription = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString
            Variables.newofficeid = selectedRow.Cells("id").Value.ToString()
            txtoffice.Text = value
            dgvOffice.Visible = False
            txtfirstname.Focus()
        End If
    End Sub
End Class