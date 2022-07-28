using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlaraGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Parametresiz - geriye döndürmeyen metot tanımlama  

            SelamVer();
            AdiniYazdir();

            // Parametre alan - geriye değer döndürmeyen metot yazma

            toplamaYap (5, 7);
            carpmaYap (5, 7, 10);
            isimSoyisimYazdirma("Yüsra Gökçe", " Çelikel");

        }


        static void SelamVer ()
        {

            Console.WriteLine("Selamlar!");

        }

        static void AdiniYazdir()
        {

            Console.WriteLine("Yüsra Gökçe Çelikel");
         // Console.ReadLine();

        }

        // -------------------------------------------------------------

        static void toplamaYap (int sayi1, int sayi2) // sayi1 ve sayi2 değişkenleri aşağıdaki metot tarafından görülmez
        {                                             // dolayısıyla aşağıdaki metottaki say1 ve sayi2 değişkenleri farklı değişkenlerdir.

            Console.WriteLine("Gönderilen sayıların toplamı: " + (sayi1 + sayi2));

        }

        static void carpmaYap (int sayi1, int sayi2, int sayi3)
        {

            Console.WriteLine("Gönderilen sayıların çarpımı: " + (sayi1 * sayi2 * sayi3));
         // Console.ReadLine();

        }

        static void isimSoyisimYazdirma (string isim, string soyisim)
        {

            Console.WriteLine("İsim ve soyisim: " + isim + soyisim);
            Console.ReadLine();

        }

    }
}
