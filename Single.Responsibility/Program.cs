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
