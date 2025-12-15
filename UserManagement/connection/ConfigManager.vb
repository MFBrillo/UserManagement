Imports Newtonsoft.Json
Imports System.Collections.Specialized
Imports System.Configuration
Imports System.IO
Public Class ConfigManager
    'C:\Users\Moises\AppData\Local\Usermanagement
    Private Shared ReadOnly ConfigFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), My.MySettings.Default.AppName, "user_config.json")
    Public Shared Function LoadConfig() As UserConfig
        If File.Exists(ConfigFilePath) Then
            Dim json As String = File.ReadAllText(ConfigFilePath)
            Return JsonConvert.DeserializeObject(Of UserConfig)(json)
        Else
            Return New UserConfig With {
                .Servername = "",
                .Username = "",
                .Port = "",
                .Password = "",
                .Databasename = ""
            }
        End If
    End Function
    Public Shared Sub SaveConfig(config As UserConfig)
        Dim json As String = JsonConvert.SerializeObject(config, Formatting.Indented)
        Dim fileInfo As New FileInfo(ConfigFilePath)
        If fileInfo.Directory IsNot Nothing AndAlso Not fileInfo.Directory.Exists Then
            fileInfo.Directory.Create()
        End If

        File.WriteAllText(ConfigFilePath, json)
    End Sub
End Class
