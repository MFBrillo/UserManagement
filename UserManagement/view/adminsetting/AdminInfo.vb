Public Class AdminInfo
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.MySettings.Default.OfficeName = txtofficename.Text
        My.MySettings.Default.OfficeAddress = txtofficeaddress.Text
        My.MySettings.Default.OfficeEmail = txtemailaddress.Text
        My.MySettings.Default.OfficePhone = txtcontact.Text
        My.MySettings.Default.EffectiveDate = dtpEffectiveDate.Value
        My.MySettings.Default.Save()
    End Sub
    Sub Load_AdminData()
        txtofficename.Text = My.MySettings.Default.OfficeName
        txtofficeaddress.Text = My.MySettings.Default.OfficeAddress
        txtemailaddress.Text = My.MySettings.Default.OfficeEmail
        txtcontact.Text = My.MySettings.Default.OfficePhone
        dtpEffectiveDate.Value = My.MySettings.Default.EffectiveDate

    End Sub

    Private Sub AdminInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AdminData()
    End Sub
End Class
