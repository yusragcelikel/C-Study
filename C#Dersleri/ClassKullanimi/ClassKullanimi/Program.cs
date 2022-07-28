using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();

            araba1.kapi_sayisi = 4;
            araba1.araba_rengi = "Kırmızı";
            araba1.araba_marka = "Dodge";

            araba1.kapilari_kilitle();
            araba1.motor_calistir();

            Console.WriteLine("Arabanın kapı sayısı: " + araba1.kapi_sayisi);
            Console.WriteLine("Araba rengi: " + araba1.araba_rengi);
            Console.WriteLine("Arabanın modeli: " + araba1.araba_marka);

            Console.ReadLine();
        }
    }
}
