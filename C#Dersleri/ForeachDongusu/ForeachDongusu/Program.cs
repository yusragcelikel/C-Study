using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };

            /*

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }

            */

            foreach (var a in strings)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();

        }
    }
}
