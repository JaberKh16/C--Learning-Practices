// See https://aka.ms/new-console-template for more information

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

// namespace NamespaceSetup
// {
//     class FirstProgram
//     {
//         public static void Main(string[] args)
//         {
//             string text = "Hello from C#";
//             Console.WriteLine($"{text}");
//         }
//     }
// }


using System;

class FirstProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a simple C# program.");
        Console.WriteLine("Enter your name:");
        
        // Read user input
        string name = Console.ReadLine();
        
        // Greet the user
        Console.WriteLine($"Hello, {name}! Welcome to C# programming.");
    }
}


