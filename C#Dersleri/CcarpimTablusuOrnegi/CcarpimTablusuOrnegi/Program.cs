﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CcarpimTablusuOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // for döngüsüyle çarpım tablosu

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + (i * j));
                }
            }

            Console.ReadLine();




        }
    }
}
