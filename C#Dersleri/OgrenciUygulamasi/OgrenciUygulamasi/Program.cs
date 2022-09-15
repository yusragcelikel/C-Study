using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
     class Program
    {
        static void Main(string[] args)
        {

            bool control = true;

            Student student1 = new Student(1, "Yusra Gokce", "Celikel", 80, 85, 82, "Inonu Universitesi");
            guide_info();
            Console.WriteLine("Uygulamamıza hoşgeldiniz. Yapmak istediğiniz işlemi seçiniz: ");



            while (control)
            {
                string process_nu = Console.ReadLine();

                switch (process_nu)
                {
                    case "1":

                        student1.student_info();
                        break;

                    case "2":

                        double average = student1.cal_grade();
                        Console.WriteLine("Öğrencinin ortalaması: " + average);
                        break;

                    case "3":

                        student1.school();
                        break;

                    case "4":

                        control = false;
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
