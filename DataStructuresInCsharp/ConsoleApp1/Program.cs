using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>
            {
                "New York",
                "Los Angeles",
                "Texas",
                "Paris"
            };

            // Lambda Expression
            cities.ForEach(city => Console.WriteLine(city));

            Console.WriteLine(new string('-', 13));

            var iller = cities;
            iller.ForEach(city => Console.WriteLine(city));
            Console.WriteLine(new string('-', 13));
            cities.Add("İstanbul");
            cities.ForEach(city => Console.WriteLine(city));
            Console.WriteLine(new string('-', 13));
            iller.ForEach(city => Console.WriteLine(city));

            iller.Remove("İstanbul");
            Console.WriteLine(new string('-', 13));
            cities.ForEach(city => Console.WriteLine(city));
        }
    }
}
