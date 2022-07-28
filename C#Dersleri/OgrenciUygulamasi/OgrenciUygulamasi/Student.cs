using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    public class Student
    {
        private int id;
        private string name;
        private string surname;
        private int midterm1;
        private int midterm2;
        private int final;
        private string school_name;

        public void student_info()
        {

            Console.WriteLine("Öğrenci numarası: " + id);
            Console.WriteLine("Öğrenci ismi: " + name);
            Console.WriteLine("Öğrenci soyismi:" + surname);
            Console.WriteLine("Öğrenci vize1 notu: " + midterm1);
            Console.WriteLine("Öğrenci vize2 notu: " + midterm2);
            Console.WriteLine("Öğrenci final notu: " + final);
            Console.WriteLine("Öğrenci okul ismi: " + school_name);

        }

        public Student(int student_id, string student_name, string student_surname, int student_midterm1, int student_midterm2, int student_final, string student_schoolName)
        {

            id = student_id;
            name = student_name;
            surname = student_surname;
            midterm1 = student_midterm1;
            midterm2 = student_midterm2;
            final = student_final;
            school_name = student_schoolName;

        }
         public double cal_grade()
        {
            double average (midterm1 * 0.2) +(midterm2 * 0.2) + (final * 0.6);

            return average;
        }

        public void school()
        {
            Console.WriteLine("Öğrenci okul ismi: " + school_name);
        }


    }
}
