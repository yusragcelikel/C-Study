using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            int a = 5;

            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);

            */





            //   --------------------------------------





            //    ***************** String'den integer'a donusturme *****************


            /*
             * 
            string sayi_1 = "1";
            string sayi_2 = "2";
            
            
            int a = int.Parse(sayi_1);   // sayi_1 al integer'a donustur. Parse in Turkish "donustur"
            int b = int.Parse(sayi_2);

            Console.WriteLine( a + b);

            

            // --------- veya -----------


            int a = Convert.ToInt32(sayi_1);
            int b = Convert.ToInt32(sayi_2);


            Console.WriteLine(a + b);

            */



            //    ***************** Integer'dan string'e donusturme *****************


            /*
             
            int sayi_1 = 5;
            int sayi_2 = 10;

            string a = sayi_1.ToString();
            string b = sayi_2.ToString();


            Console.WriteLine(b + a);

            */



            //   ---------------------------------------------------




            //    ***************** Double veri tipinden integer veri tipine dönüştürme  *****************

            /*

            double sayi = 5.22;

            Console.WriteLine(sayi);
            Console.WriteLine(sayi.GetType());

            double sayi1 = 5.22;

            int a = Convert.ToInt32(sayi1);

          //int b = int.Parse(sayi1);   // hata verir. Hata sebebi; önce stringe dönüştürmemizi ister.  

            Console.WriteLine(a);
            Console.WriteLine(a.GetType());

            */
            

            

            //    ***************** kulllanıcıdan 2 sayıyı ala ve ikisinin toplamını akrana yazan program  *****************


            Console.WriteLine("Lütfen bir sayı giriniz:");
            string a = Console.ReadLine();
            int a_Int = int.Parse(a);

            Console.WriteLine("Lütfen bir sayı giriniz:");
            string b = Console.ReadLine();
            int b_Int = int.Parse(b);

            Console.WriteLine("Girilen iki sayının toplamı:");
            Console.WriteLine(a_Int + b_Int);




            Console.ReadLine();
            
        }
    }
}
