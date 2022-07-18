using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakveContinueAnahtarKelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    break;  // döngüden tamamen çıkar
                }
                Console.WriteLine("a'nın değeri: " + a);

            }

            //  Console.ReadLine();



            Console.WriteLine("---------------------------");



            for (int b = 1; b <= 10; b++)
            {
                if(b==7)
                {
                    continue; // döngüyü bir kereliğine kırar
                }
                Console.WriteLine("b'nin değeri: " + b);

            }


            Console.ReadLine();

        }
    }
}
