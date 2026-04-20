Imports System.Threading
Public Class Main
    Private appMutex As Mutex
    Public userControl As UserControl
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim createdNew As Boolean
        appMutex = New Mutex(True, My.MySettings.Default.AppName, createdNew)

        If Not createdNew Then
            MessageBox.Show("Program is already running.")
            Application.Exit()
        End If
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
            Case "btnPr"
                Dim uc = New PRDashboard
                ShowUserControl(uc)
            Case "btnSignOut"
                Opaque.Show()
                CustomYesNoPrompt("Confirmation", "Do you want to Sign Out?")
                If YesNoPrompt.YesOption = True Then
                    MainPanel.Controls.Clear()
                    btnDashboard.Visible = False
                    btnUserManagment.Visible = False
                    btnChangeSign.Visible = False
                    btnAdminSetting.Visible = False

                    btnUserSetting.Visible = False

                    Opaque.Close()
                    Opaque.Show()
                    Login.ShowDialog()
                    Login.Txtusername.Focus()
                End If

            Case "btnUserSetting"
                Dim uc = New usersetting
                ShowUserControl(uc)
        End Select
    End Sub
    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, btnUserManagment.Click, btnChangeSign.Click, btnAdminSetting.Click, btnSignOut.Click, btnUserSetting.Click, btnPr.Click
        SelectMenu(sender.Name)
    End Sub
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Opaque.Show()
        CustomYesNoPrompt("Confirmation", "Do you want to Close this Application?")
        If YesNoPrompt.YesOption = True Then
            End
        End If
    End Sub
End Class
