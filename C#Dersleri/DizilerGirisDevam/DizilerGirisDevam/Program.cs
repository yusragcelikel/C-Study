using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerGirisDevam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // -----string-----
            // -----double-----
            // -----char-------

            /*
             * string[] isimler = new string[4]
             */

            // -------------------veya----------------

            /*
             * string[] isimler = { "Enes", "Yasin", "Mehmet", "Ercan" };
             * Console.WriteLine(isimler[2]);
             * 
             * Console.ReadLine();
             */



            // ------------tüm diziyi ekrana yazdırmak için:-----------------

            Console.WriteLine("-------string veri tipinde dizi: -------");

            string[] strings = { "Enes", "Yasin", "Mehmet", "Ercan" };

            for (int i = 0; i<strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }


            Console.WriteLine("-------double veri tipinde dizi: -------");

            double[] doubles = { 1.44, 7.66, 8.34, 10.5 };

            for (int j = 0; j<doubles.Length; j++)
            {
                Console.WriteLine(doubles[j]);
            }

            Console.WriteLine("-------char veri tipinde dizi: -------");

            char[] chars = { 'y', 'ü', 's', 'r', 'a' };
            
            for (int t = 0; t<chars.Length; t++)
            {
                Console.WriteLine(chars[t]);
            }

            Console.ReadLine();
            
        }
    }
}
