using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            client.prpWeight = 55; // değer atama yapıldı
                                   // dolayısıyla set blockları
                                   // çalışır
            Console.WriteLine(client.prpWeight);
            // eğer değer ataması yapılsaydı get blockları çalışırdı
        }
    }
}
