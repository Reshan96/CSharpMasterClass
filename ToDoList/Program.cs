// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello!");
//Console.WriteLine("[S]ee all todos");
//Console.WriteLine("[A]dd a todo");
//Console.WriteLine("[R]emove a Todo");
//Console.WriteLine("[E]xit");
BuildHelloString();

List<string> GetOnlyUpperCaseWords(List<string> words)
{
    var result = new List<string>(words);


    foreach (var word in words)
    {

        Console.WriteLine(word);

        foreach (var character in word)
        {
            if (!char.IsUpper(character))
            {
                result.RemoveAll((e)=>e == word);
                Console.WriteLine(character);
                continue;
            }
        }
    }

    return result;

}

Console.ReadKey();
