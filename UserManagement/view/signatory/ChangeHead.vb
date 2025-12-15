Public Class ChangeHead
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.DialogResult = DialogResult.Cancel
        Opaque.Close()
        Main.Activate()
        Me.Close()
    End Sub
    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to Save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Variables.head2 = txthead2.Text
            Variables.position2 = txtposition2.Text
            Me.DialogResult = DialogResult.OK
        End If
    End Sub
End Class