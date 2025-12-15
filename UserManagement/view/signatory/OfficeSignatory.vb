Public Class OfficeSignatory
    Public officeDT As DataTable
    Public officeSigDT As DataTable
    Public usersDT As DataTable
    Public userlevelDT As DataTable
    Public notduplicate As Boolean
    Public SigID As Integer
    Public SigID2 As Integer
    Public iv_name As String
    Public iv_officeid As Integer
    Public iv_username = Variables.login_username
    Public iv_userid = Variables.login_userid
    Private Sub OfficeSignatory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user_info()
        loadoffice()
    End Sub
    Sub user_info()
        Dim SqlLoad As New MySQLCore
        Dim userinfoDT = SqlLoad.MySql_SelectString("*", "gl_users", , $"where id ='{iv_userid}'")
        iv_officeid = userinfoDT.Rows(0).Item("officeid").ToString
        Variables.firstname = userinfoDT.Rows(0).Item("firstname").ToString
        Variables.middlename = userinfoDT.Rows(0).Item("middlename").ToString
        Variables.lastname = userinfoDT.Rows(0).Item("lastname").ToString
        Variables.jobposition = userinfoDT.Rows(0).Item("jobposition").ToString
        iv_name = Variables.firstname + " " + Variables.middlename + " " + Variables.lastname
    End Sub
    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        Dim SqlLoad As New MySQLCore
        Opaque.Show()
        Dim showchangehead As DialogResult = ChangeHead.ShowDialog()
        Opaque.Close()
        If showchangehead = DialogResult.OK Then
            If IsAnyFieldEmpty() Then
                Dim columnValues As New Dictionary(Of String, String)
                columnValues.Add("officeid", Variables.officeid)
                columnValues.Add("userid", Variables.login_userid)
                columnValues.Add("signatory", $"{Variables.head2}")
                columnValues.Add("sigpos", $"{Variables.position2}")
                SqlLoad.MySql_ExecuteNonQueryString("gl_offices_signatories", columnValues)
                MsgBox("Data Successful Change!", vbInformation, "Change")
            Else
                Dim columnValues As New Dictionary(Of String, String)
                columnValues.Add("signatory", $"{Variables.head2}")
                columnValues.Add("sigpos", $"{Variables.position2}")
                SqlLoad.MySql_ExecuteNonQueryString("gl_offices_signatories", columnValues, $"userid= '{iv_userid}'", 2)
                MsgBox("Update Successful")
            End If
            OfficeSignatory_Load(Me, EventArgs.Empty)
        End If
    End Sub
    Private Function IsAnyFieldEmpty() As Boolean
        Return txthead2.Text = "" OrElse
               txtposition2.Text = ""
    End Function
    Sub loadoffice()
        Dim SqlLoad As New MySQLCore
        Dim officenameDT = SqlLoad.MySql_SelectString("officename", "gl_offices", , $"where officeid ='{iv_officeid}'")
        Dim officename = officenameDT.Rows(0).Item("officename").ToString
        lblName.Text = iv_name
        txtname.Text = iv_name
        txtposition1.Text = Variables.jobposition
        txtoffice.Text = officename
        officeDT = SqlLoad.MySql_SelectString("*", "gl_offices",, $"where officeid ='{iv_officeid}'")
        officeSigDT = SqlLoad.MySql_SelectString("*", "gl_offices_signatories",, $"where userid = '{iv_userid}' and officeid ='{iv_officeid}'")
        Try
            If officeSigDT.Rows.Count > 0 Then
                Dim officeSigDT = SqlLoad.MySql_SelectString("signatory,sigpos", "gl_offices_signatories", , $"where userid ='{iv_userid}'and  officeid ='{iv_officeid}'")
                lblName.Text = officeSigDT.Rows(0).Item("signatory").ToString
                txthead1.Text = officeDT.Rows(0).Item("officeheadpersonnel").ToString
                txtposition1.Text = officeDT.Rows(0).Item("officeheadpos").ToString
                txthead2.Text = officeSigDT.Rows(0).Item("signatory").ToString
                txtposition2.Text = officeSigDT.Rows(0).Item("sigpos").ToString
                SigID = officeSigDT.Rows(0).Item("id").ToString
                notduplicate = True
            Else
                Dim officeDT = SqlLoad.MySql_SelectString("officeheadpersonnel,officeheadpos", "gl_offices", , $"where officeid ='{iv_officeid}'")
                txthead1.Text = officeDT.Rows(0).Item("officeheadpersonnel").ToString
                txtposition1.Text = officeDT.Rows(0).Item("officeheadpos").ToString
                notduplicate = False
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to Delete this Signatory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim SqlLoad As New MySQLCore
            Dim tablename = "gl_offices_signatories"
            If officeSigDT.Rows.Count > 0 Then
                SqlLoad.MySql_Delete(tablename, $"userid = '{iv_userid}'")
                MsgBox("Record Deleted")
                txthead2.Text = ""
                txtposition2.Text = ""
                OfficeSignatory_Load(Me, EventArgs.Empty)
            Else
                MsgBox("No Data Records", vbInformation, "Invalid Entry")
            End If
        End If
    End Sub
End Class
