using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOdev
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.prpIdNo = "12345678912";
            Console.WriteLine("Kimlik numaranız: " + employee.prpIdNo);

            Console.ReadLine();
        }
    }
}
