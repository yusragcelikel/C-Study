using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotlarGiris2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // parametre alan - geriye değer döndüren metot tanımlama
            // return anahtar kelimesi
            // metot sonu

            int donenDeger = toplamaYap(6,7); // return anahtarı sonuc değişkeninin değerini toplamaYap(6, 7) ye bırakır
            string GelenIsimSoyisimDegeri = isimSoyisimDondur("Yüsra Gökçe", "Çelikel");



            if (donenDeger > 10)
            {
                Console.WriteLine("Değer 10dan büyüktür.");
            }
            else
            {
                Console.WriteLine("Değer 10dan küçüktür.");
            }

            Console.WriteLine(GelenIsimSoyisimDegeri);

            Console.ReadLine(); // main metodudun içinde olacak!!

        }

        static int toplamaYap (int sayi1, int sayi2)
        {

            int sonuc = sayi1 + sayi2;

            return sonuc; // return anahtarı metodu bitirir, return2den sonra yazılan kodlar çalışmaz!!!
                          // return anahtarını, burada değeri döndürmesi için kullandık

        }


        static string isimSoyisimDondur(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }



    }
}
