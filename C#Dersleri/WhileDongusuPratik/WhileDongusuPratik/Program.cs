using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDongusuPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1den 10a kadar olan sayıları ekrana yazdırma
             

            int a = 1;

            while (a <= 10 )
            {
                
                Console.WriteLine(a);
                a++;

            }


         //   Console.ReadLine();



            //100den 0a kadar olan sayılardan çift olanları büyükten küçüğe ayzdırma

            int b = 100;

            while (b>=0)
            {
                

                if (b%2 == 0)
                {
                    Console.WriteLine(b);
                }

                b--;

            }

            Console.ReadLine();


        }
    }
}
