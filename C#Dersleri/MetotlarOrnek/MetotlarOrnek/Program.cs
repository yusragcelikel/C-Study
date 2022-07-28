using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayının karesi alınır
            // Eğer karesi 25ten büyükse "karesi 25ten büyük"
            // Değilse "karesi 25ten küçük" yazdırılacak

            Console.Write("Lütfen bir tam sayı giriniz: ");

            karesi ();

            Console.ReadLine();

        }

        static void karesi()
        {

            int alinan_sayi = Convert.ToInt32(Console.ReadLine());
            int sonuc = alinan_sayi * alinan_sayi;

            if (sonuc > 25)
            {
                Console.WriteLine("Karesi 25ten büyük");
            }
            else if (sonuc < 25)
            {
                Console.WriteLine("Karesi 25ten küçük");
            }
            else
            {
                Console.WriteLine("Karesi 25e eşit");
            }

        }

             

    }
}
