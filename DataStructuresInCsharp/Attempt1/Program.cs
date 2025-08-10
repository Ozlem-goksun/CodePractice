using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attempt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(23);
            arrayList.Add("sellam");
            arrayList.RemoveAt(2);

            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
