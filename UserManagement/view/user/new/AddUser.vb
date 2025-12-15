Public Class AddUser
    Public OfficeDT As DataTable
    Public officeid As Integer
    Public officedescription As String
    Public officeaccronym As String
    Private Sub btncose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnclose.LinkClicked
        Me.Close()
        Main.Activate()
    End Sub
    Sub Custom_LoadOffice()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        dgvOffice.DataSource = OfficeDT
        Dim oldcolumns() = {"officedescription", "officeaccronym"}
        Dim columns() = {"Officename", "Accronym"}
        Dim cols() = {"id", "officeid", "subofficeid", "officetypeid", "sectorid", "aipofficeid", "mandatory_aipcode", "officecode_pbo", "officecode_acctg", "officeheadpersonnel", "officeheadpos", "officename", "officeadd", "officelevelid", "open_office", "logdate"}
        Datagrid_HideColumn(dgvOffice, cols)
        Datagrid_RenameColumn(dgvOffice, oldcolumns, columns)
        dvWidthOffice()
    End Sub
    Private Sub txtoffice_TextChanged(sender As Object, e As EventArgs) Handles txtoffice.TextChanged
        dgvOffice.Visible = True
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
    Private Sub txtoffice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtoffice.KeyDown
        If e.KeyCode = Keys.Down Then
            dgvOffice.Focus()
        ElseIf e.KeyCode = Keys.Up Then
            dgvOffice.Focus()
        ElseIf e.KeyCode = Keys.Enter Then
            Dim selectedRowIndex As Integer = dgvOffice.CurrentCell.RowIndex
            Dim value As String = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString()
            officeid = dgvOffice.CurrentRow.Cells("id").Value.ToString
            officedescription = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString
            officeaccronym = dgvOffice.CurrentRow.Cells("officeaccronym").Value.ToString
            txtoffice.Text = officedescription
            txtoffice.Text = value
            dgvOffice.Visible = False
            Label10.Text = officeid
            txtfirstname.Focus()
        End If
    End Sub
    Sub dvWidthOffice()
        Dim columnWidths As New Dictionary(Of String, Integer)()
        columnWidths.Add("officeaccronym", 100)
        Set_GridColWidth(columnWidths, dgvOffice)
    End Sub
    Private Sub dgvOffice_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvOffice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If dgvOffice.CurrentRow IsNot Nothing Then
                Dim selectedRow As DataGridViewRow = dgvOffice.CurrentRow
                officeid = selectedRow.Cells("id").Value.ToString
                officedescription = selectedRow.Cells("officedescription").Value.ToString
                officeaccronym = selectedRow.Cells("officeaccronym").Value.ToString
                txtoffice.Text = officedescription
                dgvOffice.Visible = False
                txtfirstname.Focus()
                Label10.Text = officeid
            End If
        ElseIf e.KeyCode = Keys.Back Then
            txtoffice.Focus()
        End If
    End Sub
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim SqlLoad As New MySQLCore
        Dim existingtluser As DataTable = SqlLoad.MySql_SelectString("id, username", "tl_users",, $"WHERE username = '{txtusername.Text}'")
        Dim existinggluser As DataTable = SqlLoad.MySql_SelectString("id, username", "gl_users",, $"WHERE username = '{txtusername.Text}'")
        If existingtluser.Rows.Count > 0 Then
            MessageBox.Show("Username already exists.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        ElseIf existinggluser.Rows.Count > 0 Then
            MessageBox.Show("Username already exists.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Add this User?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Dim HashPassword = MD5Password(txtpassword.Text)
                Dim user_colvals As New Dictionary(Of String, String)()
                user_colvals.Add("officeid", officeid)
                user_colvals.Add("officedescription", officedescription)
                user_colvals.Add("accesslevel", 3)
                user_colvals.Add("username", $"{txtusername.Text}")
                user_colvals.Add("hashpassword", HashPassword)
                user_colvals.Add("firstname", $"{txtfirstname.Text}")
                user_colvals.Add("middlename", $"{txtmiddlename.Text}")
                user_colvals.Add("lastname", $"{txtlastname.Text}")
                user_colvals.Add("jobposition", $"{txtposition.Text}")
                user_colvals.Add("user_status", $"PENDING")
                If IsAnyFieldEmpty() Then
                    MessageBox.Show("Please complete all fields.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                Else
                    If txtpassword.Text = txtrepassword.Text Then
                        SqlLoad.MySql_ExecuteNonQueryString("tl_users", user_colvals, Nothing, 1)
                        MessageBox.Show("Successfully Save")
                        textclear()
                        Me.Close()
                    Else
                        MsgBox("Password did not match")
                    End If
                End If
            End If
        End If
    End Sub
    Sub textclear()
        txtoffice.Text = ""
        txtfirstname.Text = ""
        txtmiddlename.Text = ""
        txtlastname.Text = ""
        txtposition.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtrepassword.Text = ""
    End Sub
    Private Function IsAnyFieldEmpty() As Boolean
        Return txtoffice.Text = "" OrElse
               txtfirstname.Text = "" OrElse
               txtmiddlename.Text = "" OrElse
               txtlastname.Text = "" OrElse
               txtposition.Text = "" OrElse
               txtusername.Text = "" OrElse
               txtpassword.Text = "" OrElse
               txtrepassword.Text = ""
    End Function
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PrivacyForm.ShowDialog()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        TermsAndConditionForm.ShowDialog()
    End Sub

    Private Sub dgvOffice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOffice.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvOffice.Rows(e.RowIndex)
            Dim value As String = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString()
            Variables.newofficedescription = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString
            Variables.newofficeid = selectedRow.Cells("id").Value.ToString()
            officeid = Variables.newofficeid
            officedescription = Variables.newofficedescription
            txtoffice.Text = value
            dgvOffice.Visible = False
            txtfirstname.Focus()
            Label10.Text = officeid
        End If
    End Sub
End Class