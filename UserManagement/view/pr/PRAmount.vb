Public Class PRAmount
    Dim totalamount As Double
    Private Sub btnclose_Click(sender As Object, e As EventArgs)

    End Sub
    Sub formclose()
        Opaque.Close()
        Me.Close()
        Main.Activate()
        Dim uc = New PRDashboard
        Main.ShowUserControl(uc)
        uc.loadPR()
    End Sub
    Private Sub PRData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.MySettings.Default.AccountType = 1 Then
            LoadPRData()
        ElseIf My.MySettings.Default.AccountType = 2 Then
            LoadPRDataPPA()
        End If
    End Sub
    Sub LoadPRData()
        Dim dv As New DataView(Variables.prDatatable)
        ' Sort by "approid" ascending
        dv.Sort = "approid ASC"

        dgvPrRegular.DataSource = dv
        Dim cols() = {"approid", "officeid", "acctid", "registryid", "fundid", "APPROPRIATION", "UNOBLIGATED BALANCE", "PURCHASE REQUEST"}
        Datagrid_HideColumn(dgvPrRegular, cols)
        Add_GridTextBox(dgvPrRegular, "Amount", "txtUserInput", dgvPrRegular.Columns.Count)
        Add_GridButton(dgvPrRegular, "Clear", "Clear", "btnclear", dgvPrRegular.Columns.Count)
        dvWidthAccounts()

        dgvPrRegular.Columns("ACCOUNTS").ReadOnly = True
        dgvPrRegular.Columns("ACCOUNT CODE").ReadOnly = True
        dgvPrRegular.Columns("CURRENT BALANCE").ReadOnly = True
    End Sub
    Sub LoadPRDataPPA()
        Dim dv As New DataView(Variables.prDatatable)
        ' Sort by "approid" ascending
        dv.Sort = "approid ASC"

        dgvPrRegular.DataSource = dv
        ' Dim cols() = {"approid", "officeid", "acctid", "registryid", "fundid", "APPROPRIATION", "UNOBLIGATED BALANCE", "PURCHASE REQUEST"}
        Dim cols() = {"approid", "officeid", "registryid", "spcfundid", "transidprogram", "APPROPRIATION", "UNOBLIGATED BALANCE", "PURCHASE REQUEST"}
        Datagrid_HideColumn(dgvPrRegular, cols)
        Add_GridTextBox(dgvPrRegular, "Amount", "txtUserInput", dgvPrRegular.Columns.Count)
        Add_GridButton(dgvPrRegular, "Clear", "Clear", "btnclear", dgvPrRegular.Columns.Count)
        dvWidthAccountsPPA()

        dgvPrRegular.Columns("AIP").ReadOnly = True
        dgvPrRegular.Columns("AIP CODE").ReadOnly = True
        dgvPrRegular.Columns("CURRENT BALANCE").ReadOnly = True
    End Sub
    Sub dvWidthAccountsPPA()
        Dim colWidths As New Dictionary(Of String, Integer) From
  {
      {"AIP", 300},
      {"AIP CODE", 100},
      {"CURRENT BALANCE", 100},
      {"txtUserInput", 100}
  }
        Set_GridColWidth(colWidths, dgvPrRegular)
        For Each row As DataGridViewRow In dgvPrRegular.Rows
            row.Cells("CURRENT BALANCE").Style.Format = "N2"
            row.Cells("CURRENT BALANCE").Style.Alignment = DataGridViewContentAlignment.MiddleRight

            row.Cells("txtUserInput").Style.Format = "N2"
            row.Cells("txtUserInput").Style.Alignment = DataGridViewContentAlignment.MiddleRight

            row.Cells("AIP CODE").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next
    End Sub
    Sub dvWidthAccounts()
        Dim colWidths As New Dictionary(Of String, Integer) From
      {
          {"ACCOUNTS", 300},
          {"ACCOUNT CODE", 100},
          {"CURRENT BALANCE", 100},
          {"txtUserInput", 100}
      }
        Set_GridColWidth(colWidths, dgvPrRegular)
        For Each row As DataGridViewRow In dgvPrRegular.Rows
            row.Cells("CURRENT BALANCE").Style.Format = "N2"
            row.Cells("CURRENT BALANCE").Style.Alignment = DataGridViewContentAlignment.MiddleRight

            row.Cells("txtUserInput").Style.Format = "N2"
            row.Cells("txtUserInput").Style.Alignment = DataGridViewContentAlignment.MiddleRight
            row.Cells("ACCOUNT CODE").Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Next

    End Sub
    Private Sub dgvPrRegular_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrRegular.CellClick
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
        Dim grid As DataGridView = DirectCast(sender, DataGridView)
        Dim approid As String = If(
        IsDBNull(grid.Rows(e.RowIndex).Cells("approid").Value),
        "",
        grid.Rows(e.RowIndex).Cells("approid").Value.ToString()
        )
        If e.ColumnIndex = grid.Columns("txtUserInput").Index Then
            grid.CurrentCell = grid.Rows(e.RowIndex).Cells("txtUserInput")
            grid.BeginEdit(True)
            Exit Sub
        End If
        If e.ColumnIndex = grid.Columns("btnclear").Index Then

            For i As Integer = Variables.prDatatable.Rows.Count - 1 To 0 Step -1
                If Variables.prDatatable.Rows(i)("approid").ToString() = approid Then

                    Variables.prDatatable.Rows.RemoveAt(i)
                    Exit For
                End If
            Next
            ComputeTotal()
        End If
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SqlLoad As New MySQLCore
        Try
            If String.IsNullOrWhiteSpace(txtPurpose.Text) Then
                MsgBox("Please enter a purpose.", MsgBoxStyle.Critical, "Invalid Entry")
                Exit Sub
            End If

            If totalamount <= 0 Then
                MsgBox("Total amount must be greater than zero.", MsgBoxStyle.Critical, "Invalid Entry")
                Exit Sub
            End If
            Variables.pr_number = getAndUpdatePRSeries()
            Dim purpose As String = txtPurpose.Text
            For Each row As DataGridViewRow In dgvPrRegular.Rows
                If row.IsNewRow Then Continue For

                Dim txtinput As Decimal = CDec(row.Cells("txtUserInput").Value)
                If txtinput <= 0 Then Continue For
                Dim currentbalance As Decimal = CDec(row.Cells("CURRENT BALANCE").Value)

                Dim remaining As Decimal = currentbalance - txtinput

                Dim columnValues As New Dictionary(Of String, String)
                columnValues.Add("prnumber", Variables.pr_number)
                columnValues.Add("approid", row.Cells("approid").Value.ToString())
                columnValues.Add("purpose", purpose)
                columnValues.Add("officeid", Variables.officeid)
                columnValues.Add("registryid", row.Cells("registryid").Value.ToString())
                columnValues.Add("pr_amount", txtinput.ToString())
                columnValues.Add("total_appro", row.Cells("APPROPRIATION").Value.ToString())
                columnValues.Add("allo_balance", currentbalance.ToString())
                columnValues.Add("remaining_balance", remaining.ToString())
                columnValues.Add("verify_by", txtVerifiedBy.Text)
                columnValues.Add("verify_position", txtVerifiedPositionBy.Text)

                If My.MySettings.Default.AccountType = 1 Then
                    columnValues.Add("fundid", row.Cells("fundid").Value.ToString())
                    columnValues.Add("acctid", row.Cells("acctid").Value.ToString())
                    columnValues.Add("account", row.Cells("ACCOUNTS").Value.ToString())
                    columnValues.Add("accountcode", row.Cells("ACCOUNT CODE").Value.ToString())
                ElseIf My.MySettings.Default.AccountType = 2 Then
                    columnValues.Add("spcfundid", row.Cells("spcfundid").Value.ToString())
                    columnValues.Add("transidprogram", row.Cells("transidprogram").Value.ToString())
                    columnValues.Add("aip", row.Cells("AIP").Value.ToString())
                    columnValues.Add("aipcode", row.Cells("AIP CODE").Value.ToString())
                End If

                SqlLoad.MySql_ExecuteNonQueryString("gov_prdata", columnValues, Nothing, 1)
            Next
            Dim columnValuesDataid As New Dictionary(Of String, String)
            columnValuesDataid.Add("accounttype", My.MySettings.Default.AccountType)
            columnValuesDataid.Add("prnumber", Variables.pr_number)
            columnValuesDataid.Add("officeid", Variables.officeid)
            columnValuesDataid.Add("userid", Variables.login_userid)
            columnValuesDataid.Add("totalamount", totalamount)
            columnValuesDataid.Add("purpose", purpose)
            columnValuesDataid.Add("budgetyear", My.MySettings.Default.ServerYear)
            columnValuesDataid.Add("transdate", DateTime.Now.ToString("yyyy-MM-dd"))
            SqlLoad.MySql_ExecuteNonQueryString("gov_prdata_id", columnValuesDataid, Nothing, 1)
            MsgBox("All rows saved successfully!")
            formclose()
        Catch ex As Exception
            MsgBox("Please Complete Inputed Data", MsgBoxStyle.Critical, "Invalid Entry")
        End Try
    End Sub
    Public Function getAndUpdatePRSeries() As String
        Dim SqlLoad As New MySQLCore
        Dim server_date_query As String = "SELECT YEAR(CURDATE()) AS YEAR, MONTH(CURDATE()) AS MONTH"
        Dim server_date As DataTable = SqlLoad.MySql_ExecuteNonQueryRawSQL(server_date_query)
        Dim YEAR As String = server_date.Rows(0)("YEAR")
        Dim MONTH As String = server_date.Rows(0)("MONTH")
        Dim SERIES As String = getSeriesNumber(YEAR)
        If SERIES Is Nothing Then
            SERIES = createSeries(YEAR)
        End If
        Dim pr_number As String = $"{YEAR}-{MONTH}-{SERIES}"

        incrementSeriesNumber(SERIES, YEAR)
        Return pr_number
    End Function
    Public Function getSeriesNumber(ByVal YEAR As String) As String
        Dim SqlLoad As New MySQLCore
        Dim query As String = $"SELECT LPAD(series, 4, 0) as series FROM gov_prseries WHERE is_deleted='0' AND series_year='{YEAR}' ORDER BY id DESC LIMIT 1;"
        Dim series As DataTable = SqlLoad.MySql_ExecuteNonQueryRawSQL(query)
        If series.Rows.Count > 0 Then
            Return series.Rows(0)("series")
        Else
            Return Nothing
        End If
    End Function
    Public Sub incrementSeriesNumber(ByVal SERIES As String, ByVal YEAR As String)
        Dim SqlLoad As New MySQLCore
        Dim s As Integer = Convert.ToInt32(SERIES) + 1
        Dim params As New Dictionary(Of String, String)()
        params.Add("series", s)
        SqlLoad.MySql_ExecuteNonQueryString("gov_prseries", params, $"series_year='{YEAR}'", 2)
    End Sub
    Public Function createSeries(ByVal YEAR As String) As String
        Dim SqlLoad As New MySQLCore
        Dim params As New Dictionary(Of String, String)()
        params.Add("series", "1")
        params.Add("series_year", YEAR)
        SqlLoad.MySql_ExecuteNonQueryString("gov_prseries", params, Nothing, 1)
        Return getSeriesNumber(YEAR)
    End Function
    Private Sub Amount_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim txt As TextBox = CType(sender, TextBox)

        If Not Char.IsControl(e.KeyChar) AndAlso
       Not Char.IsDigit(e.KeyChar) AndAlso
       e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txt.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
    Private Sub dgvPrRegular_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvPrRegular.EditingControlShowing
        Dim txt As TextBox = TryCast(e.Control, TextBox)

        If txt IsNot Nothing Then
            RemoveHandler txt.KeyPress, AddressOf Amount_KeyPress

            If dgvPrRegular.CurrentCell.OwningColumn.Name = "txtUserInput" Then
                AddHandler txt.KeyPress, AddressOf Amount_KeyPress
            End If
        End If
    End Sub
    Private Sub dgvPrRegular_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvPrRegular.CellValidating
        If dgvPrRegular.Columns(e.ColumnIndex).Name = "txtUserInput" Then
            If Not Decimal.TryParse(e.FormattedValue.ToString(), Nothing) Then
                MessageBox.Show("Please enter a valid amount.")
                e.Cancel = True
            End If
            If String.IsNullOrWhiteSpace(e.FormattedValue.ToString()) Then
                dgvPrRegular.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = 0
                e.Cancel = False
                Return
            End If
        End If
    End Sub

    ' Control dgvPrRegular txtUserInput 
    Private Sub dgvPrRegular_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrRegular.CellEndEdit

        If dgvPrRegular.Columns(e.ColumnIndex).Name = "txtUserInput" Then

            Dim row As DataGridViewRow = dgvPrRegular.Rows(e.RowIndex)

            Dim currentbalance As Decimal =
                If(IsDBNull(row.Cells("CURRENT BALANCE").Value), 0D,
                   Convert.ToDecimal(row.Cells("CURRENT BALANCE").Value))

            Dim txtinput As Decimal =
                If(IsDBNull(row.Cells("txtUserInput").Value), 0D,
                   Convert.ToDecimal(row.Cells("txtUserInput").Value))
            If My.MySettings.Default.AccountType = 1 Then
                If txtinput > currentbalance Then
                    MsgBox("Not enough fund." & vbCrLf &
                           row.Cells("ACCOUNTS").Value.ToString() &
                           " Balance: " & currentbalance &
                           vbCrLf & "Required: " & txtinput)

                    row.Cells("txtUserInput").Value = 0D
                    ComputeTotal()
                    Exit Sub
                End If
            ElseIf My.MySettings.Default.AccountType = 2 Then
                If txtinput > currentbalance Then
                    MsgBox("Not enough fund." & vbCrLf &
                           row.Cells("AIP").Value.ToString() &
                           " Balance: " & currentbalance &
                           vbCrLf & "Required: " & txtinput)

                    row.Cells("txtUserInput").Value = 0D
                    ComputeTotal()
                    Exit Sub
                End If
            End If

            row.Cells("txtUserInput").Value =
                Convert.ToDecimal(row.Cells("txtUserInput").Value).ToString("0.00")
        End If
        ComputeTotal()
    End Sub
    Public Sub ComputeTotal()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In dgvPrRegular.Rows
            If Not row.IsNewRow AndAlso row.Cells("txtUserInput").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("txtUserInput").Value)
            End If
        Next

        txtTotal.Text = total.ToString("N2")
        totalamount = total.ToString("N2")
    End Sub
    Private Sub btnclose_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        formclose()
    End Sub
End Class