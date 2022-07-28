using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodlarOrnek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 2 sayı alınacak
            // Büyük olan ekrana yazdırılacak

            Console.Write("Lütfen ilk sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            buyukSayi(sayi1, sayi2);

            Console.ReadLine();

        }

        static void buyukSayi ( int a, int b)
        {

            if ( a > b)
            {
                Console.WriteLine("Büyük olan sayı: " + a);
            }
            else if ( a < b)
            {
                Console.WriteLine("Büyük olan sayı: " + b);
            }
            else
            {
                Console.WriteLine("İki sayı birbirine eşittir.");
            }

        }



    }
}
