using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new LinkedList<string>();
            cities.AddFirst("Ordu");
            cities.AddFirst("Trabzon");
            cities.AddLast("Istanbul");

            cities.AddAfter(cities.Find("Ordu"), "Samsun");
            cities.AddBefore(cities.First.Next.Next, "Giresun");
            cities.AddAfter(cities.Last.Previous, "Sinop");

            foreach (string s in cities)
            {
                Console.WriteLine(s);
            }

        }
    }
}
