using KnowledgeCheck1_Calculator;


Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

var input = Console.ReadLine();
var calculator = new Calculator();
int[] intPair = new int[2];
//double[] doublePair = new double[2];

switch (input)
{
    case "1":
        intPair = NumberBuddy.IntEntry("add");
        Console.Write($"{intPair[0]} + {intPair[1]} = {calculator.Add(intPair[0], intPair[1])}");
        break;

    case "2":
        intPair = NumberBuddy.IntEntry("subtract");
        Console.Write($"{intPair[0]} - {intPair[1]} = {calculator.Subtract(intPair[0], intPair[1])}");
        break;

    case "3":
        intPair = NumberBuddy.IntEntry("multiply");
        Console.Write($"{intPair[0]} * {intPair[1]} = {calculator.Multiply(intPair[0], intPair[1])}");
        break;

    case "4":
        intPair = NumberBuddy.IntEntry("divide");
        Console.Write($"{intPair[0]} / {intPair[1]} = {calculator.Divide(intPair[0], intPair[1])}");
        break;

    default:
        Console.WriteLine("Unknown input");
        break;
}

public static partial class NumberBuddy
{
    public static int[] IntEntry(string arithOperator)
    {
        Console.Write($"Enter first number to {arithOperator}: ");
        var num1 = Console.ReadLine();
        var goodNum1 = NumberBuddy.VerifyInteger(num1, "first");

        Console.Write($"Enter second number to {arithOperator}: ");
        var num2 = Console.ReadLine();
        var goodNum2 = NumberBuddy.VerifyInteger(num2, "second");

        return new int[] { goodNum1, goodNum2 };
    }

    public static int VerifyInteger(string num, string numSequence)
    {
        do
        {
            if (int.TryParse(num, out int goodNum))
                return goodNum;
            else
            {
                Console.Write($"Bad number. Enter {numSequence} number again: ");
                num = Console.ReadLine();
            }
        } while (true); //infinite
    }
}
