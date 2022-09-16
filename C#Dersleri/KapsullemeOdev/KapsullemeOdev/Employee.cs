using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeOdev
{
    public class Employee
    {
        private string idNo;

        public string prpIdNo 
        { 
            get 
            { 
                return idNo.Substring(0,5)+"******"; // ilk 5 rakamı gösterir
            } 
            set 
            {
                bool control = false;

                if (value.Length == 11) 
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool isNumber = char.IsNumber(value[i]);

                        if (isNumber)
                        {
                            // yapılması gereken bir şey yok
                        }
                        else
                        {
                            control = true;
                            break; // içlerinden biri numara değilse diğerlerine bakmaay gerek yok
                        }
                    }
                    if (control)
                    {
                        Console.WriteLine("Kimlik numaranızda geçersiz karakter bulundu!");
                    }
                    else
                    {
                        idNo = value;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Girdiğiniz Kimlik No 11 karakter değildir!");
                }
            } 
        }
    }
}
