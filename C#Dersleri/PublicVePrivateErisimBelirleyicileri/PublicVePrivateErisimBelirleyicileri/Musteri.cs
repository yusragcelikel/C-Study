using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicVePrivateErisimBelirleyicileri
{
    class Musteri
    {

        public string name;
        public string surname;
        public int salary;
        public string gender;
        private int age = 25;

        public Musteri()
        {
            Console.WriteLine("Müşteri sınıfının yapıcı metodu çalıştı.");
        }

        public void customer_info()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Age: " + age);

        }

        public void isim_soyisim_yazdir(string customer_name, string customer_surname)
        {
            Console.WriteLine("Müşterinin ismi ve soyismi: " + customer_name + " " + customer_surname);
        }





    }
}
