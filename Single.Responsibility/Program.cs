class NamesValidator
{
    public bool IsValid(string name)
    {
        return name.Length >= 2 &&
               name.Length < 25 &&
               char.IsUpper(name[0]) &&
               name.All(char.IsLetter);
    }
}

class Names
{
    private List<string> _names = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            _names.Add(name);
        }
    }
}


class StringsTextualRepository
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
