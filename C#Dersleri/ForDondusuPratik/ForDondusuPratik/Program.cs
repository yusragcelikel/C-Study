﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDondusuPratik
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*


                        // 1den 10a kadar olan sayıların alt alta yazdırılması

                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine(i);
                        }

                        Console.ReadLine();


            

            // 1den 10a kadar olan çift sayıları yazdırma

            for (int i = 1; i <= 10 ; i++)
            {
               
                if (i%2 == 0)
                Console.WriteLine(i);

            }

            */

            Console.WriteLine("bir sayı giriniz");
            var sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i  = 1; i <= sayi; i++)
            {
                toplam = toplam + i;
                
            }


            Console.WriteLine(toplam);

            Console.ReadLine();

            

        }
    }
}
