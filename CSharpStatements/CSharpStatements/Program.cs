using System;

namespace CSharpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. File");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. View");
            Console.Write("Your option is:");
            string level1Option = Console.ReadLine();

            if (string.Equals(level1Option, "1", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(level1Option, "file", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: generate File sub-options
                Console.WriteLine("Please select a sub-option:");
                Console.WriteLine("1.1 New");
                Console.WriteLine("1.2 Open");
                Console.WriteLine("1.3 Save");
                Console.Write("Your option is:");
                string level2Option = Console.ReadLine();

                if (string.Equals(level2Option, "1.1", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(level2Option, "new", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected File / New");
                }
                else if (string.Equals(level2Option, "1.2", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "open", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected File / Open");
                }
                else if (string.Equals(level2Option, "1.3", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "save", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected File / Save");
                }
                else
                {
                    Console.Write($"Your option '{level2Option}' is not valid");
                }
            }
            else if (string.Equals(level1Option, "2", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(level1Option, "edit", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: generate Edit sub-options
                Console.WriteLine("Please select a sub-option:");
                Console.WriteLine("2.1 Cut");
                Console.WriteLine("2.2 Copy");
                Console.WriteLine("2.3 Paste");
                Console.Write("Your option is:");
                string level2Option = Console.ReadLine();
                
                if (string.Equals(level2Option, "2.1", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(level2Option, "cut", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected Edit / Cut");
                }
                else if (string.Equals(level2Option, "2.2", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "copy", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected Edit / Copy");
                }
                else if (string.Equals(level2Option, "2.3", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "paste", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected Edit / Paste");
                }
                else
                {
                    Console.Write($"Your option '{level2Option}' is not valid");
                }
            }
            else if (string.Equals(level1Option, "3", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(level1Option, "view", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: generate View sub-options
                Console.WriteLine("Please select a sub-option:");
                Console.WriteLine("3.1 Solution Explorer");
                Console.WriteLine("3.2 Git Changes");
                Console.WriteLine("3.3 Cloud Explorer");
                Console.Write("Your option is:");
                string level2Option = Console.ReadLine();

                if (string.Equals(level2Option, "3.1", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(level2Option, "solution explorer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected View / Solution Explorer");
                }
                else if (string.Equals(level2Option, "3.2", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "git changes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected View / Git Changes");
                }
                else if (string.Equals(level2Option, "3.3", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(level2Option, "cloud explorer", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You have selected View / Cloud Explorer");
                }
                else
                {
                    Console.Write($"Your option '{level2Option}' is not valid");
                }
            }
            else
            {
                Console.Write($"Your option '{level1Option}' is not valid");
            }
        }

        static void If_SimpleExample()
        {
            Random randomizer = new Random();
            int i = randomizer.Next(0, 100);

            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} is Even");
            }
            else
            {
                Console.WriteLine($"{i} is Odd");
            }
        }
    }
}
