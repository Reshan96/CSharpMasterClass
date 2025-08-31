
var pizza = new Pizza();
pizza.AddIngredient(new Cheddar());
pizza.AddIngredient(new Tomato());
pizza.AddIngredient(new Dough());
Console.WriteLine(pizza.DescribePizza());


// Accessing public members of Ingredient class from Cheddar class
var cheddar = new Cheddar();
cheddar.PublicField = 10;

var Ingredient = new Ingredient { PublicField = 5 };

Console.WriteLine(Ingredient.PublicField); //5
Console.WriteLine(cheddar.PublicField); //10



Console.ReadKey();


public class Pizza
{
    private List<Ingredient> Ingredients { get; } = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public string DescribePizza()
    {
        //var ingredientNames = Ingredients.Select(i => i.Name);
        return $"This pizza has the following ingredients: {string.Join(", ", Ingredients)}";
    }

}

public class Ingredient()
{
    public int PublicField { get; set; }
    public string PublicMethod() => "This method is public for classes inherited from Ingredient";
}

public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }
}

public class Tomato : Ingredient
{
    public string Name => "Tomato sauce";
    public int quantityInGrams { get; }

}

public class Dough : Ingredient
{
    public string Name => "Dough";
    public int WeightInGrams { get; }
}