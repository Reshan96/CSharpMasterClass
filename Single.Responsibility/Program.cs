var names = new Names();
var path = new FilePathBuilder().Build();
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

Console.WriteLine(new NamesFormatter().Format(names.All));
Console.ReadKey();


class FilePathBuilder()
{
    public string Build()
    {
        return "names.txt";
    }
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

class NamesFormatter()
{
    public string Format(List<string> names)
    {
        return string.Join(Environment.NewLine, names);
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
