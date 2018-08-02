using System;
using System.IO;

namespace CountriesList
{
    public static class CountriesTextFile
    {
        //file path
        private static string path = "/Users/rabin/Desktop/csharpdotnetbootcamp/Lab16-CountriesList/Countries.txt";

        // Read country from file
        public static void ReadCountries()
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    // Read and display lines from the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Add country to make file.");
            }

        }


        //Write country to file
        public static void WriteCountries()
        {
            Console.WriteLine("enter country");
            string countryInput = Console.ReadLine();

            using (StreamWriter createFile = File.AppendText(path))
            {
                Console.WriteLine("Country Added!");
                createFile.WriteLine(countryInput);
            }
        }
    }
}
