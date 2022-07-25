using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuPratik2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1den 100e kadar çift sayıların yazdırılıması

            Console.WriteLine("All odd numbers from 1 to 100: ");


            for (int i = 1; i <= 100 ; i++ )
            {
                
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

                
            }
            Console.ReadLine();



        }
    }
}
