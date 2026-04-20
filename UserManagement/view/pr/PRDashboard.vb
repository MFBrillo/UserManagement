Public Class PRDashboard
    Public pr_budgetyear As Integer
    Public pr_registry As Integer
    Public OfficeDT As DataTable
    Public officeid As Integer
    Public officedescription As String
    Public officeaccronym As String
    Public accounttype As Integer
    Public prbalanceDT As DataTable
    Private normalFont As Font
    Private boldFont As Font
    Public addAccountDT As DataTable
    Private Sub PRDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Variables.login_accesslevel <> 3 Then
            txtOffice.Enabled = True
            load_officeAdmin()
        Else
            txtOffice.Enabled = False
            officeid = Variables.officeid
            load_offices()
        End If

        SetRegistry(2, "MAINTENANCE AND OTHER OPERATING EXPENSES")
        normalFont = New Font("Tahoma", 10.0F, FontStyle.Regular)
        boldFont = New Font(dgvPrRegular.Font, FontStyle.Bold)

        txtBudgetyear.Text = My.MySettings.Default.ServerYear
    End Sub
    Sub Custom_LoadOffice()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")
        dgvOffice.DataSource = OfficeDT
        Dim oldcolumns() = {"officedescription", "officeaccronym"}
        Dim columns() = {"Officename", "Accronym"}
        Dim cols() = {"id", "officeid", "subofficeid", "officetypeid", "sectorid", "aipofficeid", "mandatory_aipcode", "officecode_pbo", "is_spa", "officecode_acctg", "officeheadpersonnel", "officeheadpos", "officename", "officeadd", "officelevelid", "open_office", "logdate"}
        Datagrid_HideColumn(dgvOffice, cols)
        Datagrid_RenameColumn(dgvOffice, oldcolumns, columns)
        dvWidthOffice()
    End Sub
    Sub dvWidthOffice()
        Dim columnWidths As New Dictionary(Of String, Integer)()
        columnWidths.Add("officedescription", 606)
        columnWidths.Add("officeaccronym", 100)
        Set_GridColWidth(columnWidths, dgvOffice)
    End Sub
    Sub load_offices()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices",, $"where officeid={officeid}")
        txtOffice.Text = OfficeDT.Rows(0)("officedescription").ToString()
        Variables.officedescription = txtOffice.Text
    End Sub
    Sub load_officeAdmin()
        Dim SqlLoad As New MySQLCore
        OfficeDT = SqlLoad.MySql_SelectString("*", "gl_offices")

    End Sub

    Private Sub btnPS_Click(sender As Object, e As EventArgs)
        SetRegistry(1, "PERSONAL SERVICES")
    End Sub
    Private Sub btnMOOE_Click(sender As Object, e As EventArgs) Handles btnMOOE.Click
        SetRegistry(2, "MAINTENANCE AND OTHER OPERATING EXPENSES")

    End Sub
    Private Sub btnCO_Click(sender As Object, e As EventArgs) Handles btnCO.Click
        SetRegistry(3, "CAPITAL OUTLAY")
    End Sub
    Private Sub btnFE_Click(sender As Object, e As EventArgs) Handles btnFE.Click
        SetRegistry(4, "FINANCIAL EXPENSES")
    End Sub
    Private Sub txtOffice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOffice.KeyDown
        pnlOffice.Visible = True
        Custom_LoadOffice()
        If pnlOffice.Visible Then
            ShowPanelUnderTextBox(txtOffice, pnlOffice)
            Try
                If OfficeDT.Rows.Count > 0 Then
                    Dim conditions As New List(Of LinQCondition)()
                    conditions.Add(New LinQCondition With {
                    .Column = "officedescription",
                    .Value = txtOffice.Text,
                    .ComparisonType = ComparisonTypeEnum.Like_enum
                    })
                    conditions.Add(New LinQCondition With {
                    .Column = "officeaccronym",
                    .Value = txtOffice.Text,
                    .ComparisonType = ComparisonTypeEnum.Like_enum
                    })
                    Dim filteredDataTable1 As DataTable = Linq_Query(OfficeDT, conditions, useOrOperator:=True)
                    dgvOffice.DataSource = filteredDataTable1
                End If
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
        End If

        If e.KeyCode = Keys.Enter Then
            If dgvOffice.CurrentRow IsNot Nothing Then
                Dim selectedRow As DataGridViewRow = dgvOffice.CurrentRow
                officeid = selectedRow.Cells("id").Value.ToString
                officedescription = selectedRow.Cells("officedescription").Value.ToString
                officeaccronym = selectedRow.Cells("officeaccronym").Value.ToString
                txtOffice.Text = officedescription
                pnlOffice.Visible = False
            End If
        ElseIf e.KeyCode = Keys.Back Then
            txtOffice.Focus()
        End If
        If txtOffice.Text = "" Then
            pnlOffice.Visible = False
        End If
    End Sub
    Private Sub ShowPanelUnderTextBox(tb As Bunifu.Framework.UI.BunifuMetroTextbox, pnl As Panel)
        pnl.Parent = Me
        pnl.Dock = DockStyle.None

        Dim screenPoint = tb.Parent.PointToScreen(tb.Location)
        Dim formPoint = Me.PointToClient(screenPoint)

        pnl.Location = New Point(formPoint.X, formPoint.Y + tb.Height)
        pnl.Width = tb.Width
        pnl.BringToFront()
        pnl.Visible = True
    End Sub
    Private Sub SetRegistry(registryId As Integer, registryName As String)
        If My.MySettings.Default.ServerYear = "" Then
            txtBudgetyear.Text = Variables.ServerYear
        Else
            txtBudgetyear.Text = My.MySettings.Default.ServerYear
        End If
        pr_budgetyear = txtBudgetyear.Text
        txtRegistry.Text = registryName
        pr_registry = registryId

        If Variables.prDatatable Is Nothing Then
            Variables.prDatatable = New DataTable()
        Else
            Variables.prDatatable.Clear()
        End If
        LoadPRData()
        LoadPRDataSpecial()
    End Sub
    Public Sub LoadPRDataSpecial()
        Dim sql = New MySQLCore
        Dim pr_params As New Dictionary(Of String, String)()
        pr_params.Add("_budgetyear", pr_budgetyear)
        pr_params.Add("_accounttypeid", accounttype)
        pr_params.Add("_officeid", officeid)
        pr_params.Add("_registry", pr_registry)
        prbalanceDT = sql.MySQL_Datatable("reports_pbo_pr_AccountSpecial", pr_params)

        dgvPrSpecial.DataSource = prbalanceDT

        Add_GridButton(dgvPrSpecial, "Clear", "Clear", "btnclear", 1, 80)
        Add_GridButton(dgvPrSpecial, "Add", "Add", "btnadd", 0, 80)
        Add_GridButton(dgvPrSpecial, "Record", "Record", "btnrecord", dgvPrSpecial.Columns.Count, 80)
        dvWidthAccountSpecial()
        InitializeDataGridViewPPA()
    End Sub
    Public Sub LoadPRData()
        Dim sql = New MySQLCore
        Dim pr_params As New Dictionary(Of String, String)()
        pr_params.Add("_budgetyear", pr_budgetyear)
        pr_params.Add("accounttypeid", accounttype)
        pr_params.Add("_officeid", officeid)
        pr_params.Add("_registry", pr_registry)
        prbalanceDT = sql.MySQL_Datatable("reports_pbo_pr_Account", pr_params)

        dgvPrRegular.DataSource = prbalanceDT

        Add_GridButton(dgvPrRegular, "Clear", "Clear", "btnclear", 1, 80)
        Add_GridButton(dgvPrRegular, "Add", "Add", "btnadd", 0, 80)
        Add_GridButton(dgvPrRegular, "Record", "Record", "btnrecord", dgvPrRegular.Columns.Count, 80)
        dvWidthAccounts()
        InitializeDataGridView()
    End Sub
    Sub dvWidthAccounts()
        Dim cols() = {"approid", "ORIGIN", "officeid", "registryid", "acctid", "fundid", "REGISTRY", "REGISTRY CODE", "subcategoryid", "accountdescription", "EXPENSE ACCT.", "APPROPRIATION", "AUG. TO", "AUG. FROM", "SUPPLEMENTAL BUDGET", "ALLOTMENT", "OBLIGATION", "DISBURSEMENT"}
        Datagrid_HideColumn(dgvPrRegular, cols)
        Dim colWidths As New Dictionary(Of String, Integer) From
        {
            {"BUDGET YEAR", 40},
            {"ACCOUNT CODE", 50},
            {"ACCOUNTS", 300},
            {"UNOBLIGATED BALANCE", 80},
            {"PURCHASE REQUEST", 100},
            {"CURRENT BALANCE", 100},
            {"btnclear", 100},
            {"btnadd", 100},
            {"btnrecord", 200}
        }
        Set_GridColWidth(colWidths, dgvPrRegular)
        For Each row As DataGridViewRow In dgvPrRegular.Rows
            row.Cells("UNOBLIGATED BALANCE").Style.Format = "N2"
            row.Cells("PURCHASE REQUEST").Style.Format = "N2"
            row.Cells("CURRENT BALANCE").Style.Format = "N2"
            row.Cells("UNOBLIGATED BALANCE").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("PURCHASE REQUEST").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("CURRENT BALANCE").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("BUDGET YEAR").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Sub dvWidthAccountSpecial()
        Dim cols() = {"approid", "ORIGIN", "officeid", "registryid", "spcfundid", "fundid", "REGISTRY", "REGISTRY CODE", "transidprogram", "APPROPRIATION", "ALLOTMENT", "OBLIGATION", "DISBURSEMENT", "AUG. TO", "AUG. FROM", "SUPPLEMENTAL BUDGET"}
        Datagrid_HideColumn(dgvPrSpecial, cols)
        Dim colWidths As New Dictionary(Of String, Integer) From
        {
            {"BUDGET YEAR", 40},
            {"AIP CODE", 90},
            {"AIP", 300},
            {"UNOBLIGATED BALANCE", 80},
            {"PURCHASE REQUEST", 80},
            {"CURRENT BALANCE", 80},
            {"btnclear", 100},
            {"btnadd", 100},
            {"btnrecord", 200}
        }
        Set_GridColWidth(colWidths, dgvPrSpecial)
        For Each row As DataGridViewRow In dgvPrSpecial.Rows
            row.Cells("UNOBLIGATED BALANCE").Style.Format = "N2"
            row.Cells("PURCHASE REQUEST").Style.Format = "N2"
            row.Cells("CURRENT BALANCE").Style.Format = "N2"
            row.Cells("UNOBLIGATED BALANCE").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("PURCHASE REQUEST").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("CURRENT BALANCE").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("BUDGET YEAR").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Private Sub txtBudgetyear_KeyPress(sender As Object, e As KeyPressEventArgs) _
    Handles txtBudgetyear.KeyPress
        txtBudgetyear.MaxLength = 4
        ' Allow numbers and control keys (Backspace, Delete, etc.)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        SelectAccount(btnAccount.Name)
    End Sub
    Private Sub btnPPA_Click(sender As Object, e As EventArgs) Handles btnPPA.Click
        SelectAccount(btnPPA.Name)
    End Sub
    Public Sub loadPRSpecial()
        If txtBudgetyear.Text = "" Then
            MsgBox("Please input year")
        Else
            pr_budgetyear = txtBudgetyear.Text
        End If
        btnAccount.selected = False
        btnPPA.selected = True
        accounttype = 2
        LoadPRDataSpecial()
    End Sub
    Public Sub loadPR()

        If txtBudgetyear.Text = "" Then
            MsgBox("Please input year")
        Else
            pr_budgetyear = txtBudgetyear.Text
        End If
        btnAccount.selected = True
        btnPPA.selected = False
        accounttype = 1
        LoadPRData()
    End Sub

    Private Sub dgvOffice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOffice.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvOffice.Rows(e.RowIndex)
            Dim value As String = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString()
            Variables.newofficedescription = dgvOffice.CurrentRow.Cells("officedescription").Value.ToString
            Variables.newofficeid = selectedRow.Cells("id").Value.ToString()
            officeid = Variables.newofficeid
            officedescription = Variables.newofficedescription
            txtOffice.Text = value
            pnlOffice.Visible = False
        End If
    End Sub
    Private Sub dgvPrRegular_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
         Handles dgvPrRegular.CellClick
        ' Ignore header clicks
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        Dim SqlLoad As New MySQLCore
        Dim dgv = CType(sender, DataGridView)
        Dim colName = dgv.Columns(e.ColumnIndex).Name
        Dim row = dgv.Rows(e.RowIndex)

        ' ADD button → Bold row
        If colName = "btnadd" Then
            My.MySettings.Default.AccountType = 1
            row.DefaultCellStyle.Font = boldFont
            row.DefaultCellStyle.ForeColor = Color.White
            row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 173, 5)

            Dim approid = row.Cells("approid").Value.ToString
            Dim existingRow As DataRow() = Variables.prDatatable.Select($"approid = '{approid}'")
            If existingRow.Length > 0 Then
                MessageBox.Show("This account is already added!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim acctid = row.Cells("acctid").Value.ToString
            Dim registryid = row.Cells("registryid").Value.ToString
            Dim fundid = row.Cells("fundid").Value.ToString
            Dim account = row.Cells("ACCOUNTS").Value.ToString
            Dim accountcode = row.Cells("ACCOUNT CODE").Value.ToString
            Dim total_appro = row.Cells("APPROPRIATION").Value.ToString
            Dim allo_balance = row.Cells("UNOBLIGATED BALANCE").Value.ToString
            Dim pr = "0" + row.Cells("PURCHASE REQUEST").Value.ToString
            Dim currentbalance = row.Cells("CURRENT BALANCE").Value.ToString

            Variables.prDatatable.Rows.Add(approid, officeid, acctid, registryid, fundid, account, accountcode, total_appro, allo_balance, pr, currentbalance)
            My.MySettings.Default.Save()
            ' CLEAR button → Regular row
        ElseIf colName = "btnclear" Then

            Dim approid As String = row.Cells("approid").Value.ToString()

            Dim rows = Variables.prDatatable.Select($"approid = '{approid.Replace("'", "''")}'")
            For Each r As DataRow In rows
                Variables.prDatatable.Rows.Remove(r)
            Next
            row.DefaultCellStyle.Font = normalFont
            row.DefaultCellStyle.ForeColor = Color.Black
            row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(240, 240, 240)
        ElseIf colName = "btnrecord" Then
            My.MySettings.Default.AccountType = 1
            Variables.pr_approid = row.Cells("approid").Value.ToString
            Variables.pr_account = row.Cells("ACCOUNTS").Value.ToString
            Variables.pr_accountcode = row.Cells("ACCOUNT CODE").Value.ToString

            Opaque.Show()
            PRDetail.ShowDialog()
        End If
    End Sub
    Private Sub dgvPrSpecial_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrSpecial.CellClick
        ' Ignore header clicks
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        Dim SqlLoad As New MySQLCore
        Dim dgv = CType(sender, DataGridView)
        Dim colName = dgv.Columns(e.ColumnIndex).Name
        Dim row = dgv.Rows(e.RowIndex)

        If colName = "btnadd" Then
            My.MySettings.Default.AccountType = 2
            row.DefaultCellStyle.Font = boldFont
            row.DefaultCellStyle.ForeColor = Color.White
            row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(245, 173, 5)

            Dim approid = row.Cells("approid").Value.ToString
            Dim existingRow As DataRow() = Variables.prDatatable.Select($"approid = '{approid}'")
            If existingRow.Length > 0 Then
                MessageBox.Show("This account is already added!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim registryid = row.Cells("registryid").Value.ToString
            Dim spcfundid = row.Cells("spcfundid").Value.ToString
            Dim transidprogram = row.Cells("transidprogram").Value.ToString
            Dim aip = row.Cells("AIP").Value.ToString
            Dim aipcode = row.Cells("AIP CODE").Value.ToString
            Dim total_appro = row.Cells("APPROPRIATION").Value.ToString
            Dim allo_balance = row.Cells("UNOBLIGATED BALANCE").Value.ToString
            Dim pr = "0" + row.Cells("PURCHASE REQUEST").Value.ToString
            Dim currentbalance = row.Cells("CURRENT BALANCE").Value.ToString

            Variables.prDatatable.Rows.Add(approid, officeid, registryid, spcfundid, transidprogram, aip, aipcode, total_appro, allo_balance, pr, currentbalance)
            ' CLEAR button → Regular row

            My.MySettings.Default.Save()

        ElseIf colName = "btnclear" Then

            Dim approid As String = row.Cells("approid").Value.ToString()

            Dim rows = Variables.prDatatable.Select($"approid = '{approid.Replace("'", "''")}'")
            For Each r As DataRow In rows
                Variables.prDatatable.Rows.Remove(r)
            Next
            row.DefaultCellStyle.Font = normalFont
            row.DefaultCellStyle.ForeColor = Color.Black
            row.DefaultCellStyle.BackColor = Drawing.Color.FromArgb(240, 240, 240)
        ElseIf colName = "btnrecord" Then
            My.MySettings.Default.AccountType = 2
            Variables.pr_approid = row.Cells("approid").Value.ToString
            Variables.pr_account = row.Cells("AIP").Value.ToString
            Variables.pr_accountcode = row.Cells("AIP CODE").Value.ToString

            Opaque.Show()
            PRDetail.ShowDialog()
        End If
    End Sub
    Public Sub InitializeDataGridView()
        Variables.prDatatable = New DataTable
        Variables.prDatatable.Columns.Add("approid", GetType(Integer))
        Variables.prDatatable.Columns.Add("officeid", GetType(Integer))
        Variables.prDatatable.Columns.Add("acctid", GetType(String))
        Variables.prDatatable.Columns.Add("registryid", GetType(Integer))
        Variables.prDatatable.Columns.Add("fundid", GetType(Integer))
        Variables.prDatatable.Columns.Add("ACCOUNTS", GetType(String))
        Variables.prDatatable.Columns.Add("ACCOUNT CODE", GetType(String))
        Variables.prDatatable.Columns.Add("APPROPRIATION", GetType(Decimal))
        Variables.prDatatable.Columns.Add("UNOBLIGATED BALANCE", GetType(Decimal))
        Variables.prDatatable.Columns.Add("PURCHASE REQUEST", GetType(Decimal))
        Variables.prDatatable.Columns.Add("CURRENT BALANCE", GetType(Decimal))
    End Sub
    Public Sub InitializeDataGridViewPPA()
        Variables.prDatatable = New DataTable
        Variables.prDatatable.Columns.Add("approid", GetType(Integer))
        Variables.prDatatable.Columns.Add("officeid", GetType(Integer))
        Variables.prDatatable.Columns.Add("registryid", GetType(Integer))
        Variables.prDatatable.Columns.Add("spcfundid", GetType(String))
        Variables.prDatatable.Columns.Add("transidprogram", GetType(Integer))
        Variables.prDatatable.Columns.Add("AIP", GetType(String))
        Variables.prDatatable.Columns.Add("AIP CODE", GetType(String))
        Variables.prDatatable.Columns.Add("APPROPRIATION", GetType(Decimal))
        Variables.prDatatable.Columns.Add("UNOBLIGATED BALANCE", GetType(Decimal))
        Variables.prDatatable.Columns.Add("PURCHASE REQUEST", GetType(Decimal))
        Variables.prDatatable.Columns.Add("CURRENT BALANCE", GetType(Decimal))
    End Sub
    Private Sub btnPR_Click(sender As Object, e As EventArgs) Handles btnPR.Click
        If Variables.prDatatable Is Nothing OrElse Variables.prDatatable.Rows.Count = 0 Then
            MsgBox("Please select account")
        Else
            Opaque.Show()
            PRAmount.ShowDialog()
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        searchAccounts()
    End Sub
    Sub searchAccounts()
        If dgvPrRegular.Rows.Count > 0 Then
            Dim conditions As New List(Of LinQCondition) From {
            New LinQCondition With {
                .Column = "ACCOUNTS",
                .Value = txtsearch.Text,
                .ComparisonType = ComparisonTypeEnum.Like_enum
            }
        }
            Dim SearchDT As DataTable = Linq_Query(prbalanceDT, conditions)
            dgvPrRegular.DataSource = SearchDT
        Else
            Remove_GridButton(dgvPrRegular, "btnclear")
            Remove_GridButton(dgvPrRegular, "btnadd")
            Remove_GridButton(dgvPrRegular, "btnrecord")
            LoadPRData()
        End If
        dvWidthAccounts()
    End Sub
    Private Sub txtsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsearch.KeyPress
        'If e.KeyChar = Convert.ToChar(Keys.Enter) Then
        '    e.Handled = True
        '    searchAccounts()
        'End If
    End Sub
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        Opaque.Show()
        PRRecord.ShowDialog()
    End Sub
    Private Sub txtBudgetyear_OnValueChanged(sender As Object, e As EventArgs) Handles txtBudgetyear.OnValueChanged
        My.MySettings.Default.ServerYear = txtBudgetyear.Text
        My.MySettings.Default.Save()
    End Sub
    Sub SelectAccount(ByVal sender As String)
        Select Case sender
            Case "btnAccount"
                Variables.prDatatable.Clear()

                loadPR()
                dgvPrRegular.Visible = True
                dgvPrRegular.Dock = DockStyle.Fill
                dgvPrSpecial.Visible = False
                My.MySettings.Default.AccountType = 1
                My.MySettings.Default.Save()
            Case "btnPPA"
                Variables.prDatatable.Clear()

                loadPRSpecial()
                dgvPrSpecial.Visible = True
                dgvPrSpecial.Dock = DockStyle.Fill
                dgvPrRegular.Visible = False
                My.MySettings.Default.AccountType = 2
                My.MySettings.Default.Save()
        End Select

    End Sub


End Class
