namespace PizzaFactory.Extensions;

public static class StringExtensions
{
    public static int CountNewLines(this string input)
    {
        return input.Split(Environment.NewLine).Length;
    }
}
