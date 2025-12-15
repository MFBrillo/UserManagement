Imports MySql.Data.MySqlClient
Module MySQLConn
    Dim userConfig As UserConfig
    Public Function MySqlSettings() As MySqlConnection
        userConfig = ConfigManager.LoadConfig()
        Dim decryptedPassword As String = PasswordEncryption.DecryptPassword(userConfig.Password)
        Dim Server As String = userConfig.Servername
        Dim username As String = userConfig.Username
        Dim password As String = decryptedPassword
        Dim database As String = userConfig.Databasename
        Dim port As String = userConfig.Port
        Return New MySqlConnection($"server={Server}; user id={username}; port={port}; password={password}; database={database}")
    End Function
End Module
