namespace DesignPatterns.Creational.Builder;

public class BuilderClient : ClientTemplate
{
    public override string Pattern => "Builder";

    public override void RunClient()
    {
        Report report;
        var reportDirector = new ReportDirector();

        var pdfReport = new PDFReport();
        report = reportDirector.MakeReport(pdfReport);
        report.DisplayReport();

        Console.WriteLine();

        var excelReport = new ExcelReport();
        report = reportDirector.MakeReport(excelReport);
        report.DisplayReport();
    }
}