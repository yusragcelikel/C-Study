using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKullanimi
{
    public class Araba
    {

        public int kapi_sayisi;
        public string araba_marka;
        public string araba_rengi;

        public Araba()
        {
            Console.WriteLine("Araba sınıfının yapıcı metodu çalışıyor...");
        }

        public void motor_calistir()
        {
            Console.WriteLine("Motor çalıştırılıyor...");
        }

        public void kapilari_kilitle()
        {
            Console.WriteLine("Kapılar kilitleniyor...");
        }






    }
}
