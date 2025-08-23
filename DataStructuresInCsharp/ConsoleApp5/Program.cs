using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var icindekiler = new SortedList()
            {
                {5, "Bolum bir"},
                {23, "Bolum iki"},
                {58, "Bolum dort"},
                {89, "Bolum bes"}

            };

            Console.WriteLine("icindekiler");
            Console.WriteLine(new string('=',23));
            foreach ( DictionaryEntry i in icindekiler)
            {
                Console.WriteLine($"{i.Key, -5}{i.Value}");
            }
        }
    }
}
