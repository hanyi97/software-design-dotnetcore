namespace DesignPatterns.Behavioural.Strategy;

public class StrategyClient : ClientTemplate
{
    public override string Pattern => "Strategy";

    public override void RunClient()
    {
        var ctx = new CompressionContext(new ZipCompression());
        ctx.CreateArchive("test");
        
        ctx.SetStrategy(new RarCompression());
        ctx.CreateArchive("test");
    }
}