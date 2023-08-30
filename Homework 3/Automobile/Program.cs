using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan("Mercedes","2011");
            Sedan sedan2 = new Sedan("BMW","2015");
            SUV suv = new SUV("Lamborghini","2019");
            Hatchback hatch = new Hatchback("Hyundai","2013");
            Console.WriteLine(sedan.ReturnData());
            Console.WriteLine(sedan2.ReturnData());
            Console.WriteLine(suv.ReturnData());
            Console.WriteLine(hatch.ReturnData());
        }
    }
}
