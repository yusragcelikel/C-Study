
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodlarOrnek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan alınan sayının tek mi çift mi olduğunu bulan metoh örneği

            Console.Write("Lütfen bir tam sayı giriniz: ");
            int alinan_sayi = Convert.ToInt32(Console.ReadLine());

            odd_even(alinan_sayi);

            Console.ReadLine();

        }

        static void
            odd_even (int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir");
            }

            
        }

    }
}
