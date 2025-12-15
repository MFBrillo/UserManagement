Imports System.Net.Mail
Module EmailModule
    Public Sub SendEmail(toEmail As String, subject As String, body As String)
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com") ' Example using Gmail
            smtp.Port = 587
            smtp.Credentials = New Net.NetworkCredential("pbodagcapiz@gmail.com", "zwrt sywh isqw hhqd") ' Change this
            smtp.EnableSsl = True

            Dim mail As New MailMessage()
            mail.From = New MailAddress("pbodagcapiz@gmail.com", "PBO App")
            mail.To.Add(toEmail)
            mail.Subject = subject
            mail.Body = body

            smtp.Send(mail)
            CustomMsg("Success", "Email sent successfully to " & toEmail)

        Catch ex As Exception
            CustomMsg("Error", "Error sending email: " & ex.Message)
        End Try
    End Sub
End Module
