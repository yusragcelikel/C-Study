﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziKullanıcıdanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // dizinin elemanlarını kullanıcıdan alma  ve ekrana yazma

            int[] sayilar = new int[4];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("Sayılar dizisinin " + i + ". indexini giriniz:");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.ReadLine();

        }
    }
}
