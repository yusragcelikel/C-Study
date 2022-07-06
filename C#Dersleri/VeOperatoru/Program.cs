using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi_1 = 5;

            int sayi_2 = 5;

            int sayi_3 = 10;


            bool kontrol_et = sayi_1 == sayi_2 && sayi_1 <sayi_3;

            Console.WriteLine(kontrol_et);

            Console.ReadLine();

        }
    }
}
