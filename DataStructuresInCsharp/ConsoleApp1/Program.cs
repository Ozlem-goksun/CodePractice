using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {

            var stdList = new List<Student>()
            {

                new Student("Joe", "Lion", 8645, false),
                new Student("Hailey", "Tiger", 8646, true),
                new Student("Steve", "Johnsan",8456, false)

            };
            foreach (Student item in stdList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
