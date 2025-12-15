Imports System.Net
Imports System.Net.Mail
Module EmailChecker
    ' ✅ Check if email format is valid
    Public Function IsValidEmailFormat(email As String) As Boolean
        Try
            Dim addr As New MailAddress(email)
            Return True
        Catch
            Return False
        End Try
    End Function

    ' ✅ Check if email host/domain exists
    Public Function IsValidEmailHost(email As String) As Boolean
        If Not IsValidEmailFormat(email) Then
            Return False
        End If

        Dim domain As String = email.Split("@"c)(1)

        Try
            Dim entry As IPHostEntry = Dns.GetHostEntry(domain)
            Return entry IsNot Nothing
        Catch
            Return False
        End Try
    End Function
End Module
