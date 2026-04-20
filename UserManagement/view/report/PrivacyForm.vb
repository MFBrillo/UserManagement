
Public Class PrivacyForm
    Private Sub PrivacyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbpolicy.Checked = False
        Variables.checkpolicy = False
        Dim htmlPath As String = Application.StartupPath & "\view\report\Privacy.html"
        Dim htmlTemplate As String = IO.File.ReadAllText(htmlPath)
        htmlTemplate = htmlTemplate.Replace("[Insert Office Name]", My.Settings.OfficeName) _
                                   .Replace("[Insert Address]", My.Settings.OfficeAddress) _
                                   .Replace("[Insert Email]", My.Settings.OfficeEmail) _
                                   .Replace("[Insert Phone Number]", My.Settings.OfficePhone) _
                                   .Replace("[Insert Date]", My.Settings.EffectiveDate)
        WebBrowser1.DocumentText = htmlTemplate
    End Sub
    Private Sub btnaccept_Click(sender As Object, e As EventArgs) Handles btnaccept.Click
        If Variables.checkpolicy = True Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please check the checkbox to accept the Privacy Policy", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub cbpolicy_OnChange(sender As Object, e As EventArgs) Handles cbpolicy.OnChange
        Variables.checkpolicy = cbpolicy.Checked
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Variables.checkpolicy = False
        cbpolicy.Checked = Variables.checkpolicy
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class