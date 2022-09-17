using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanimi
{
    public class Kullanici 
    {
        private int kullaniciID { get; set; } //property tanımlandı
        private string isim { get; set; } //property tanımlandı
        private string soyisim { get; set; } //property tanımlandı
        private static int maas { get; set; } //property tanımlandı

        static Kullanici() // static yapıcı metot
        {
            maas = 2500;
        }

        public Kullanici(int kullaniciId, string consIsim, string soyIsim) // yapıcı metodumuz
        {
            kullaniciID = kullaniciId;
            isim = consIsim;
            soyisim = soyIsim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("Kullanıcı bilgiler: ");
            Console.WriteLine("Id: " + kullaniciID);
            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Maaş: "+ maas);


        }
        public void zamYap(int zamMiktari)
        {
            Console.WriteLine("Kullanıcıya zam yapılıyor...");
            Console.WriteLine("Şuanki maaşı:" + (maas + zamMiktari));
        }
    }
}
