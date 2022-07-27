using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziOrnek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan bir sayı alınır.
            // Bu sayı tanımlı dizi içerisinde aratılır.
            // Eğer dizi içinde varsa kaç tane olduğunu,
            // Yoksa da "yoktur" yazan program:

            int[] ints = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };
            int count = 0;

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int alinan_sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == alinan_sayi )
                {

                    count = count + 1;

                }

            }
            if (count == 0)
            {
                Console.WriteLine("Girdiğiniz sayı tanımlı dizide bulunmamaktadır.");

            }
            
            else
            {
                Console.WriteLine("Girdiğiniz sayıdan " + count + " tane vardır.");
            }
            
            Console.ReadLine();


        }
    }
}
