namespace DesignPatterns.Creational.Builder;

/// <summary>
/// This is an abstract class that will provide the blueprint to create
/// different types of reports.
/// </summary>
public abstract class ReportBuilder
{
    protected Report report;

    public abstract void SetReportType();
    public abstract void SetReportHeader();
    public abstract void SetReportContent();
    public abstract void SetReportFooter();

    public void CreateNewReport()
    {
        report = new Report();
    }
    
    public Report GetReport()
    {
        return report;
    }
}