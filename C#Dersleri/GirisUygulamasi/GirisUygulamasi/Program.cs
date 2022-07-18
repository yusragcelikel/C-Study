using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirisUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı giriş sayfası uygulaması
            // kullanıcı asi ve şifresini doğru girerse "tebrikler başarılı bir şekilde giriş yaptınız"
            // yanlış girerse "hata" alınacak ve 3 hak verilecek

            int hak_sayisi = 3;

            while (true)
            {
                Console.WriteLine("kullanıcı adınızı giriniz: ");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("şifrenizi giriniz: ");
                string sifre = Console.ReadLine();

                if (kullaniciAdi == "yusra" && sifre == "123")
                {
                    Console.WriteLine("tebrikler başarılı");
                    break;
                }

                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz hatalı !");

                    if (hak_sayisi >0)
                    {
                        hak_sayisi -= 1;
                    }

                    if (hak_sayisi == 0)
                    {
                        Console.WriteLine("3 kez hatalı giriş yaptınız ! Daha fazla giriş yapamazsınız !");
                        break ; 
                    }
                }


            }
            Console.ReadLine();

        }
    }
}
