using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1den 10a kadar olan sayıları ekrana yazdırma


            /* 
            int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 10);
            
            Console.ReadLine();
            */

            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a <= 100);

            Console.WriteLine("1den 100e kadar olan sayıların toplamı: " + toplam);

            Console.ReadLine();
        }
    }
}
