using Single.Responsibility;
using Single.Responsibility.DataAccess;

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