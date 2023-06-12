using System;

namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car VAZ = new Car(0,"Vaz",90,2000);
            Car Lambo = new Car(1,"Lamborgambor",320,100000);
            Car Muravey = new Car(2,"Muravey",10,100);
            Car[] cars = new Car[] { VAZ, Lambo, Muravey };
            Gallery gal = new Gallery("VIP Motors",cars);
            //gal.FindMostExpensive();
            Console.WriteLine(gal.FindCarById(1)); 
        }
    }
}
