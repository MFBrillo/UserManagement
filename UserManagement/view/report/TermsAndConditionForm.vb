Public Class TermsAndConditionForm
    Private Sub TermsAndConditionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim htmlPath As String = Application.StartupPath & "\view\report\Terms.html"
        Dim htmlTemplate As String = IO.File.ReadAllText(htmlPath)
        htmlTemplate = htmlTemplate.Replace("[Insert Office Name]", My.Settings.OfficeName) _
                                   .Replace("[Insert Address]", My.Settings.OfficeAddress) _
                                   .Replace("[Insert Email]", My.Settings.OfficeEmail) _
                                   .Replace("[Insert Phone Number]", My.Settings.OfficePhone) _
                                   .Replace("[Insert Date]", My.Settings.EffectiveDate)
        WebBrowser1.DocumentText = htmlTemplate
    End Sub
    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        ' Check if user clicked on Privacy.html
        If e.Url.ToString().ToLower().EndsWith("privacy.html") Then
            e.Cancel = True
            Dim frm As New PrivacyForm()
            frm.ShowDialog()
        End If
    End Sub
    Private Sub btnaccept_Click(sender As Object, e As EventArgs) Handles btnaccept.Click
        If Variables.checkterms = True Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Please check the checkbox to accept the Terms and Condition ", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub cbterms_OnChange(sender As Object, e As EventArgs) Handles cbterms.OnChange
        Variables.checkterms = cbterms.Checked
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Variables.checkterms = False
        cbterms.Checked = Variables.checkterms
        Me.Hide()
        Main.Activate()
    End Sub
End Class