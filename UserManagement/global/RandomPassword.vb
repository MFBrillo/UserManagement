Imports System.Text
Module RandomPassword
    Function GenerateRandomPassword(length As Integer) As String
        Dim validChars As String = "0123456789"
        Dim sb As New StringBuilder()
        Dim rnd As New Random()

        For i As Integer = 1 To length
            Dim idx As Integer = rnd.Next(0, validChars.Length)
            sb.Append(validChars(idx))
        Next

        Return sb.ToString()
    End Function

    Sub Main()
        Dim password As String = GenerateRandomPassword(6) '12 characters long
        Console.WriteLine("Generated Password: " & password)
        Console.ReadLine()
    End Sub
End Module
