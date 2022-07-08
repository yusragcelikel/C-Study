using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ********Ogrencinin notu 50'den buyukse basarili degilse basarisiz yazdiran program*********



            int grade = 75;

            if (grade > 50)
            {
                Console.WriteLine("Basarili.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Basarisiz.");
                Console.ReadLine();
            }



        }
    }
}
