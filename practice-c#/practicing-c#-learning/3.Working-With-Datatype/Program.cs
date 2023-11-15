
// See https://aka.ms/new-console-template for more information

using System;

namespace Working_With_Datatype{


    class Datatype
    {
        public static void datatype_static_value()
        {
            int var1 = 2;
            float var2 = 3.4f;
            char word = 'a';
            string sentence = "Working";

            Console.WriteLine("var1: " + var1);  // Use concatenation or string interpolation
            Console.WriteLine("var2: " + var2);
            Console.WriteLine("word: " + word);
            Console.WriteLine("sentence: " + sentence);
        }

        public static void datatype_dynamic_value()
        {
            // You can't assign a string to an int, so var1 should be of type string
            string var = Console.ReadLine();

            Console.WriteLine("var: " + var + "type: " + var.GetType());
        }

        public static void Main(string[] args)
        {
            int selectedType1 = 1;  
            int selectedType2 = 2;

            // taking input from the user
            Console.Write("Enter a number (1 for static, 2 for dynamic): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int parsedNumber))
            {
                if (parsedNumber == selectedType1)
                {
                    Console.WriteLine("Running Static Values For Datatype Practices: ");
                    datatype_static_value();
                }
                else if (parsedNumber == selectedType2)  
                {
                    Console.WriteLine("Running Dynamic Values For Datatype Practices: ");  
                    datatype_dynamic_value();
                }
                else
                {
                    Console.WriteLine("Invalid selection.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

}
