using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeyaGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.setName("Yusra Gokce"); // setName içine değer ataması yapıldı

            string gotName = student.getName();

            if (gotName == "Yusra Gokce")
            {
                Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("başarısız");
            }

            Console.ReadLine();
        }

    }
}
