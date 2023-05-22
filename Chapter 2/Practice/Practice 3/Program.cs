using System;
using System.Collections.Generic;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Phone phone = new Phone("0000AX", "Iphone", "Pro Max", 690,12);
            Phone phone1 = new Phone("0000AF", "Iphone", "XS Max", 300, 12);
            Phone phone2 = new Phone("0000AC", "Iphone", "11 Max", 300,3);

            Store store = new Store("Bababooey Phone Store",phones);
            Console.WriteLine(phone.ShowInfo());
            store.SellItem("0000AX",1);
            Console.WriteLine(store.Revenue);
            foreach (Phone item in store.GetAllPhones())
            {
                Console.WriteLine(item.ShowInfo());
            }
            Console.WriteLine(store.GetPhoneInRange(100,700));

        }
    }
}
