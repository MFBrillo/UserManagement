Public Class YesNoPrompt
    Public Shared YesOption As Boolean = False, NoOption As Boolean = False
    Private Sub YesNoPrompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnyes.Focus()
    End Sub
    Private Sub CloseNow_Click(sender As Object, e As EventArgs)
        TitleText.Visible = False
        Me.Dispose()
    End Sub
    Private Sub CloseNow_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TitleText.Visible = False
            Me.Dispose()
        End If
    End Sub
    Dim i As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If i = 2 Then
            TitleText.Visible = False
            Timer1.Enabled = False
            Me.Dispose()
        End If
    End Sub
    Private Sub btnyes_Click(sender As Object, e As EventArgs) Handles btnyes.Click
        YesOption = True
        NoOption = False
        Me.Dispose()
    End Sub
    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        NoOption = True
        YesOption = False
        Me.Dispose()
    End Sub
    Private Sub YesNoPrompt_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Opaque.Dispose()
        Main.Activate()
    End Sub
End Class