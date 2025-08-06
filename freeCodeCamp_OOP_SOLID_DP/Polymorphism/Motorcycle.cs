using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Motorcycle : Vehicles
    {
        int NumberOfWheels { get; set; }

        public override void Start()
        {
            Console.WriteLine("Motorcycle is starting.");
        }
        public override void Stop()
        {
            Console.WriteLine("Motorcycle is stopping.");
        }
    }
}
