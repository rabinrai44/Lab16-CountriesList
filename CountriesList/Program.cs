using System;

namespace CountriesList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Countries Maintenance Application!\n-------------------------------------------------------");

            //Start running
            do
            {
                try
                {
                    Console.WriteLine("\n1 - See the list of contries");
                    Console.WriteLine("\n2 - Add a country");
                    Console.WriteLine("\n3 - Exit");

                    Console.Write("Enter menu number: ");
                    int userInput = int.Parse(Console.ReadLine());

                    switch (userInput)
                    {
                        case 1:
                            CountriesTextFile.ReadCountries();
                            break;
                        case 2:
                            CountriesTextFile.WriteCountries();
                            break;
                        case 3:
                            Console.WriteLine("Goodbye!");
                            break;
                        default:
                            Console.WriteLine("Not valid number you've entered! Please try again.");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (ShouldContinue());
        }

        public static bool ShouldContinue()
        {
            do
            {
                Console.WriteLine("Continue (y/n)?");
                var input = Char.ToLower(Console.ReadKey().KeyChar);
                if (input != 'y' && input != 'n')
                    continue;
                else
                    return input == 'y';
            } while (true);
        }
    }
}
