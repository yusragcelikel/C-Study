using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[4]; // sayilar değişkeni 4 elemanlı bir dizi

            sayilar[0] = 10;    // 0.index değeri 10
            sayilar[1] = 20;    // 1.index değeri 20
            sayilar[2] = 30;    // 2.index değeri 30
            sayilar[3] = 40;    // 3.index değeri 40

            for (int i = 0; i < sayilar.Length; i++)    // sayılar dizisini ekrana yazmak için
            {
               
                Console.WriteLine(sayilar[i]);

            }

            Console.ReadLine();


        }
    }
}
