namespace ADP_HM02;
public class FileReader
{
    public string ReadFile(string filePath)
    {
        return File.ReadAllText(filePath);
    }
}