var names = new Names();
var path = names.BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();


if (File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading Names.");
    var stringsFromFile = stringsTextualRepository.Read(path);
    names.AddNames(stringsFromFile);
}
else
{
    Console.WriteLine("Names File does not exist yet");
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");
    stringsTextualRepository.Write(path, names.All);
}



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
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new();

    public void AddNames(List<string> stringsFromFile)
    {
        foreach (var name in stringsFromFile)
        {
            AddName(name);
        }
    }

    public void AddName(string name)
    {
        if (_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }

    public string BuildFilePath()
    {
        return "names.txt";
    }

    public string Format()
    {
        return string.Join(Environment.NewLine, All);
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
