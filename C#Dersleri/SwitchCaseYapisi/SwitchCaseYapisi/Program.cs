using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mini ATM Uygulaması 
            // kullanıcıdan bir değer alalım aldığımız değere göre Switch-Case kullanarak işlemler yapalım.
            // 1- bakiye görüntüleme
            // 2- para çek
            // 3- para yatır
            // 4- çıkış yap
            // 1-2-3-4 dışında bir değer ise hata versin

            int bakiye = 700;

            Console.WriteLine("Atm ye hoşgeldiniz...");

            Console.WriteLine("lütfen bir işlem seçiniz");

            Console.WriteLine("1- bakiye görüntüle");
            Console.WriteLine("2- para çek");
            Console.WriteLine("3- para yatır");
            Console.WriteLine("4- çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":

                    Console.WriteLine("Bakiyeniz: " +bakiye);
                    Console.ReadLine();
                    break;

                case "2":

                    Console.WriteLine("çekmek istediğiniz tutarı giriniz: ");
                    int cekilecek_tutar =  Convert.ToInt32(Console.ReadLine());

                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("yetersiz bakiye");
                        Console.ReadLine();

                    }

                    else
                    {
                        Console.WriteLine("kalan bakiyeniz: " + (bakiye - cekilecek_tutar));
                        Console.ReadLine();

                    }
                    break;

                case "3":
                    Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yheni bakiyeniz: " + (bakiye+yatirilacak_tutar));
                    Console.ReadLine();

                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan çıkış yapılıyor. İyi günler...");
                    Console.ReadLine();

                    break;

                default:
                    Console.WriteLine("lütfen geçerli bir değer girin");
                    Console.ReadLine();

                    break;


            }





        }
    }
}
