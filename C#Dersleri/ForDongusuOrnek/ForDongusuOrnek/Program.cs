using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan bir sayı alınacak
            // 0dan başlayıp alınan sayıya kadar sayılar toplanacak
            // toplam, kullanıcıdan daha önce alınan sayıya bölünecek
            // eğer ortalama 50den büyükse "ortalama 50den büyüktür" yazılacak
            // ortalama 50den kiçükse "ortalama 50den küçüktür" yazılacak


            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i<=sayi; i++)
            {
                toplam += i;  // toplam = toplam + 1
            }

            double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalama 50den büyüktür.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Ortalama 50den küçüktür.");
                Console.ReadLine();
            }




        }
    }
}
