Public Class AcceptForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub cbAll_OnChange(sender As Object, e As EventArgs) Handles cbAll.OnChange
        If cbAll.Checked = True Then
            cbPolicy.Checked = True
            cbTerms.Checked = True
        End If
    End Sub
    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnregister.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to Create New Account?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            If cbPolicy.Checked = True And cbTerms.Checked = True Then
                AddUser.ShowDialog()
                Me.Close()
            ElseIf cbPolicy.Checked = False And cbTerms.Checked = True Then
                MsgBox("Please confirm the Terms and Conditions.", vbYesNo + vbQuestion, "Confirmation")
            ElseIf cbPolicy.Checked = True And cbTerms.Checked = False Then
                MsgBox("Please confirm the Privacy Policy.", vbYesNo + vbQuestion, "Confirmation")
            ElseIf cbPolicy.Checked = False And cbTerms.Checked = False Then
                MsgBox("Please confirm the Terms and Conditions and Privacy Policy.", vbYesNo + vbQuestion, "Confirmation")
            End If

        End If
    End Sub
    Private Sub AcceptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbTerms.Checked = False
        'cbPolicy.Checked = False
        'cbAll.Checked = False
    End Sub

    Private Sub lblterms_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblterms.LinkClicked

        Dim showTermsAndConditionForm As DialogResult = TermsAndConditionForm.ShowDialog()
        If showTermsAndConditionForm = DialogResult.OK Then
            'MsgBox(Variables.checkterms)
            cbTerms.Checked = Variables.checkterms

        End If

    End Sub
    Private Sub lblprivacy_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblprivacy.LinkClicked

        Dim showPrivacyForm As DialogResult = PrivacyForm.ShowDialog()
        If showPrivacyForm = DialogResult.OK Then
            'MsgBox(Variables.checkterms)
            cbPolicy.Checked = Variables.checkpolicy

        End If
    End Sub

    Private Sub cbTerms_OnChange(sender As Object, e As EventArgs) Handles cbTerms.OnChange

    End Sub
End Class