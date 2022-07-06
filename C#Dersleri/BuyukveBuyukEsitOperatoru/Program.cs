using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukveBuyukEsitOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int yas = 18;

            bool kontrol_et = yas > 18;
            bool kontrol_et_2 = yas >= 18;

            Console.WriteLine(kontrol_et);
            Console.WriteLine(kontrol_et_2);

            Console.ReadLine();

        }
    }
}
