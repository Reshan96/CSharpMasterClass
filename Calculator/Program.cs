Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
var input1 = Console.ReadLine();
var number1 = int.Parse(input1);

Console.WriteLine("Input the second number:");
var input2 = Console.ReadLine();
var number2 = int.Parse(input2);

Console.WriteLine("What do you want to do with those numbers?\r\n[A]dd\r\n[S]ubtract\r\n[M]ultiply\r\n");
var action = Console.ReadLine();

action = action?.ToUpper();

if (action is not ("A" or "S" or "M"))
{
    Console.WriteLine("Invalid option");
    Console.WriteLine("Press any key to close");
    Console.ReadKey();
    return;
}
else
{
        var arith = action == "A"? (Action.A): (action == "S" ? Action.S: Action.M);
        CalculateAndPrint(number1, number2, arith);
}


void CalculateAndPrint(int number1, int number2, Action action)
{
    string operatorType;
    int finalNum;

    switch (action)
    {
        case Action.A:
        {
            operatorType = "+";
            finalNum = number1 + number2;
            break;
        }
        case Action.S:
        {
            operatorType = "-";
            finalNum = number1 - number2; 
            break;
        }
        case Action.M:
        {
            operatorType= "*";
            finalNum = number1 * number2;
            break;
        }
        default:
            throw new Exception("Not implemented.");
    }
            
     
    Console.WriteLine("{0}{1}{2} = {3}",number1,operatorType,number2,finalNum);
    Console.WriteLine("num" + number1 + "num2" + number2);
    Console.WriteLine("Press any key to close");
    Console.ReadKey();
}



enum Action
{
    A,
    S,
    M
}

