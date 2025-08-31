var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };
bool shallAddPositiveOnly = false;

int sum;
NumberCalcultor calc = shallAddPositiveOnly ? new PositiveNumberCalcultor() : new NumberCalcultor();
sum = calc.Calculate(numbers);

Console.WriteLine($"The sum is: {sum}");
Console.ReadLine();

public class NumberCalcultor
{
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
    protected override bool ShallBeAdded(int number)
    {
        return number > 0;
    }
}
