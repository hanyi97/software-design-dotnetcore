namespace DesignPatterns.Creational.Builder;

public class ExcelReport : ReportBuilder
{
    public override void SetReportType()
    {
        report.ReportType = "Excel";
    }

    public override void SetReportHeader()
    {
        report.ReportHeader = "Excel Header";
    }

    public override void SetReportContent()
    {
        report.ReportContent = "Excel Content";
    }

    public override void SetReportFooter()
    {
        report.ReportFooter = "Excel Footer";
    }
}