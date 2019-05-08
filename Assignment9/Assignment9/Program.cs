using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;

namespace Assignment9
{
    class Program
    {
        private static StringCollection favoriteCities = new StringCollection();
        private static string selection;

        static void Main(string[] args)
        {
            favoriteCities.Add("Seattle");
            favoriteCities.Add("Chicago");

            string headers = string.Format("\nIndex  Favorite Cities\n-----  ---------------");
            string menu = string.Format("\nM E N U\n  A - Add a city to the Collection\n  R - Remove a city from the Collection\n  X - Exit the Application");
            string select = string.Format("\nSelect an A, R or X -> ");

            Console.WriteLine("Cameron Helkuik");
            Console.WriteLine("Assignment 9 - Working with StringCollections");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(headers);

            foreach (string city in favoriteCities)
            {
                Console.WriteLine("{0,3}    {1}", favoriteCities.IndexOf(city), city);
            }

            Console.WriteLine(menu);

            Console.Write(select);
            selection = Console.ReadLine();

            while (selection != "end")
            {
                if (selection.ToLower() == "a")
                {
                    Console.Write("Add a new city or an 'x' to exit adding -> ");
                    var cityOrX = Console.ReadLine();

                    while (cityOrX.ToLower() != "x")
                    {
                        Console.Write("At which index between '0' and '{0}'? -> ", favoriteCities.Count.ToString());
                        var index = int.Parse(Console.ReadLine());

                        favoriteCities.Insert(index, cityOrX);

                        Console.WriteLine("Added {0} at Index {1}", cityOrX, index);

                        Console.Write("Add another new city or 'x' to exit adding -> ");
                        cityOrX = Console.ReadLine();

                    }

                    Console.WriteLine(headers);

                    foreach (string city in favoriteCities)
                    {
                        Console.WriteLine("{0,3}    {1}", favoriteCities.IndexOf(city), city);
                    }

                    Console.WriteLine(menu);

                    Console.Write(select);
                    selection = Console.ReadLine();

                }
                else if (selection.ToLower() == "r")
                {

                    Console.Write("Remove a city from which index? -> ");
                    var remove = int.Parse(Console.ReadLine());

                    var cityRemoved = favoriteCities[remove];

                    favoriteCities.RemoveAt(remove);

                    Console.WriteLine("Removed {0} at Index {1}", cityRemoved, remove);

                    Console.WriteLine(headers);

                    foreach (string city in favoriteCities)
                    {
                        Console.WriteLine("{0,3}    {1}", favoriteCities.IndexOf(city), city);
                    }

                    Console.WriteLine(menu);

                    Console.Write(select);
                    selection = Console.ReadLine();
                }
                else if (selection.ToLower() == "x")
                {
                    Console.WriteLine("Program ends {0}", DateTime.Now);
                    Console.WriteLine("Press the Enter key to continue.");
                    Console.ReadLine();

                    selection = "end";
                }
            }

        }
    }
}
