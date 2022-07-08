using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleIndeksiHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden kitle indeksi hesaplayiciya hosgeldiniz.");
            
            Console.WriteLine("Lütfen kilonuzu kg cinsinden giriniz:");
            float kilo = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Lütfen boyunuzu santimetre cinsinden giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bmi = (kilo / ((boy*0.01) * (boy*0.01)));

            if (bmi >= 30)
            {
                Console.WriteLine("BMI kategorisi: Obezite");

                Console.ReadLine();
            }
            else if (bmi < 30 && bmi >=25)
            {
                Console.WriteLine("BMI kategorisi: Kilolu");

                Console.ReadLine();
            }
            else if (bmi < 25 && bmi >= 18.5)
            {
                Console.WriteLine("BMI kategorisi: Normal kilo");

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("BMI kategorisi: Zayıf");

                Console.ReadLine();
            }

        }
    }
}
