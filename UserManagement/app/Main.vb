Public Class Main
    Public userControl As UserControl
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opaque.Show()
        Login.ShowDialog()
    End Sub
    Public Sub ShowUserControl(ByVal uc As UserControl)                      'Clear panel and add form projects/modules
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(uc)
        uc.Size = MainPanel.Size
        uc.Show()
    End Sub
    Sub SelectMenu(ByVal sender As String)
        Select Case sender
            Case "btnDashboard"
                MsgBox("Dashboard")
            Case "btnUserManagment"
                Dim uc = New UserManagement
                ShowUserControl(uc)

            Case "btnChangeSign"
                Dim uc = New OfficeSignatory
                ShowUserControl(uc)
            Case "btnAdminSetting"
                Dim uc = New AdminSetting
                ShowUserControl(uc)
            Case "btnSignOut"
                Dim result As DialogResult
                result = MessageBox.Show("Do you want to Sign Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    Opaque.Close()
                    Opaque.Show()
                    MainPanel.Controls.Clear()
                    Login.ShowDialog()
                    Login.Txtusername.Focus()
                End If
            Case "btnUserSetting"
                Dim uc = New usersetting
                ShowUserControl(uc)
        End Select
    End Sub
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnUserManagment.Click, btnChangeSign.Click, btnAdminSetting.Click, btnSignOut.Click, btnUserSetting.Click
        SelectMenu(sender.Name)
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click

        Dim result As DialogResult
        result = MessageBox.Show("Do you want to Close this Application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            End
        End If

    End Sub
    Private Sub btnUserSetting_Click(sender As Object, e As EventArgs) Handles btnUserSetting.Click

    End Sub
End Class
