using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVePrivateErisimBelirleyicileri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri customer = new Musteri();

            customer.name = "Yusra Gokce";
            customer.surname = "Celikel";
            customer.salary = 112000;
            customer.gender = "Female";

            //  customer.age = 25;  -> private olduğundan buradan erişilemez!!!

            customer.customer_info(); // !! important !!



            Console.ReadLine();
        }
    }
}
