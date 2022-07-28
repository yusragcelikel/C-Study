using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnekVersion2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayının karesi alınır
            // Eğer karesi 25ten büyükse "karesi 25ten büyük"
            // Değilse "karesi 25ten küçük" yazdırılacak

            Console.Write("Lütfen bir sayı giriniz: ");
            int alinan_sayi = Convert.ToInt32(Console.ReadLine());

            int karesi = karesiniAl(alinan_sayi);

            if (karesi > 25)
            {
                Console.WriteLine("Karesi 25ten büyüktür.");
            }
            else if (karesi < 25)
            {
                Console.WriteLine("Karesi 25ten küçüktür.");
            }
            else
            {
                Console.WriteLine("Karesi 25e eşittir.");
            }

            Console.ReadLine();

        }

        static int karesiniAl (int a) 
        {
            return a * a;
        }

    }
}
