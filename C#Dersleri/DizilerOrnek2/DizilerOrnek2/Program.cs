using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 10 tane int veri tipine sahip sayı alınır.
            // Kaç adet çift sayı, kaç adet tek sayı olduğunu belirten,
            // Çift değerlerin toplamını, tek değerlerin topamını belirten;
            // Çift değerlerin toplamı tek değerlerin toplamından büyükse belirtsin.
            // Tek değerlerin toplamı çift değerlerin toplamından büyükse belirtsin.

            int even_count = 0;
            int odd_count = 0;
            int even_add = 0;
            int odd_add = 0;
            int alinan_sayi;
            
            int[] ints = new int[10];


            for (int i = 0; i < ints.Length; i++)
            {

                Console.Write ("Lütfen dizinin " + i + ". index tam sayı değerini giriniz: ");
                alinan_sayi = Convert.ToInt32(Console.ReadLine());

            }
            
            Console.ReadLine();
            




            // to be continued




        }
    }
}
