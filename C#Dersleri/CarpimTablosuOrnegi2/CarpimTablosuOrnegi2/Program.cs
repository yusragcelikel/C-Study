using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosuOrnegi2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int carpim;

            for(int i =1; i <= 10; i++)
            {
               // int carpim;
                
                for (int j = 1; j <= 10; j++)
                {

                    carpim = i*j;
                   
                    Console.WriteLine(i + "x" + j + "=" + carpim);

                }


            }

            Console.ReadLine();





        }
    }
}
