using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(1, "Yusra Gokce", "Celikel", 50, 40, 73, "Inonu Universitesi");

            Console.WriteLine("Uygulamamıza hoşgeldiniz. Yapmak istediğiniz işlemi seçiniz: ");
            guide_info();

            string process_nu = Console.ReadLine();

           while (true)
            {
                switch (process_nu)
                {
                    case "1":

                        student1.student_info();

                        break;

                    case "2":
                        double average = student1.cal_grade();

                        break;

                }
            }
            
            


        }

        static void guide_info()
        {
            Console.WriteLine("1- Öğrenci bilgilerini göster.");
            Console.WriteLine("2- Öğrenci ortalamasını göster.");
            Console.WriteLine("3- Öğrenci okul ismini göster.");
            Console.WriteLine("4- Çıkış yap");

        }










    }
}
