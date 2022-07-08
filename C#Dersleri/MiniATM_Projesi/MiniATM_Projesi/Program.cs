using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM_Projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             *  kullaniciya nasil bir islem yapmak istedigi sorulacak.
             *  Bakiye goruntuleme icin 1 tusuna,
             *  Para cekmek icin 2 tusuna,
             *  Para yatirmak icin 3 tusuna,
             *  Cikmak icin ise q tusuna basilacak.
             *  
             */

            int bakiye = 10000;

            Console.WriteLine("Nasil bir islem yapmak istersiniz?");
            Console.WriteLine("Bakiye goruntuleme icin 1 tusuna basiniz.");
            Console.WriteLine("Para cekmek icin 2 tusuna basiniz.");
            Console.WriteLine("Para yatirmak icin 3 tusuna basiniz.");
            Console.WriteLine("Cikmak istiyorsamiz q tusuna basiniz.");

            string yapilanIslem = Console.ReadLine();

            if (yapilanIslem == "1")
            {
                Console.WriteLine("Bakiyeniz: " + bakiye);
                Console.WriteLine("Isleminizi tamamladiniz. Cikis yapmak icin enter tusuna basiniz. Iyi Gunler...");
     
                Console.ReadLine();
            }
            else if (yapilanIslem == "2")
            {
                Console.WriteLine("Cekmek istediginiz miktarı giriniz:");
                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                

                if (cekilecekTutar > 5000)
                {
                    Console.WriteLine("5000'den fazla cekemezsiniz.");
                    Console.WriteLine("Isleminizi tamamladiniz. Cikis yapmak icin enter tusuna basiniz. Iyi Gunler...");

                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Paranizi bolmeden aliniz.");
                    Console.WriteLine("Yeni bakiyeniz: " + (bakiye - cekilecekTutar));
                    Console.WriteLine("Isleminizi tamamladiniz. Cikis yapmak icin enter tusuna basiniz. Iyi Gunler...");


                    Console.ReadLine();

                }


            }
            else if (yapilanIslem == "3")
            {
                Console.WriteLine("Yatırmak istediginiz miktarı giriniz:");
                int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz: " + (bakiye + yatirilacakTutar));
                Console.WriteLine("Isleminizi tamamladiniz. Cikis yapmak icin enter tusuna basiniz. Iyi Gunler...");


                Console.ReadLine();

            }
            else if (yapilanIslem == "q")
            {
                Console.WriteLine("Cikis yapmak istediniz.");
                Console.WriteLine("Cikis yapmak icin enter tusuna basiniz. Iyi Gunler...");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Lütfen gecerli bir deger giriniz.");
                Console.WriteLine("Cikis yapmak icin enter tusuna basiniz. Iyi Gunler...");

                Console.ReadLine();

            }

        }
    }
}
