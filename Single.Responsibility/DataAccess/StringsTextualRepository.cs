namespace Single.Responsibility.DataAccess;

public class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        var fileContent = File.ReadAllText(filePath);
        return fileContent.Split(Separator).ToList();
    }

    public void Write(string filePath, List<string> textToBeSaved)
    {

        File.WriteAllText(filePath, string.Join(Separator, textToBeSaved));
    }

}