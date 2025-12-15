Public Class AdminSetting
    Public userControl As UserControl
    Public Sub ShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(uc)
        uc.Size = MainPanel.Size
        uc.Show()
    End Sub
    Sub SelectMenu(ByVal sender As String)
        Select Case sender
            Case "btnadminfo"
                Dim uc = New AdminInfo
                ShowUserControl(uc)
        End Select
    End Sub
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles btnadminfo.Click
        SelectMenu(sender.Name)
    End Sub
End Class
