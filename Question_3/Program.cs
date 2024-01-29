using System;
using System.IO;

namespace Question_3
{
    internal class Program
    {
        static void Main()
        {
            // Load data from the CSV file (replace with your file path)
            Medal.LoadDataFromCSV("Medals.csv");

            // Add a new Medalist
            Medal.AddMedalist(new Medal
            {
                Athlete = "Marjan Jafari",
                Year = 2019,
                GoldMedals = 26,
                SilverMedals = 12,
                BronzeMedals = 3
            });

            // Delete Medalists based on criteria
            Medal.DeleteMedalist("Yun Mi-Jine", 2000);

            // Search for Medalists
            Console.WriteLine("Search results:");
            var searchResults = Medal.Search("Marjan");
            foreach (var medalist in searchResults)
            {
                Console.WriteLine($"{medalist.Athlete} ({medalist.Year})");
            }
            // Display all Medalists
            Medal.DisplayMedalists();
        }
    }
}