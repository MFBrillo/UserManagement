Public Class OkPrompt
    Public Shared CancelOption As Boolean = False
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        TitleText.Visible = False
        Opaque.Dispose()
        Me.Dispose()
        Main.Activate()
    End Sub
    Private Sub Msgform_Load(sender As Object, e As EventArgs) Handles Me.Load

        btnclose.Focus()
    End Sub
    Private Sub btnclose_KeyDown(sender As Object, e As KeyEventArgs) Handles btnclose.KeyDown
        CancelOption = False
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
End Class