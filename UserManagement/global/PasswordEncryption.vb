Imports System.Security.Cryptography
Imports System.Text
Module PasswordEncryption
    Private ReadOnly EncryptionKey As String = "YourStrongKey123!" ' Replace with a strong key (16, 24, or 32 characters)
    ' Encrypt a password
    Function EncryptPassword(ByVal password As String) As String
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32).Substring(0, 32))
        Dim ivBytes As Byte() = New Byte(15) {} ' Initialization vector (16 bytes)
        Using aes As Aes = Aes.Create()
            aes.Key = keyBytes
            aes.IV = ivBytes
            aes.Mode = CipherMode.CBC
            aes.Padding = PaddingMode.PKCS7
            Using encryptor = aes.CreateEncryptor()
                Dim passwordBytes = Encoding.UTF8.GetBytes(password)
                Dim encryptedBytes = encryptor.TransformFinalBlock(passwordBytes, 0, passwordBytes.Length)
                Return Convert.ToBase64String(encryptedBytes)
            End Using
        End Using
    End Function
    ' Decrypt a password
    Function DecryptPassword(ByVal encryptedPassword As String) As String
        Dim keyBytes As Byte() = Encoding.UTF8.GetBytes(EncryptionKey.PadRight(32).Substring(0, 32))
        Dim ivBytes As Byte() = New Byte(15) {} ' Initialization vector (16 bytes)
        Using aes As Aes = Aes.Create()
            aes.Key = keyBytes
            aes.IV = ivBytes
            aes.Mode = CipherMode.CBC
            aes.Padding = PaddingMode.PKCS7
            Using decryptor = aes.CreateDecryptor()
                Dim encryptedBytes = Convert.FromBase64String(encryptedPassword)
                Dim passwordBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length)
                Return Encoding.UTF8.GetString(passwordBytes)
            End Using
        End Using
    End Function
End Module
