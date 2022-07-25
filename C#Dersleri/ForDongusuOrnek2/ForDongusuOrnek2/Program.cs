using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* 
             * Kullanıcıdan bir sayı alınacak
             * Sıfırdan alınan sayıya kadar olan sayılar toplanacak
             * Toplam alınan sayıya bölünecek
             * Bölümün ortalaması 50den büyükse "Ortalama 50den büyük"
             * Bölümün ortalaması 50den küçükse "Ortalama 50den küçük" yazılacak
             */

            Console.WriteLine("Lütfen bir sayı giriniz:");
            var alinan_sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 0; i <= alinan_sayi; i++)
            {
               
                toplam = toplam + i;

            }

            int ort = (toplam / alinan_sayi) / 2;

            if (ort > 50)
            {

                Console.WriteLine("Ortalama 50den büyük");

            }

            else if (ort == 50) {
                Console.WriteLine("Ortalama 50ye eşit");
            }

            else
            {
                Console.WriteLine("Ortalama 50den küçük");
            }


            Console.ReadLine();


        }
    }
}
