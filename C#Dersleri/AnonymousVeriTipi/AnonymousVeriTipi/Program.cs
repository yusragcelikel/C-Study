using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 * 
 * C#'ta anonim tipi, yalnızca public salt okunur özellikleri içerebilen
 * herhangi bir adı olmayan bir veri tipidir (sınıf).
 * 
*/


namespace AnonymousVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var student = new { Id = 1, FirstName = "James", LastName = "Bond" };

            Console.WriteLine(student.Id); // Id'nin veri tipi int
            Console.WriteLine(student.FirstName); // FirstName'in veri tipi string
            Console.WriteLine(student.LastName);  // LastName'in veri tipi string

            /*
             * 
             *  Değişkenler, nesne değişkenlerinde olduğu gibi nokta (.) 
             *  gösterimi kullanılarak erişilebilir. Ancak, salt okunur 
             *  oldukları için değişkenlerin değerlerini değiştiremezsiniz.
             * 
            */




            // bu bi yorumdur

            Console.ReadLine();

        }
    }
}
