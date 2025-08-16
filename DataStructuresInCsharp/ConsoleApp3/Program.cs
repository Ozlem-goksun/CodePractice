using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher(8645, "Jack","Paul",true);

            Console.WriteLine(teacher);
        }
    }
}
