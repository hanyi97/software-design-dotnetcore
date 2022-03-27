namespace DesignPatterns.Behavioural.Strategy;

public class RarCompression : ICompression
{
    public void CompressFolder(string filename)
    {
        Console.WriteLine($"Folder is compressed using Rar approach: {filename}.rar file is created");
    }
}