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
            var charQueue = new Queue<char>();

            charQueue.Enqueue('a');
            charQueue.Enqueue('e');

            foreach (char c in charQueue)
            { 
                Console.WriteLine(c); 
            }

            charQueue.Dequeue();

            foreach (var item in charQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
