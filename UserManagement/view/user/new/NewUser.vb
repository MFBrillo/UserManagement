Public Class NewUser
    Public UsersDT As DataTable
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Custom_LoadUsers()
        LoadOffices()
        Dim img1 As Image = My.Resources.approve
        Dim img2 As Image = My.Resources.edit
        Dim img3 As Image = My.Resources.delete
        Add_GridAutoNumber(dgvUsers, "No", "colNo", 0, 10)
        Add_GridButtonWithImage(dgvUsers, "Approve", "", "btnApprove", dgvUsers.Columns.Count, img1, 10, Color.FromArgb(24, 37, 63))
        Add_GridButtonWithImage(dgvUsers, "Edit", "", "btnEdit", dgvUsers.Columns.Count, img2, 10, Color.FromArgb(26, 188, 156))
        Add_GridButtonWithImage(dgvUsers, "Delete", "", "btnDelete", dgvUsers.Columns.Count, img3, 10, Color.Red)
        Dim oldcolumns() = {"username", "firstname", "middlename", "lastname", "officeid", "user_status"}
        Dim columns() = {"Username", "Firstname", "Middlename", "Lastname", "Office", "Status"}
        Dim cols() = {"id", "hashpassword", "designation", "jobposition", "accesslevel", "pcname", "is_login", "logdate"}
        Datagrid_HideColumn(dgvUsers, cols)
        Datagrid_RenameColumn(dgvUsers, oldcolumns, columns)
        dvWidthUsers()
    End Sub
    Sub Custom_LoadUsers()
        Dim SqlLoad As New MySQLCore
        UsersDT = SqlLoad.MySql_SelectString("id,username,hashpassword,firstname,middlename,lastname,accesslevel,officeid,designation,jobposition,pcname,is_login,user_status", "tl_users", "", $"where user_status != 'APPROVED'")
        dgvUsers.DataSource = UsersDT
    End Sub
    Sub dvWidthUsers()
        Dim columnWidths As New Dictionary(Of String, Integer)()
        columnWidths.Add("colNo", 30)
        columnWidths.Add("username", 80)
        columnWidths.Add("firstname", 120)
        columnWidths.Add("middlename", 80)
        columnWidths.Add("lastname", 80)
        columnWidths.Add("jobposition", 80)
        columnWidths.Add("user_status", 60)
        columnWidths.Add("officeid", 300)
        columnWidths.Add("btnApprove", 40)
        columnWidths.Add("btnEdit", 40)
        columnWidths.Add("btnDelete", 40)
        Set_GridColWidth(columnWidths, dgvUsers)
    End Sub
    Dim officeid As Integer, accesslevel As Integer, id As Integer
    Dim username As String, hashpassword As String, firstname As String, middlename As String, lastname As String, jobposition As String
    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        Dim SqlLoad As New MySQLCore
        Dim grid = DirectCast(dgvUsers, DataGridView)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)
            officeid = row.Cells("officeid").Value.ToString()
            username = row.Cells("username").Value.ToString()
            hashpassword = row.Cells("hashpassword").Value.ToString()
            firstname = row.Cells("firstname").Value.ToString()
            middlename = row.Cells("middlename").Value.ToString()
            lastname = row.Cells("lastname").Value.ToString()
            jobposition = row.Cells("jobposition").Value.ToString()
            Variables.id = grid.Rows(e.RowIndex).Cells("id").Value.ToString
            If dgvUsers.Columns(e.ColumnIndex).Name = "btnApprove" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to Approve this User?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If result = DialogResult.OK Then
                    Dim columnWidths As New Dictionary(Of String, String)()
                    columnWidths.Add("officeid", officeid)
                    columnWidths.Add("accesslevel", 3)
                    columnWidths.Add("username", username)
                    columnWidths.Add("hashpassword", hashpassword)
                    columnWidths.Add("firstname", firstname)
                    columnWidths.Add("middlename", middlename)
                    columnWidths.Add("lastname", lastname)
                    columnWidths.Add("jobposition", jobposition)
                    SqlLoad.MySql_ExecuteNonQueryString("gl_users", columnWidths, Nothing, 1)
                    Dim whereclause As String = $"id = { Variables.id}"

                    'Dim columnWidths2 As New Dictionary(Of String, String)()
                    'columnWidths.Add("user_status", $"APPROVED")
                    'SqlLoad.MySql_ExecuteNonQueryString("tl_users", columnWidths, whereclause, 2)

                    SqlLoad.MySql_Delete("tl_users", whereclause)
                    MessageBox.Show("Succefully Added to Database")
                    Custom_LoadUsers()
                End If
            ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "btnEdit" Then
                Opaque.Show()
                Dim result As DialogResult = EditUser.ShowDialog()
                If result = DialogResult.OK Then
                    Opaque.Close()
                    Dim user_colvals As New Dictionary(Of String, String)()
                    user_colvals.Add("username", $"{Variables.username}")
                    user_colvals.Add("firstname", $"{Variables.firstname}")
                    user_colvals.Add("middlename", $"{Variables.middlename}")
                    user_colvals.Add("lastname", $"{Variables.lastname}")
                    user_colvals.Add("jobposition", $"{Variables.jobposition}")
                    If Variables.newHashpassword = True Then
                        user_colvals.Add("hashpassword", $"{Variables.hashpassword}")
                    ElseIf Variables.oldofficeid <> Variables.newofficeid Then
                        user_colvals.Add("officeid", $"{Variables.newofficeid}")
                        user_colvals.Add("officedescription", $"{Variables.newofficedescription}")
                    ElseIf Variables.oldofficeid = Variables.newofficeid Then
                        user_colvals.Add("officeid", $"{Variables.oldofficeid}")
                        user_colvals.Add("officedescription", $"{Variables.oldofficedescription}")
                    End If
                    SqlLoad.MySql_ExecuteNonQueryString("tl_users", user_colvals, $"id={Variables.id}", 2)
                    MessageBox.Show("Successfully Update", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Custom_LoadUsers()
                End If
            ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "btnDelete" Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this User?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    SqlLoad.MySql_Delete("tl_users", $"id={Variables.id}")
                    MessageBox.Show("Succefully Deleted")
                    FormShowUserControlUser(New NewUser, New UserManagement)
                    Custom_LoadUsers()
                End If
            End If
        End If
    End Sub
    Dim officeMap As New Dictionary(Of Integer, String)
    Sub LoadOffices()
        Dim SqlLoad As New MySQLCore
        UsersDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        officeMap.Clear()
        For Each row As DataRow In UsersDT.Rows
            officeMap.Add(CInt(row("officeid")), row("officedescription").ToString())
        Next
    End Sub
    Private Sub dgvUsers_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvUsers.CellFormatting
        If dgvUsers.Columns(e.ColumnIndex).Name = "officeid" AndAlso e.Value IsNot Nothing Then
            Dim id As Integer = CInt(e.Value)
            If officeMap.ContainsKey(id) Then
                e.Value = officeMap(id)
                e.FormattingApplied = True
            End If
        End If
    End Sub
End Class
