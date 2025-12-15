Public Class LoadingForm
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private dotCount As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If BunifuCircleProgressbar1.Value >= BunifuCircleProgressbar1.MaxValue Then
            BunifuCircleProgressbar1.Value = 0
        Else
            BunifuCircleProgressbar1.Value += 5
        End If
    End Sub
End Class