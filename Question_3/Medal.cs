using System;
using System.Collections.Generic;
using System.IO;

namespace Question_3
{
    /// <summary>
    /// Represents a Medal record for an athlete.
    /// </summary>
    public class Medal
    {
        public string Athlete { get; set; }
        public int Year { get; set; }
        public int GoldMedals { get; set; }
        public int SilverMedals { get; set; }
        public int BronzeMedals { get; set; }

        // Static list to store Medal objects
        public static List<Medal> listMedal = new List<Medal>();

        /// <summary>
        /// Loads Medal data from a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        public static void LoadDataFromCSV(string filePath)
        {
            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the header row
                    reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length == 5)
                        {
                            listMedal.Add(new Medal
                            {
                                Athlete = values[0],
                                Year = int.Parse(values[1]),
                                GoldMedals = int.Parse(values[2]),
                                SilverMedals = int.Parse(values[3]),
                                BronzeMedals = int.Parse(values[4])
                            });
                        }
                        else
                        {
                            Console.WriteLine("Invalid data in the CSV file. Skipping row.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data from CSV: {ex.Message}");
            }
        }

        /// <summary>
        /// Adds a Medalist to the list.
        /// </summary>
        /// <param name="medal">The Medal object to add.</param>
        public static void AddMedalist(Medal medal)
        {
            listMedal.Add(medal);
            Console.WriteLine("Medalist added!");
        }

        /// <summary>
        /// Deletes Medalists based on athlete name and year.
        /// </summary>
        /// <param name="athleteName">The name of the athlete to delete (case-insensitive).</param>
        /// <param name="year">The year to filter by (0 to ignore).</param>
        public static void DeleteMedalist(string athleteName, int year)
        {
            listMedal.RemoveAll(m =>
                (string.IsNullOrEmpty(athleteName) || m.Athlete.IndexOf(athleteName, StringComparison.OrdinalIgnoreCase) >= 0) &&
                (year == 0 || m.Year == year)
            );
            Console.WriteLine("Medalist deleted!");
        }

        /// <summary>
        /// Displays Medalist information.
        /// </summary>
        public static void DisplayMedalists()
        {
            Console.WriteLine("Medalist Information:");
            Console.WriteLine("=====================");

            foreach (var medal in listMedal)
            {
                Console.WriteLine($"Athlete: {medal.Athlete}");
                Console.WriteLine($"Year: {medal.Year}");
                Console.WriteLine($"Gold Medals: {medal.GoldMedals}");
                Console.WriteLine($"Silver Medals: {medal.SilverMedals}");
                Console.WriteLine($"Bronze Medals: {medal.BronzeMedals}");
                Console.WriteLine("---------------------");
            }
        }

        /// <summary>
        /// Searches for Medalists based on a search key (athlete name).
        /// </summary>
        /// <param name="searchKey">The search key (case-insensitive).</param>
        /// <returns>An IEnumerable of Medal objects matching the search key.</returns>
        public static IEnumerable<Medal> Search(string searchKey)
        {
            return listMedal.FindAll(m => m.Athlete.IndexOf(searchKey, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
