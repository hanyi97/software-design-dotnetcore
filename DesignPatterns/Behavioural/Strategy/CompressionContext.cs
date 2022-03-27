namespace DesignPatterns.Behavioural.Strategy;

/// <summary>
/// This class contains a property that is used to hold the reference of a strategy object.
/// This property will be set at run-time by the client according to the algorithm that is required.
/// </summary>
public class CompressionContext
{
    private ICompression _compression;
    
    public CompressionContext(ICompression compression)
    {
        _compression = compression;
    }

    public void SetStrategy(ICompression compression)
    {
        _compression = compression;
    }

    public void CreateArchive(string filename)
    {
        _compression.CompressFolder(filename);
    }
}