
using PizzaFactory;


//var randomPizzaGenerator = new RandomPizzaGenerator(); //cannot instantiate a static class
RandomPizzaGenerator.GeneratePizza();

var vitosPizza = new VitosPizzaFactory();

vitosPizza.makePizza();

//var pizza = new Pizza();
//pizza.AddIngredient(new Cheddar());
//pizza.AddIngredient(new Tomato());
//pizza.AddIngredient(new Dough());
//Console.WriteLine(pizza.DescribePizza());


//// Accessing public members of Ingredient class from Cheddar class
//var cheddar = new Cheddar();
//cheddar.PublicField = 10;

//var Ingredient = new Ingredient { PublicField = 5 };

//Console.WriteLine(Ingredient.PublicField); //5
//Console.WriteLine(cheddar.PublicField); //10


//// Explicit type of the base class
//Ingredient ingredient = new Cheddar();
//Ingredient ingredient2 = new Tomato();
//Console.WriteLine(ingredient.Name); // ingredient is type of Ingredient not the type of cheddar. In compile time it does not know which type the object will become
//Console.WriteLine(ingredient.CommonName); // while common name is virtual it is still not updates in this case since in Cheddar it is not overriden.
//Console.WriteLine(ingredient2.CommonName); // while common name is virtual it is still not updates in this case since in Cheddar it is not overriden.

//Console.ReadKey();


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
    public string Name => "Generic ingredient";
    public virtual string CommonName { get; set; } = "Common ingredient name";
    public int PublicField { get; set; }
    public string PublicMethod() => "This method is public for classes inherited from Ingredient";
}


public class Cheddar : Ingredient
{
    public string Name => "Cheddar cheese";
    public string CommonName { get; set; } = "Cheddar cheese common name";
    public int AgedForMonths { get; }
    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }
}

public class Tomato : Ingredient
{
    public string Name => "Tomato sauce";
    public override string CommonName { get; set; } = "Tomato sauce common name";
    public int quantityInGrams { get; }

}

public class Dough : Ingredient
{
    public string Name => "Dough";
    public override string CommonName { get; set; } = "Dough common name";

    public int WeightInGrams { get; }
}