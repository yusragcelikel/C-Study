using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToplamaveCikarmaOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi_1 = 5;
            int sayi_2 = 12;
            int sayi_3 = 32;

            int sayi_4 = 18;

            int sonuc = (sayi_1 + sayi_2 + sayi_3) - sayi_4;

            Console.WriteLine(sonuc);

            Console.ReadLine();

        }
    }
}
