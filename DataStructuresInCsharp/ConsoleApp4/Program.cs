using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baslik giriniz : ");
            string baslik = Console.ReadLine();

            baslik = baslik.ToLower();

            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ğ','g'},
                {'ö','o'},
                {'ş','s'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {',','-'}

            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(baslik);

        }
    }
}
