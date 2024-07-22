namespace Single.Responsibility;

public class Names
{
    public List<string> All { get; } = [];
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