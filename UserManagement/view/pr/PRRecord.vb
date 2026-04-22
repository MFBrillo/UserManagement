Public Class PRRecord
    Dim prdataDT As DataTable
    Dim statusDT As DataTable
    Dim prdataIDDT As DataTable
    Dim officeDT As DataTable

    Dim officeid As Integer
    Dim officename As String
    Dim officeaccronym As String

    Dim prnumber As String
    Public prstatus As String
    Public officedescription As String
    Dim spcfundsDT As DataTable
    Dim aip As Boolean
    Dim prdataid_id As Integer
    Dim statusText As String

    Dim statusCheck As String
    Private Sub PRRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formload()
    End Sub
    Sub formload()
        Dim grid As DataGridView = DirectCast(dgvDataID, DataGridView)
        If Variables.login_accesslevel <> 3 Then
            txtSearch.Enabled = True
            loadAdmin()
            loadStatus()
            btndelete.Enabled = True
            btnsave.Enabled = True

        Else
            txtOffice.Text = Variables.officedescription
            txtSearch.Enabled = False
            load_load()
            dvWidthDataPPA()
        End If

        txtStatus.Text = grid.Rows(0).Cells("status").Value.ToString
        dvWidthDataID()
    End Sub

    Sub load_load()
        loadPRDataID()
        loadPRDataPPA()
    End Sub
    Sub formclose()
        Opaque.Close()
        Me.Close()
        Main.Activate()
        Dim uc = New PRDashboard
        Main.ShowUserControl(uc)
        uc.loadPR()
    End Sub
    Sub loadStatus()
        Dim SqlLoad As New MySQLCore
        statusDT = SqlLoad.MySql_SelectString("*", "gov_status")
        prstatus = statusDT.Rows(0)("prstatus").ToString()
        If Variables.login_accesslevel = 2 Then
            Dim dv As New DataView(statusDT)
            dv.RowFilter = "id IN (1,2)"
            Custom_ComboBoxDatasource(cbbstatus, dv.ToTable(), "prstatus", "prstatus")
        Else
            Dim dv As New DataView(statusDT)
            dv.RowFilter = "id IN (1,2,3)"
            Custom_ComboBoxDatasource(cbbstatus, dv.ToTable(), "prstatus", "prstatus")
        End If

    End Sub
    Sub loadOffice()
        Dim SqlLoad As New MySQLCore
        officeDT = SqlLoad.MySql_SelectString("officedescription, officeaccronym", "gl_offices",, $"where officeid={officeid}")
        officename = officeDT.Rows(0)("officedescription").ToString()
    End Sub
    Sub loadAdmin()
        Dim SqlLoad As New MySQLCore

        prdataIDDT = SqlLoad.MySql_SelectString("g.*, o.officeaccronym AS Office", "gov_prdata_id g", "LEFT JOIN gl_offices o On g.officeid = o.officeid", $"where YEAR(g.logdate) = {My.MySettings.Default.ServerYear} ORDER BY g.id DESC")

        dgvDataID.DataSource = prdataIDDT

        Dim oldcolumns() = {"Office", "prnumber", "purpose", "totalamount", "budgetyear", "status"}
        Dim columns() = {"Office", "PR Number", "Purpose", "Total", "Budget Year", "Status"}
        Dim cols() = {"id", "userid", "officeid", "reviewofficerid", "approvalofficerid", "accounttype", "transdate", "datetimeupdate", "logdate"}

        dgvDataID.Columns("Office").DisplayIndex = 0
        Datagrid_HideColumn(dgvDataID, cols)
        Datagrid_RenameColumn(dgvDataID, oldcolumns, columns)
        dvWidthDataPPA()
    End Sub
    Sub loadPRData()
        Dim SqlLoad As New MySQLCore
        prdataDT = SqlLoad.MySql_SelectString("*", "gov_prdata",, $"where prnumber='{prnumber}'")
        dgvRegularData.DataSource = prdataDT
        Dim oldcolumns() = {"account", "accountcode", "allo_balance", "pr_amount"}
        Dim columns() = {"Account", "Account Code", "Balance befor PR", "PR Amount"}
        Dim cols() = {"id", "approid", "acctid", "officeid", "prnumber", "purpose", "registryid", "fundid", "prstatus", "spcfundid", "transidprogram", "total_apro", "obligated_amount", "remaining_balance", "total_appro", "aip", "aipcode", "verify_by", "verify_position", "logdate"}
        Add_GridButton(dgvRegularData, "Print", "Print", "btnPrint", dgvRegularData.Columns.Count, 80)
        Datagrid_HideColumn(dgvRegularData, cols)
        Datagrid_RenameColumn(dgvRegularData, oldcolumns, columns)
    End Sub
    Sub loadPRDataPPA()
        Dim SqlLoad As New MySQLCore
        prdataDT = SqlLoad.MySql_SelectString("*", "gov_prdata",, $"where prnumber='{prnumber}'")
        dgvPPAData.DataSource = prdataDT
        Dim oldcolumns() = {"aip", "aipcode", "allo_balance", "pr_amount"}
        Dim columns() = {"AIP", "AIP Code", "Balance befor PR", "PR Amount"}
        Dim cols() = {"id", "approid", "acctid", "officeid", "prnumber", "purpose", "registryid", "prstatus", "fundid", "spcfundid", "transidprogram", "total_apro", "obligated_amount", "remaining_balance", "total_appro", "account", "accountcode", "verify_by", "verify_position", "logdate"}
        Add_GridButton(dgvPPAData, "Print", "Print", "btnPrint", dgvPPAData.Columns.Count, 80)
        Datagrid_HideColumn(dgvPPAData, cols)
        Datagrid_RenameColumn(dgvPPAData, oldcolumns, columns)
    End Sub
    Sub dvWidthData()
        Dim colWidths As New Dictionary(Of String, Integer) From
   {
       {"btnPrint", 105},
       {"prstatus", 130},
       {"accountcode", 130},
       {"allo_balance", 150},
       {"account", 450},
       {"pr_amount", 145}
   }
        Set_GridColWidth(colWidths, dgvRegularData)
        For Each row As DataGridViewRow In dgvRegularData.Rows
            row.Cells("pr_amount").Style.Format = "N2"
            row.Cells("pr_amount").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("allo_balance").Style.Format = "N2"
            row.Cells("allo_balance").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("accountcode").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            row.Cells("prstatus").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            row.Cells("btnPrint").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Sub dvWidthDataPPA()
        Dim colWidths As New Dictionary(Of String, Integer) From
   {
       {"btnPrint", 95},
       {"prstatus", 110},
       {"aipcode", 205},
       {"allo_balance", 150},
       {"aip", 415},
       {"pr_amount", 135}
   }
        Set_GridColWidth(colWidths, dgvPPAData)
        For Each row As DataGridViewRow In dgvPPAData.Rows
            row.Cells("pr_amount").Style.Format = "N2"
            row.Cells("pr_amount").Style.Alignment = DataGridViewContentAlignment.MiddleRight

            row.Cells("allo_balance").Style.Format = "N2"
            row.Cells("allo_balance").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("accountcode").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            row.Cells("prstatus").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            row.Cells("btnPrint").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Sub loadPRDataID()
        Dim SqlLoad As New MySQLCore
        prdataIDDT = SqlLoad.MySql_SelectString("*", "gov_prdata_id",, $"where officeid={Variables.officeid} and YEAR(logdate) = {My.MySettings.Default.ServerYear} ORDER BY id DESC")
        dgvDataID.DataSource = prdataIDDT
        If prdataIDDT.Rows.Count > 0 Then
            officeid = prdataIDDT.Rows(0)("officeid").ToString()
            officeDT = SqlLoad.MySql_SelectString("officeaccronym", "gl_offices",, $"where officeid={officeid}")
            If officeDT.Rows.Count > 0 Then
                officeaccronym = officeDT.Rows(0)("officeaccronym").ToString()
            End If
        End If
        Dim oldcolumns() = {"prnumber", "purpose", "totalamount", "status", "budgetyear"}
        Dim columns() = {"PR Number", "Purpose", "Total", "status", "Budget Year"}
        Dim cols() = {"id", "userid", "officeid", "reviewofficerid", "approvalofficerid", "accounttype", "transdate", "datetimeupdate", "logdate"}

        If Not dgvDataID.Columns.Contains("Office") Then
            Dim colExtra As New DataGridViewTextBoxColumn
            colExtra.Name = "Office"
            colExtra.HeaderText = "Office"
            dgvDataID.Columns.Insert(0, colExtra)
        End If
        For Each row As DataGridViewRow In dgvDataID.Rows
            If Not row.IsNewRow Then
                row.Cells("Office").Value = officeaccronym

            End If
        Next

        Datagrid_HideColumn(dgvDataID, cols)
        Datagrid_RenameColumn(dgvDataID, oldcolumns, columns)
    End Sub
    Private Sub dgvDataID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDataID.CellClick
        If e.RowIndex >= 0 Then
            Dim grid As DataGridView = DirectCast(sender, DataGridView)

            prnumber = grid.Rows(e.RowIndex).Cells("prnumber").Value.ToString
            Dim prpurpose = grid.Rows(e.RowIndex).Cells("purpose").Value.ToString
            Dim status = grid.Rows(e.RowIndex).Cells("status").Value.ToString
            statusCheck = grid.Rows(e.RowIndex).Cells("status").Value.ToString
            Dim accounttype = grid.Rows(e.RowIndex).Cells("accounttype").Value
            prdataid_id = grid.Rows(e.RowIndex).Cells("id").Value
            officeid = grid.Rows(e.RowIndex).Cells("officeid").Value.ToString
            Dim prdate As String = Convert.ToDateTime(grid.Rows(e.RowIndex).Cells("logdate").Value) _
            .ToString("yyyy-MM-dd")

            loadOffice()

            loadPRDataPPA()

            txtOffice.Text = officename
            txtPRNumber.Text = prnumber
            txtPurpose.Text = prpurpose
            txtDate.Text = prdate
            txtStatus.Text = status
            Variables.pr_date = prdate

            If accounttype = 1 Then
                Dim grid2 As DataGridView = DirectCast(dgvRegularData, DataGridView)
                dgvRegularData.Visible = True
                dgvRegularData.Dock = DockStyle.Fill
                dgvPPAData.Visible = False
                aip = False
                loadPRData()
                txtAIP.Text = grid2.Rows(0).Cells("account").Value.ToString
            Else
                Dim grid3 As DataGridView = DirectCast(dgvPPAData, DataGridView)
                dgvPPAData.Visible = True
                aip = True
                dgvPPAData.Dock = DockStyle.Fill
                dgvRegularData.Visible = False
                loadPRDataPPA()
                txtAIP.Text = grid3.Rows(0).Cells("aip").Value.ToString
            End If

        End If

        dvWidthDataPPA()
        dvWidthData()
    End Sub
    Private Sub dgvData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegularData.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        Dim SqlLoad As New MySQLCore
        Dim dgv = CType(sender, DataGridView)
        Dim colName = dgv.Columns(e.ColumnIndex).Name
        Dim row = dgv.Rows(e.RowIndex)
        If aip = False Then
            txtAIP.Text = dgv.Rows(e.RowIndex).Cells("account").Value.ToString
        End If
        If colName = "btnPrint" Then
            Variables.pr_office = officename
            Variables.pr_number = dgv.Rows(e.RowIndex).Cells("prnumber").Value.ToString
            Variables.pr_purpose = dgv.Rows(e.RowIndex).Cells("purpose").Value.ToString
            Variables.pr_account = dgv.Rows(e.RowIndex).Cells("account").Value.ToString
            Variables.pr_accountcode = dgv.Rows(e.RowIndex).Cells("accountcode").Value.ToString
            Variables.pr_amount = dgv.Rows(e.RowIndex).Cells("pr_amount").Value.ToString
            Variables.pr_appropriation = dgv.Rows(e.RowIndex).Cells("total_appro").Value.ToString
            Variables.pr_allotment = dgv.Rows(e.RowIndex).Cells("allo_balance").Value.ToString
            Variables.pr_verify_position = dgv.Rows(e.RowIndex).Cells("remaining_balance").Value.ToString
            Variables.pr_verify = dgv.Rows(e.RowIndex).Cells("verify_by").Value.ToString
            Variables.pr_verify_position = dgv.Rows(e.RowIndex).Cells("verify_position").Value.ToString
            Variables.pr_account_name = dgv.Rows(e.RowIndex).Cells("account").Value.ToString
            ReportRegular.ShowDialog()
        End If
    End Sub
    Private Sub dgvPPAData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPPAData.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        Dim SqlLoad As New MySQLCore
        Dim dgv = CType(sender, DataGridView)
        Dim colName = dgv.Columns(e.ColumnIndex).Name
        Dim row = dgv.Rows(e.RowIndex)
        If aip = True Then
            txtAIP.Text = dgv.Rows(e.RowIndex).Cells("aip").Value.ToString
        End If
        If colName = "btnPrint" Then
            Variables.pr_office = officename
            Variables.pr_number = dgv.Rows(e.RowIndex).Cells("prnumber").Value.ToString
            Variables.pr_purpose = dgv.Rows(e.RowIndex).Cells("purpose").Value.ToString
            Variables.pr_aip = dgv.Rows(e.RowIndex).Cells("aip").Value.ToString
            Variables.pr_aipcode = dgv.Rows(e.RowIndex).Cells("aipcode").Value.ToString
            Variables.pr_amount = dgv.Rows(e.RowIndex).Cells("pr_amount").Value.ToString
            Variables.pr_appropriation = dgv.Rows(e.RowIndex).Cells("total_appro").Value.ToString
            Variables.pr_allotment = dgv.Rows(e.RowIndex).Cells("allo_balance").Value.ToString
            Variables.pr_verify_position = dgv.Rows(e.RowIndex).Cells("remaining_balance").Value.ToString
            Variables.pr_verify = dgv.Rows(e.RowIndex).Cells("verify_by").Value.ToString
            Variables.pr_verify_position = dgv.Rows(e.RowIndex).Cells("verify_position").Value.ToString
            Variables.pr_fund = dgv.Rows(e.RowIndex).Cells("spcfundid").Value.ToString

            spcfundsDT = SqlLoad.MySql_SelectString("*", "gl_spcfunds",, $"where spcfundid = {Variables.pr_fund}")
            Dim spcfunddescription = spcfundsDT.Rows(0)("spcfunddescription").ToString()
            Variables.spcfunddescription = spcfunddescription
            ReportPPA.ShowDialog()
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
    Private Sub btnclose_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        formclose()
    End Sub
    Sub dvWidthDataID()
        Dim colWidths As New Dictionary(Of String, Integer) From
   {
       {"Office", 85},
       {"budgetyear", 80},
       {"prnumber", 100},
       {"purpose", 340},
       {"totalamount", 120}
   }
        Set_GridColWidth(colWidths, dgvDataID)
        For Each row As DataGridViewRow In dgvDataID.Rows
            row.Cells("totalamount").Style.Format = "N2"
            row.Cells("totalamount").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("budgetyear").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            row.Cells("Office").Style.Alignment = DataGridViewContentAlignment.MiddleLeft
        Next
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If cbbstatus.SelectedValue IsNot Nothing Then

            Dim SqlLoad As New MySQLCore
            Dim grid As DataGridView = DirectCast(dgvDataID, DataGridView)

            If grid.CurrentCell Is Nothing Then Exit Sub
            statusText = cbbstatus.SelectedValue.ToString()

            If statusCheck <> statusText Then
                SelectAccessLevel(statusText)

            Else
                MsgBox("Same Status")
            End If

            formload()
        End If
    End Sub
    Sub SelectAccessLevel(ByVal sender As String)
        Dim SqlLoad As New MySQLCore
        Dim columnValuesDataid As New Dictionary(Of String, String)

        Select Case sender
            Case "VERIFIED"
                columnValuesDataid.Add("id", prdataid_id)
                columnValuesDataid.Add("reviewofficerid", Variables.login_userid)
                columnValuesDataid.Add("status", statusText)

                SqlLoad.MySql_ExecuteNonQueryString("gov_prdata_id", columnValuesDataid, $"id = '{prdataid_id}'", 2)
                MsgBox("All rows saved successfully!")

            Case "APPROVED"
                columnValuesDataid.Add("id", prdataid_id)
                columnValuesDataid.Add("approvalofficerid", Variables.login_userid)
                columnValuesDataid.Add("status", statusText)

                SqlLoad.MySql_ExecuteNonQueryString("gov_prdata_id", columnValuesDataid, $"id = '{prdataid_id}' ", 2)
                MsgBox("All rows saved successfully!")
        End Select
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim SqlLoad As New MySQLCore
        Dim grid As DataGridView = DirectCast(dgvDataID, DataGridView)
        Dim id = grid.Rows(0).Cells("id").Value.ToString()

        SqlLoad.MySql_Delete("gov_prdata_id", $"id = '{prdataid_id}'")
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        loadAdmin()
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Try
                If prdataIDDT.Rows.Count > 0 Then
                    Dim conditions As New List(Of LinQCondition)()
                    conditions.Add(New LinQCondition With {
                    .Column = "prnumber",
                    .Value = txtSearch.Text,
                    .ComparisonType = ComparisonTypeEnum.Equal_enum
                })
                    Dim filteredDataTable1 As DataTable = Linq_Query(prdataIDDT, conditions, useOrOperator:=True)
                    dgvDataID.DataSource = filteredDataTable1
                End If
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try

        End If
    End Sub
End Class