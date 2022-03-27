namespace DesignPatterns.Creational.Builder;

public class PDFReport : ReportBuilder
{
    public override void SetReportType()
    {
        report.ReportType = "PDF";
    }

    public override void SetReportHeader()
    {
        report.ReportHeader = "PDF Header";
    }

    public override void SetReportContent()
    {
        report.ReportContent = "PDF Content";
    }

    public override void SetReportFooter()
    {
        report.ReportFooter = "PDF Footer";
    }
}