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
            Console.WriteLine("Lutfen bir sayi giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            var numStack = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                numStack.Push(k);
                sayi = sayi / 10;
            }

            foreach (var item in numStack)
            {
                Console.Write(item);
            }


        }
    }
}
