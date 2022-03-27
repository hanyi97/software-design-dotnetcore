namespace DesignPatterns.Creational.Builder;

/// <summary>
/// The director will take the builder object and use it to construct the product.
///
/// The MakeReport method is so generic that it can be used to construct any type of report.
/// </summary>
public class ReportDirector
{
    public Report MakeReport(ReportBuilder builder)
    {
        builder.CreateNewReport();
        builder.SetReportType();
        builder.SetReportHeader();
        builder.SetReportContent();
        builder.SetReportFooter();

        return builder.GetReport();
    }
}