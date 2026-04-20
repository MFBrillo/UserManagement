Imports CrystalDecisions.CrystalReports.Engine
Public Class ReportPPA
    Private Sub ReportPPA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objRep As New ReportDocument()
        Dim report_path As String = System.IO.Path.Combine(Application.StartupPath, "ChargeSlipPPA.rpt")

        objRep.Load("report\ChargeSlipPPA.rpt")
        'objRep.Load(report_path)

        Dim office As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtOffice")
        office.Text = Variables.pr_office

        Dim datenow As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtDate")
        datenow.Text = Variables.pr_date

        Dim pryear As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtyr")
        pryear.Text = Variables.ServerYear

        Dim purpose As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtPurpose")
        purpose.Text = Variables.pr_purpose

        Dim fund As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtfund")
        fund.Text = Variables.spcfunddescription

        Dim aip As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtaip")
        aip.Text = Variables.pr_aip

        Dim aipcode As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtaipcode")
        aipcode.Text = Variables.pr_aipcode

        Dim appropriation As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtAppropriations")
        appropriation.Text = Convert.ToDouble("0" + Variables.pr_appropriation).ToString("N2")

        Dim allotmentbal As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtAllotmentBalance")
        allotmentbal.Text = Convert.ToDouble("0" + Variables.pr_allotment).ToString("N2")

        Dim pr As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtPR")
        pr.Text = Convert.ToDouble("0" + Variables.pr_amount).ToString("N2")

        Dim remainingbal As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtRemainingBalance")
        remainingbal.Text = (Convert.ToDecimal("0" + Variables.pr_allotment) - Convert.ToDecimal("0" + Variables.pr_amount)).ToString("N2")

        Dim verified As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtVerified")
        verified.Text = Variables.pr_verify

        Dim verifiedposition As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtVerifiedPosition")
        verifiedposition.Text = Variables.pr_verify_position

        Dim txtLessPR As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtLessPR")
        txtLessPR.Text = $"LESS: THIS PR ({Variables.pr_number})"

        Dim prnumber As TextObject = objRep.ReportDefinition.Sections("Section2").ReportObjects("txtPRNumber")
        prnumber.Text = $"{Variables.pr_number}"


        CrystalReportViewer1.ReportSource = objRep
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.Refresh()
    End Sub
End Class