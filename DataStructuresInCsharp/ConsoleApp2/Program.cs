using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Program
    {
        static void Main(string[] args)
        {
            var point1 = new Point(56, 96);
            Console.WriteLine(point1);
            point1.Change();
            Console.WriteLine(point1);
            var point2 = point1;
            Console.WriteLine(point2);

            point2.XPoint = -1 * point2.XPoint;
            Console.WriteLine(point1);
            Console.WriteLine(point2);

        }
    }
}
