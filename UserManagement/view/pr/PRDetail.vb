Public Class PRDetail
    Public prdataDT As DataTable
    Sub formclose()
        Opaque.Close()
        Me.Close()
        Main.Activate()
        Dim uc = New PRDashboard
        Main.ShowUserControl(uc)
        uc.loadPR()

    End Sub
    Sub LoadPRData()
        Dim SqlLoad As New MySQLCore
        prdataDT = SqlLoad.MySql_SelectString("*", "gov_prdata",, $"where approid = {Variables.pr_approid}")


        lblAccountName.Text = Variables.pr_account
        lblAccountCode.Text = Variables.pr_accountcode
        'lblAccountCode.Text = Variables.pr_approid
        'lblAccountCode.Text = dgvPrRegular.SelectedRows(0).Cells("accountcode").Value.ToString

        dgvPrRegular.DataSource = prdataDT
        Dim oldcolumns() = {"purpose", "prnumber", "account", "pr_amount", "obligated_amount", "prstatus", "logdate"}
        Dim columns() = {"Purpose", "PR Number", "Account", "PR Amount", "Obligated Amount", "Status", "Date"}
        Dim cols() = {"id", "officeid", "status", "registryid", "fundid", "approid", "aip", "aipcode", "total_appro ", "verify_by", "verify_position", "allo_balance", "account", "remaining_balance", "accountcode", "acctid", "total_appro", "spcfundid", "transidprogram"}
        dvWidthAccounts()

        Datagrid_HideColumn(dgvPrRegular, cols)
        Datagrid_RenameColumn(dgvPrRegular, oldcolumns, columns)
        dgvPrRegular.Columns("logdate").DefaultCellStyle.Format = "yyyy-MM-dd"

    End Sub
    Sub dvWidthAccounts()
        Dim colWidths As New Dictionary(Of String, Integer) From
      {
          {"purpose", 200},
          {"prnumber", 40},
          {"account", 40},
          {"pr_amount", 40},
          {"obligated_amount", 40},
          {"prstatus", 40},
          {"logdate", 35}
      }
        Set_GridColWidth(colWidths, dgvPrRegular)
        For Each row As DataGridViewRow In dgvPrRegular.Rows
            row.Cells("pr_amount").Style.Format = "N2"
            row.Cells("pr_amount").Style.Alignment = DataGridViewContentAlignment.MiddleRight

            row.Cells("obligated_amount").Style.Format = "N2"
            row.Cells("obligated_amount").Style.Alignment = DataGridViewContentAlignment.MiddleRight
        Next
    End Sub
    Private Sub PRDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPRData()
    End Sub
    Private Sub dgvPrRegular_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrRegular.CellClick
        If e.RowIndex >= 0 Then
            Dim grid As DataGridView = DirectCast(sender, DataGridView)
            Dim prnumber = grid.Rows(e.RowIndex).Cells("prnumber").Value.ToString
            'Dim prdate = grid.Rows(e.RowIndex).Cells("logdate").Value.ToString
            Dim prpurpose = grid.Rows(e.RowIndex).Cells("purpose").Value.ToString
            Dim prdate As String = Convert.ToDateTime(grid.Rows(e.RowIndex).Cells("logdate").Value) _
            .ToString("yyyy-MM-dd")

            txtPRNumber.Text = prnumber
            txtPurpose.Text = prpurpose
            txtDate.Text = prdate


        End If
    End Sub

    Private Sub btnclose_Click_1(sender As Object, e As EventArgs) Handles btnclose.Click
        formclose()
    End Sub
End Class