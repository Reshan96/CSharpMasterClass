namespace PizzaFactory;

public class VitosPizzaFactory
{
    public void makePizza()
    {

        var pizza = new VitosPizza();
        pizza.AddIngredient(new VitosCheddar(10, 12));
        pizza.AddIngredient(new VitosTomato(15));
        pizza.AddIngredient(new VitosDough(25));
        Console.WriteLine(pizza.DescribePizza());

        VitosIngredient ingre = new VitosCheddar(10, 12);
        // VitosIngredient ingre_2 = new VitosIngredient(10, 12); //cannot be instantiated since this is an abstract concept

        Console.WriteLine("object:" + ingre is object);
        Console.WriteLine("object:" + (ingre is VitosIngredient));
        Console.WriteLine("object:" + (ingre is VitosCheddar));
        Console.WriteLine("object:" + (ingre is VitosDough));

        double d = 10.001;

        Console.ReadKey();
    }
}


public class VitosPizza
{
    private List<VitosIngredient> Ingredients { get; } = new List<VitosIngredient>();
    public void AddIngredient(VitosIngredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public string DescribePizza()
    {
        //var ingredientNames = Ingredients.Select(i => i.Name);
        return $"This pizza has the following ingredients: {string.Join(", ", Ingredients)}";
    }

}

public abstract class VitosIngredient
{
    public VitosIngredient(int toppingPrize)
    {
        Console.WriteLine("Ingredient class");
        prizeIfAddedAsTopping = toppingPrize;
    }
    public int prizeIfAddedAsTopping { get; }
    public string Name => "Generic ingredient";
    public virtual string CommonName { get; set; } = "Common ingredient name";
    public int PublicField { get; set; }
    public string PublicMethod() => "This method is public for classes inherited from Ingredient";
    public abstract void Prepare();
}

public abstract class Cheese: VitosIngredient
{
    public Cheese(int toppingPrice): base(toppingPrice) { }
    //no need of overriding the abstract method from base class, since this is also an abstract class
}


public sealed class VitosCheddar : Cheese
{
    //to pass the topping price to ingredient contstructor we need to call base constructor.
    //Use the 'base' keyword to pass the data
    public VitosCheddar(int toppingPrice, int ageMonths) : base(toppingPrice)
    {
        AgedForMonths = ageMonths;
        Console.WriteLine("Cheddar constructor");
    }
    public string Name => "Cheddar cheese";
    public string CommonName { get; set; } = "Cheddar cheese common name";
    public int AgedForMonths { get; }
    public void UseMethodFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
    }

    public sealed override void Prepare() => Console.WriteLine("Preparing cheddar"); //only override methods can be sealed 
    


}

public class VitosTomato : VitosIngredient
{
    public VitosTomato(int topping) : base(topping)
    {

    }

    public string Name => "Tomato sauce";
    public override string CommonName { get; set; } = "Tomato sauce common name";
    public int quantityInGrams { get; }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }

}

public class VitosDough : VitosIngredient
{
    public VitosDough(int topping) : base(topping)
    {

    }
    public string Name => "Dough";
    public override string CommonName { get; set; } = "Dough common name";

    public int WeightInGrams { get; }

    public override void Prepare()
    {
        throw new NotImplementedException();
    }
}