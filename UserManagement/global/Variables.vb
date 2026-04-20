Public Class Variables
    'log in - User
    Public Shared login_accesslevel As Integer
    Public Shared login_username As String
    Public Shared login_hashpassword As String
    Public Shared login_userid As Integer
    Public Shared head2 As String
    Public Shared position2 As String
    Public Shared officedescription As String

    Public Shared officeid As Integer, accesslevel As Integer, id As Integer

    'Client 
    Public Shared username As String, hashpassword As String, firstname As String, middlename As String, lastname As String, jobposition As String
    Public Shared newHashpassword As Boolean, newofficeid As Integer, newofficedescription As String, oldofficeid As Integer, oldofficedescription As String
    Public Shared newpassword As String, emailto As String, emailfrom As String
    Public Shared checkpolicy As Boolean, checkterms As Boolean

    'PR
    Public Shared prDatatable As DataTable
    Public Shared pr_number As String
    Public Shared pr_approid As String

    Public Shared pr_account As String
    Public Shared pr_accountcode As String
    Public Shared pr_account_name As String

    Public Shared pr_aip As String
    Public Shared pr_aipcode As String
    Public Shared pr_fund As String
    Public Shared spcfunddescription As String

    Public Shared pr_office As String
    Public Shared pr_date As String
    Public Shared pr_year As String
    Public Shared pr_purpose As String
    Public Shared pr_appropriation As String
    Public Shared pr_allotment As String
    Public Shared pr_amount As String
    Public Shared remaining_balance As String
    Public Shared pr_verify As String
    Public Shared pr_verify_position As String

    'ServerYear is in Database Stored Procedure all_serverdate
    Public Shared ServerYear As Integer
End Class
