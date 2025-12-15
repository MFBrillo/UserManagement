Public Class UserManagement
    Public userControl As UserControl

    Public Sub ShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(uc)
        uc.Size = MainPanel.Size
        uc.Show()
    End Sub
    Sub SelectMenu(ByVal sender As String)
        Select Case sender
            Case "btnnewuser"
                Dim uc = New NewUser
                ShowUserControl(uc)
            Case "btnverifieduser"
                Dim uc = New VerifiedUser
                ShowUserControl(uc)
        End Select
    End Sub
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles btnnewuser.Click, btnverifieduser.Click
        SelectMenu(sender.Name)
    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Variables.login_accesslevel = 1 Then
            Me.btnverifieduser.Visible = True
        End If

    End Sub
End Class
