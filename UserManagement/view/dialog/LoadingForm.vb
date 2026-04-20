Public Class LoadingForm
    Private Sub LoadingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: make sure form is on top and transparent background
        Me.BringToFront()
        Me.TopMost = True
    End Sub
    Public Sub SetMessage(msg As String)
        lblMessage.Text = msg
        Application.DoEvents() ' force repaint
    End Sub

End Class