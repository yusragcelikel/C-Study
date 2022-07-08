using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapisiNotOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Kullanicidan 3 tane not alan ve bu notlarin ortalamasini bulan ve ortalamasi
            //  eger 80-100 araligindaysa A+,
            //  60-79 araligindaysa A,
            //  40-59 araligindaysa B+,
            //  40'tan kucukse F yazdiran ornek kod:

            Console.WriteLine("Lütfen dersin adini giriniz:");
            string dersinAdi = Console.ReadLine();

            Console.WriteLine("Lütfen " + dersinAdi + " dersinin ilk notunuzu giriniz:");
            int firstGrade_int = Convert.ToInt32(Console.ReadLine());

            //  Console.WriteLine(FirstGrade_int.GetType());

            Console.WriteLine("Lütfen " + dersinAdi + " dersinin ikinci notunuzu giriniz:");
            int secondGrade_int = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen " + dersinAdi + " dersinin ucuncu notunuzu giriniz:");
            int thirdGrade_int = Convert.ToInt32(Console.ReadLine());


            int average = (firstGrade_int + secondGrade_int + thirdGrade_int) / 3;

            if (average <= 100 && average >= 80)
            {
                Console.WriteLine(dersinAdi + " dersinin harf karsiliği: A+");
                Console.ReadLine();
            }
            else if (average < 80 && average >= 60)
            {
                Console.WriteLine(dersinAdi + " dersinin harf karsiliği: A");
                Console.ReadLine();
            }
            else if (average < 60 && average >= 40)
            {
                Console.WriteLine(dersinAdi + " dersinin harf karsiliği: B+");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(dersinAdi + " dersinin harf karsiliği: F");
                Console.ReadLine();
            }

            

        }
    }
}
