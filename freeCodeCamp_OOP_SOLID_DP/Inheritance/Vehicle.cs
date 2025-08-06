using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Vehicle
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void start()
        {
            Console.WriteLine("Vehicle is starting.");
        }

        public void stop()
        {
            Console.WriteLine("Vehicle is stoping.");
        }
    }
}
