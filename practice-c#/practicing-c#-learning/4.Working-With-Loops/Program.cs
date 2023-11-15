
using System;

namespace Working_With_Loops{
    class Looping
    {
        public void forLoopWork(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void whileLoopWork(int num)
        {
            int i = 0;
            while (i < num)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public void doWhileLoopWork(int num)
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < num);
        }

        public static void Main(string[] args)
        {
            Console.Write("Enter a number (1, 2, 3 for options): ");
            string userInput = Console.ReadLine();

            // Parse the userInput within each case
            switch (userInput)
            {
                case "1":
                    if (int.TryParse(userInput, out int parsedNumber1))
                    {
                        new Looping().whileLoopWork(parsedNumber1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "2":
                    if (int.TryParse(userInput, out int parsedNumber2))
                    {
                        new Looping().forLoopWork(parsedNumber2);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "3":
                    if (int.TryParse(userInput, out int parsedNumber3))
                    {
                        new Looping().doWhileLoopWork(parsedNumber3);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                default:
                    Console.WriteLine("Entered choice outside the scope!");
                    break;
            }
        }
    }
}