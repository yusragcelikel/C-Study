using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenKullanımı
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan C1 = new Calisan();

            C1.calisanID = 1;
            C1.isim = "Yusra Gokce";
            C1.soyisim = "Celikel";
            Calisan.maas = 2500;

            Console.WriteLine("çalışan id: " + C1.calisanID);
            Console.WriteLine("çalışan isim: " + C1.isim);
            Console.WriteLine("çalışan soyisim: " + C1.soyisim);
            Console.WriteLine("çalışan maaş: " + Calisan.maas);

            Console.ReadLine();
        }
    }
}
