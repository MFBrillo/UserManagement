Public Class EditUser
    Dim userid As Integer
    Dim usersDT As DataTable
    Public OfficeDT As DataTable
    Dim passwordenable As Boolean = False
    Dim SelectedOfficeID As Integer = -1
    Public officeaccronym As String
    Private Sub lblclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblclose.LinkClicked
        Opaque.Close()
        Me.Close()
        Main.Activate()
    End Sub
    Sub loaddata()
        Dim SqlLoad As New MySQLCore
        userid = Variables.id
        usersDT = SqlLoad.MySql_SelectString("*", "tl_users", "", $"where id = {userid}")
        txtoffice.Text = usersDT.Rows(0)("officedescription").ToString()
        txtfirstname.Text = usersDT.Rows(0)("firstname").ToString()
        txtmiddlename.Text = usersDT.Rows(0)("middlename").ToString()
        txtlastname.Text = usersDT.Rows(0)("lastname").ToString()
        txtposition.Text = usersDT.Rows(0)("jobposition").ToString()
        txtusername.Text = usersDT.Rows(0)("username").ToString()
        Variables.oldofficedescription = usersDT.Rows(0)("officedescription").ToString()
        Variables.oldofficeid = usersDT.Rows(0)("officeid").ToString()

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
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub btnchangepassword_Click(sender As Object, e As EventArgs) Handles btnchangepassword.Click
        If lblStatus.Text = "Not Change Password" Then
            lblStatus.Text = "Change Password"
            txtpassword.Enabled = True
            txtrepassword.Enabled = True
            passwordenable = True
            Variables.newHashpassword = True
        Else
            lblStatus.Text = "Not Change Password"
            txtpassword.Enabled = False
            txtrepassword.Enabled = False
            passwordenable = False
            Variables.newHashpassword = False
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Update this data?", "Update User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim SqlLoad As New MySQLCore
            Dim user_colvals As New Dictionary(Of String, String)()
            Variables.username = txtusername.Text
            Variables.firstname = txtfirstname.Text
            Variables.middlename = txtmiddlename.Text
            Variables.lastname = txtlastname.Text
            Variables.jobposition = txtposition.Text

            Dim HashPassword = MD5Password(txtpassword.Text)
            Variables.hashpassword = HashPassword
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
    Private Function IsAnyFieldEmpty() As Boolean
        Return txtpassword.Text = "" OrElse
               txtrepassword.Text = ""
    End Function
    Private Sub txtoffice_MouseClick(sender As Object, e As MouseEventArgs) Handles txtoffice.MouseClick
        dgvOffice.Visible = True
        Custom_LoadOffice()
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
            txtoffice.Text = value
            dgvOffice.Visible = False
            txtfirstname.Focus()
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

    Private Sub dgvOffice_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvOffice.CellMouseClick
        Dim selectedRowIndex As Integer = dgvOffice.CurrentCell.RowIndex
        Dim value As String = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString()
        Variables.newofficeid = dgvOffice.CurrentRow.Cells("id").Value.ToString
        Variables.newofficedescription = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString
        officeaccronym = dgvOffice.CurrentRow.Cells("officeaccronym").Value.ToString
        txtoffice.Text = value
        dgvOffice.Visible = False
        txtfirstname.Focus()
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