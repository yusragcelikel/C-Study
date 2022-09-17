using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvan_isim = "Boncuk";
            kedi.hayvan_cinsiyet = "Dişi";
            kedi.hayvan_rengi = "Beyaz";
            kedi.hayvan_yas = 2;

            kedi.hayvanBilgisiGoster();

            Console.ReadLine();
        }
    }
}
