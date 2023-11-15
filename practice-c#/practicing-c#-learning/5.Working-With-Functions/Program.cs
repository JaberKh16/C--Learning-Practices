
using System.Buffers;
using System;

class WorkWithFunction
{
    // class method
    public int[] CallingNonParameterFunction()
    {
        int num1 = 3;
        int num2 = 6;
        int temp;
        
        // replacing
        temp = num1;
        num1 = num2;
        num2 = temp;

        // declare an array
        int[] reversedValues = new int[2];
        reversedValues[0] = num1;
        reversedValues[1] = num2;
        
        return reversedValues;
    }

    public string CallingParametersFunction(string message)
    {
        // ToCharArray() method to spiltted string into characters and store as an array
        char[] setupMessage = message.ToCharArray();
        Array.Reverse(setupMessage);
        return new string(setupMessage);
    }
    public int CallingDefaultValParameterFunction(int number1, int number2, int summation = 0)
    {
        summation = number1 + number2;
        return summation;
    }

  public int CallingFunctionOverloadingFunction(int number1, int number2, int number3, int operationResult = 0)
    {
        if (number1 % 2 == 0)
        {
            operationResult = CallingOperateFunction(number1, number2);
            return operationResult;
        }
        else
        {
            operationResult = CallingOperateFunction(number1, number2, number3);
            return operationResult;
        }
    }

    public int CallingOperateFunction(int number1, int number2)
    {
        return number1 * number2;
    }

    public int CallingOperateFunction(int number1, int number2, int number3)
    {
        return number1 + number2 / number3;
    }

    public static void Main(string[] args)
    {
        // create an instance
        var result = new WorkWithFunction();

        // control goto jump here
        Menu:

        // take a number
        Console.WriteLine("Enter your choice: ");
        var choice = Console.ReadLine();
    
        switch (choice)
        {
            case "1":
                int[] resultValues = result.CallingNonParameterFunction();
                Console.WriteLine($"Reversed values: {resultValues[0]}, {resultValues[1]}");
                break;
            case "2":
                Console.WriteLine("Enter a string: ");
                string inputString = Console.ReadLine();
                string reversedResult = result.CallingParametersFunction(inputString);
                Console.WriteLine($"Reversed string: {reversedResult}");
                break;
            case "3":
                Console.WriteLine("Enter two numbers for summation: ");

                string input1 = Console.ReadLine();
                bool parseResult1 = int.TryParse(input1, out int number1);

                string input2 = Console.ReadLine();
                bool parseResult2 = int.TryParse(input2, out int number2);
                int summation = 0;
                if (parseResult1 && parseResult2)
                {
                    summation = result.CallingDefaultValParameterFunction(number1, number2, summation = 0);
                    Console.WriteLine($"Summation is: {summation}");
                }else{
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }

                break;
            case "4":
                Console.WriteLine("Enter three numbers for operation: ");
                string input1 = Console.ReadLine();
                bool parseResult1 = int.TryParse(input1, out int number1);

                string input2 = Console.ReadLine();
                bool parseResult2 = int.TryParse(input2, out int number2);

                string input3 = Console.ReadLine();
                bool parseResult3 = int.TryParse(input3, out int number3);

                int operationResult = 0;

                if (parseResult1 && parseResult2 && parseResult3)
                {
                    operationResult = result.CallingFunctionOverloadingFunction(number1, number2, number3);
                    Console.WriteLine($"Operation Resulted Value is: {operationResult}");
                }else{
                    Console.WriteLine("Invalid input. Please enter valid numbers.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
        goto Menu;
    }
}
