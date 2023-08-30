using Bank_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visa visa = new Visa();         
            Console.WriteLine(visa.CheckBalance());
            Console.WriteLine(visa.ProcessPayment(1));
        }
    }
}
