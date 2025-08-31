var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = true;

int sum;
NumberCalcultor calc = shallAddPositiveOnly ? new PositiveNumberCalcultor() : new NumberCalcultor();
sum = calc.Calculate(numbers);

Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The total is: {calc.Total}");
Console.ReadLine();

public class NumberCalcultor
{
    public virtual int Total { get; } = 10;
    public virtual int Calculate(List<int> numberList)
    {

        int sum = 0;
        foreach (var number in numberList)
        {
            if(ShallBeAdded(number))
            sum += number;

        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int number) => true;
}

public class PositiveNumberCalcultor: NumberCalcultor
{
    public override int Total { get;} = 20;

    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}
