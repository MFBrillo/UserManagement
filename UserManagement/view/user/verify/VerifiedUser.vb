Public Class VerifiedUser
    Public OfficeDT As DataTable
    Public UsersDT As DataTable
    Public manualaccessLevels As String = "3"
    Private Sub VerifiedUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadUsers()
        LoadOffices()
        LoadStatus()
        Dim img2 As Image = My.Resources.edit
        Dim img3 As Image = My.Resources.delete
        Add_GridAutoNumber(dgvUsers, "No", "colNo", 0, 30)
        Add_GridButtonWithImage(dgvUsers, "Edit", "", "btnEdit", dgvUsers.Columns.Count, img2, 70, Color.FromArgb(26, 188, 156))
        Add_GridButtonWithImage(dgvUsers, "Delete", "", "btnDelete", dgvUsers.Columns.Count, img3, 70, Color.Red)
        Dim oldcolumns() = {"username", "firstname", "middlename", "lastname", "accesslevel", "officeid"}
        Dim columns() = {"Username", "Firstname", "Middlename", "Lastname", "Level", "Office"}
        Dim cols() = {"id", "hashpassword", "designation", "jobposition", "pcname", "is_login", "logdate"}
        Datagrid_HideColumn(dgvUsers, cols)
        Datagrid_RenameColumn(dgvUsers, oldcolumns, columns)
        dvWidthUsers()
    End Sub
    Sub Custom_LoadUsers()
        If Variables.login_accesslevel > 1 Then
            cbadmin.Visible = False
            lbladmin.Visible = False
        Else
            cbadmin.Visible = True
            lbladmin.Visible = True
        End If

        If cbencoder.Checked And cbverifier.Checked And cbadmin.Checked Then
            manualaccessLevels = "1,2,3"
        ElseIf cbencoder.Checked And cbverifier.Checked Then
            manualaccessLevels = "2,3"
        ElseIf cbencoder.Checked Then
            manualaccessLevels = "3"
        End If
        Dim SqlLoad As New MySQLCore
        UsersDT = SqlLoad.MySql_SelectString("id,username,hashpassword,firstname,middlename,lastname,accesslevel,officeid,designation,jobposition,pcname,is_login", "gl_users",, $"where accesslevel IN ({manualaccessLevels})")
        dgvUsers.DataSource = UsersDT
    End Sub
    Sub dvWidthUsers()
        Dim columnWidths As New Dictionary(Of String, Integer)()
        columnWidths.Add("colNo", 30)
        columnWidths.Add("username", 100)
        columnWidths.Add("firstname", 100)
        columnWidths.Add("middlename", 100)
        columnWidths.Add("lastname", 100)
        columnWidths.Add("accesslevel", 80)
        columnWidths.Add("btnEdit", 50)
        If Variables.login_accesslevel = 1 Then
            columnWidths.Add("btnDelete", 50)
        End If
        Set_GridColWidth(columnWidths, dgvUsers)
    End Sub
    Dim officeMap As New Dictionary(Of Integer, String)
    Dim usereMap As New Dictionary(Of Integer, String)
    Sub LoadOffices()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        officeMap.Clear()
        For Each row As DataRow In OfficeDT.Rows
            officeMap.Add(CInt(row("officeid")), row("officedescription").ToString())
        Next
    End Sub
    Sub LoadStatus()
        Dim SqlLoad As New MySQLCore
        UsersDT = SqlLoad.MySql_SelectString("*", "gl_users_accesslevel")
        usereMap.Clear()
        For Each row As DataRow In UsersDT.Rows
            usereMap.Add(CInt(row("id")), row("accessname").ToString())
        Next
    End Sub
    Private Sub dgvUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsers.CellFormatting
        If dgvUsers.Columns(e.ColumnIndex).Name = "accesslevel" AndAlso e.Value IsNot Nothing Then
            Dim id As Integer = CInt(e.Value)
            If usereMap.ContainsKey(id) Then
                e.Value = usereMap(id)
                e.FormattingApplied = True
            End If
            e.FormattingApplied = True
        ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "officeid" AndAlso e.Value IsNot Nothing Then
            Dim id As Integer = CInt(e.Value)
            If officeMap.ContainsKey(id) Then
                e.Value = officeMap(id)
                e.FormattingApplied = True
            End If
        End If
    End Sub
    Dim userid As Integer
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim SqlLoad As New MySQLCore
        Dim grid = DirectCast(dgvUsers, DataGridView)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            Variables.id = grid.Rows(e.RowIndex).Cells("id").Value.ToString
            If dgvUsers.Columns(e.ColumnIndex).Name = "btnDelete" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this User?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    SqlLoad.MySql_Delete("gl_users", $"id={userid}")
                    MessageBox.Show("Succefully Deleted")
                    FormShowUserControlUser(New VerifiedUser, New UserManagement)
                    Custom_LoadUsers()
                End If
            ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "btnEdit" Then
                Opaque.Show()
                Dim result As DialogResult
                Using frm As New EditVerifiedUser()
                    result = frm.ShowDialog()
                End Using
                If result = DialogResult.OK Then
                    Dim columnWidths As New Dictionary(Of String, String)()
                    columnWidths.Add("officeid", Variables.newofficeid)
                    columnWidths.Add("firstname", Variables.firstname)
                    columnWidths.Add("middlename", Variables.middlename)
                    columnWidths.Add("lastname", Variables.lastname)
                    columnWidths.Add("jobposition", Variables.jobposition)
                    columnWidths.Add("accesslevel", Variables.accesslevel)

                    SqlLoad.MySql_ExecuteNonQueryString("gl_users", columnWidths, $"id ={Variables.id}", 2)
                    CustomMsg("Update User", "User Information Successfully Updated")
                    Custom_LoadUsers()
                End If
            End If
        End If
    End Sub
    Private Sub cbencoder_OnChange(sender As Object, e As EventArgs) Handles cbencoder.OnChange
        If cbencoder.Checked = False Then
            cbverifier.Checked = False
            cbadmin.Checked = False
        End If
        cbencoder.Checked = True
        Custom_LoadUsers()
    End Sub
    Private Sub cbverifier_OnChange(sender As Object, e As EventArgs) Handles cbverifier.OnChange
        If cbverifier.Checked = False Then
            cbadmin.Checked = False
        End If
        cbencoder.Checked = True
        Custom_LoadUsers()
    End Sub
    Private Sub cbadmin_OnChange(sender As Object, e As EventArgs) Handles cbadmin.OnChange
        cbencoder.Checked = True
        cbverifier.Checked = True
        Custom_LoadUsers()
    End Sub
    Private Sub Txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Custom_LoadUsers()
        If UsersDT IsNot Nothing AndAlso UsersDT.Rows.Count > 0 Then
            Dim conditions As New List(Of LinQCondition)()
            conditions.Add(New LinQCondition With {
                .Column = "username",
                .Value = txtsearch.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
                })
            Dim filteredDataTable1 As DataTable = Linq_Query(UsersDT, conditions, useOrOperator:=True)
            If filteredDataTable1 IsNot Nothing AndAlso filteredDataTable1.Rows.Count > 0 Then
                dgvUsers.DataSource = filteredDataTable1
            Else
                Exit Sub
            End If
        Else
            MsgBox("No data found in UsersDT")
            Exit Sub
        End If

    End Sub

End Class
