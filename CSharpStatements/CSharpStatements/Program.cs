using System;

namespace CSharpStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "admin";
            string correctPassword = "1234";

            bool isAuthenticated;
            do
            {
                Console.Write("Username=");
                string actualUsername = Console.ReadLine();

                Console.Write("Password=");
                string actualPassword = Console.ReadLine();

                isAuthenticated = string.Equals(actualUsername, correctUsername, StringComparison.Ordinal) &&
                                        string.Equals(actualPassword, correctPassword, StringComparison.Ordinal);

                if (isAuthenticated)
                {
                    Console.WriteLine($"Wellcome {actualUsername}!");
                }
                else
                {
                    Console.WriteLine($"Wrong username and/or password, please try again!");
                }
            }
            while (!isAuthenticated);
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

        static void If_ExerciseWithComplexMenu()
        {
            string level1Option = PrintMenuAndReturnOption(
                "Please select an option:",
                new string[]
                {
                    "1|File",
                    "2|Edit",
                    "3|View"
                });

            if (string.Equals(level1Option, "1", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(level1Option, "file", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: generate File sub-options
                string level2Option = PrintMenuAndReturnOption(
                    "Please select a sub-option:",
                    new string[]
                    {
                        "1.1|New",
                        "1.2|Open",
                        "1.3|Save"
                    });

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
            }
            else if (string.Equals(level1Option, "2", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(level1Option, "edit", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: generate Edit sub-options
                string level2Option = PrintMenuAndReturnOption(
                    "Please select a sub-option:",
                    new string[]
                    {
                        "2.1|Cut",
                        "2.2|Copy",
                        "2.3|Paste"
                    });

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
            }
            else if (string.Equals(level1Option, "3", StringComparison.OrdinalIgnoreCase) ||
                     string.Equals(level1Option, "view", StringComparison.OrdinalIgnoreCase))
            {
                // TODO: generate View sub-options
                string level2Option = PrintMenuAndReturnOption(
                    "Please select a sub-option:",
                    new string[]
                    {
                        "3.1|Solution Explorer",
                        "3.2|Git Changes",
                        "3.3|Cloud Explorer"
                    });

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
            }
        }

        static void Switch_ExerciseWithComplexMenu()
        {
            string level1Option = PrintMenuAndReturnOption(
                 "Please select an option:",
                 new string[]
                 {
                    "1|File",
                    "2|Edit",
                    "3|View"
                 });

            switch (level1Option)
            {
                case "1":
                case "file":
                    {
                        string level2Option = PrintMenuAndReturnOption(
                            "Please select a sub-option:",
                            new string[]
                            {
                            "1.1|New",
                            "1.2|Open",
                            "1.3|Save"
                            });

                        switch (level2Option)
                        {
                            case "1.1":
                            case "new":
                                Console.WriteLine("You have selected File / New");
                                break;

                            case "1.2":
                            case "open":
                                Console.WriteLine("You have selected File / Open");
                                break;

                            case "1.3":
                            case "save":
                                Console.WriteLine("You have selected File / Save");
                                break;
                        }
                    }
                    break;

                case "2":
                case "edit":
                    {
                        string level2Option = PrintMenuAndReturnOption(
                            "Please select a sub-option:",
                            new string[]
                            {
                                "2.1|Cut",
                                "2.2|Copy",
                                "2.3|Paste"
                            });

                        switch (level2Option)
                        {
                            case "2.1":
                            case "cut":
                                Console.WriteLine("You have selected Edit / Cut");
                                break;

                            case "2.2":
                            case "copy":
                                Console.WriteLine("You have selected Edit / Copy");
                                break;

                            case "2.3":
                            case "paste":
                                Console.WriteLine("You have selected Edit / Paste");
                                break;
                        }
                    }
                    break;

                case "3":
                case "view":
                    {
                        string level2Option = PrintMenuAndReturnOption(
                            "Please select a sub-option:",
                            new string[]
                            {
                                "3.1|Solution Explorer",
                                "3.2|Git Changes",
                                "3.3|Cloud Explorer"
                            });

                        switch (level2Option)
                        {
                            case "3.1":
                            case "solution explorer":
                                Console.WriteLine("You have selected View / Solution Explorer");
                                break;

                            case "3.2":
                            case "git changes":
                                Console.WriteLine("You have selected View / Git Changes");
                                break;

                            case "3.3":
                            case "cloud explorer":
                                Console.WriteLine("You have selected View / Cloud Explorer");
                                break;
                        }
                    }
                    break;
            }
        }

        static void For_PrintAllEvenNumbersTill()
        {
            int n = ReadNumber("N=");

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                if (i > 10)
                {
                    int shouldCotinue = ReadNumber("Mai continuati? 0=NU, 1=DA ");
                    if (shouldCotinue == 0)
                    {
                        break;
                    }
                }

                Console.WriteLine(i);
            }
        }

        static void For_ExerciseWithArray()
        {
            int n = ReadNumber("How many elements has the vector? ");
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadNumber($"Element at index {i}=");
            }

            // print elements in order
            Console.WriteLine();
            Console.Write("Elements in order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            // print elements in reverse order
            Console.WriteLine();
            Console.Write("Elements in reverse order: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]}, ");
            }

            // print sum of elements
            Console.WriteLine();
            Console.Write("Sum of elements: ");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.Write(sum);
        }

        static void While_PrimitiveAuthenticationSystem()
        {
            string correctUsername = "admin";
            string correctPassword = "1234";

            bool isAuthenticated = false;
            while (!isAuthenticated)
            {
                Console.Write("Username=");
                string actualUsername = Console.ReadLine();

                Console.Write("Password=");
                string actualPassword = Console.ReadLine();

                isAuthenticated = string.Equals(actualUsername, correctUsername, StringComparison.Ordinal) &&
                                        string.Equals(actualPassword, correctPassword, StringComparison.Ordinal);

                if (isAuthenticated)
                {
                    Console.WriteLine($"Wellcome {actualUsername}!");
                }
                else
                {
                    Console.WriteLine($"Wrong username and/or password, please try again!");
                }
            }
        }

        static string PrintMenuAndReturnOption(string label, string[] options)
        {
            bool isOptionCorrect = false;
            string answer = string.Empty;

            while (!isOptionCorrect)
            {
                Console.WriteLine(label);
                for (int i = 0; i < options.Length; i++)
                {
                    string[] parts = options[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    string optionNumber = parts[0];
                    string optionText = parts[1];
                    Console.WriteLine($"{optionNumber} {optionText}");
                }

                Console.Write("Your option is:");
                answer = Console.ReadLine();

                // validate if answer is between the presented options
                for (int i = 0; i < options.Length; i++)
                {
                    string[] parts = options[i].Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                    string optionNumber = parts[0];
                    string optionText = parts[1];

                    isOptionCorrect = string.Equals(answer, optionNumber, StringComparison.OrdinalIgnoreCase) ||
                                      string.Equals(answer, optionText, StringComparison.OrdinalIgnoreCase);

                    if (isOptionCorrect)
                    {
                        break;
                    }
                }

                if (!isOptionCorrect)
                {
                    Console.WriteLine($"Your option '{answer}' is not valid, please try again ...");
                }
            }

            return answer;
        }

        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
    }
}
