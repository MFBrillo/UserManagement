Public Class UserPendingForm
    Private Sub lblclose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblclose.LinkClicked
        Opaque.Close()
        Me.Close()
        Main.Activate()
        Opaque.Show()
        'If Login.ShowDialog() = False Then
        '    Login.ShowDialog()
        'Else
        '    Login.ShowDialog()
        'End If
        Login.ShowDialog()
    End Sub
End Class