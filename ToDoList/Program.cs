
using System.Xml.Linq;

var dog1 = new Dog("Lucky", 25);
var dog2 = new Dog("Lucy", 4);
dog1.Name = "Brower";


dog1.Describe();
dog2.Describe();

public static class Cat
{
    private static string _name;
    private static string _breed;

    public static DateTime GetDate()
    {
        return DateTime.Now;
    }


    public static string Describe() => $"This dog named {_name}, it's a {_breed} cat.";

}

public class Dog
{
    private string _name;
    private string _breed;
    private int _weight;
    private DateTime _date;

    public DateTime Date
    {
        get
        {
            return _date;
        }
        set
        {
            if (value.Year == DateTime.Now.Day)
            {
                _date = value;
            }
        }
    }

    public static DateTime GetDate()
    {
        return DateTime.Now;
    }

    public Dog(string name, string breed, int weight)
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog(string name, int weight, string breed = "mixed-breed")
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }

    public string Breed
    {
        get => _breed;
        private set => _breed = value;
    }

    public string Describe() => $"This dog named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {GetWeightClass()} dog.";


    private string GetWeightClass()
    {
        if (_weight < 5)
            return "tiny";
        if (_weight >= 30)
            return "large";

        return "medium";
    }
}
