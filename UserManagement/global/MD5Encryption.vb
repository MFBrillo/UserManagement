Imports System.Security.Cryptography
Imports System.Text
Module MD5Encryption
    Function MD5Password(ByVal password As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim inputBytes As Byte() = System.Text.Encoding.ASCII.GetBytes(password)
            Dim hash As Byte() = md5.ComputeHash(inputBytes)
            Dim sb As New StringBuilder()
            For i As Integer = 0 To hash.Length - 1
                sb.Append(hash(i).ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
    Function HashPassword(ByVal Password As String, ByVal Salt As String) As String
        Dim pwd As String = Password & Salt
        Using hasher As Security.Cryptography.SHA256 = Security.Cryptography.SHA256.Create()
            Dim pwdb As Byte() = System.Text.Encoding.UTF8.GetBytes(pwd)
            Dim pwdh As Byte() = hasher.ComputeHash(pwdb)
            Return Convert.ToBase64String(pwdh)
        End Using
    End Function
End Module
