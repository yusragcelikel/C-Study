using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi_1 = 3;
            int sayi_2 = 3;
            int sayi_3 = 6;

            bool kontrol_et = sayi_1 == sayi_2 || sayi_2 > sayi_3;

            Console.WriteLine(kontrol_et);

            Console.ReadLine();

        }
    }
}
