using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseNotOrtalamasıOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  Kullanicidan 3 tane not alan ve bu notlarin ortalamasini bulan ve ortalamasi
            //  eger 80-100 araligindaysa A+,
            //  60-79 araligindaysa A,
            //  40-59 araligindaysa B+,
            //  40'tan kucukse F yazdiran ornek kod:

            
            
            Console.WriteLine("Lütfen dersin adını giriniz: ");
            string ders_adi = Console.ReadLine();

            Console.WriteLine("Lütfen " + ders_adi + "dersinin ilk notunu giriniz: ");
            var ilk_not = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen " + ders_adi + "dersinin ikinci notunu giriniz: ");
            var ikinci_not = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen " + ders_adi + "dersinin üçüncü notunu giriniz: ");
            var ucuncu_not = Convert.ToInt32(Console.ReadLine());



            var not_ort = (ilk_not + ikinci_not + ucuncu_not) / 3;



            // The switch cases must be unique constant values. 
            // It can be bool, char, string, integer, enum, or corresponding nullable type.
            // You cannot have range in case.
            // You have to use multiple case.

            // switch case'lerde sabit değerler kullanılmalı
            // bool, char, string, integer, enum veya Null yapılabilir bir değer türü olabilir.
            // case'lerde aralık yoktur, çoklu case kullanmak durumundayız.


            switch ( not_ort )  
            {
                case 100:
                case 99:
                case 98:
                case 97:
                case 96:
                case 95:
                case 94:
                case 93:
                case 92:
                case 91:
                case 90:
                case 89:
                case 88:
                case 87:
                case 86:
                case 85:
                case 84:
                case 83:
                case 82:
                case 81:
                case 80:

                    Console.WriteLine("A+");
                    Console.ReadLine();

                    break;


                case 79:
                case 78:
                case 77:
                case 76:
                case 75:
                case 74:
                case 73:
                case 72:
                case 71:
                case 70:
                case 69:
                case 68:
                case 67:
                case 66:
                case 65:
                case 64:
                case 63:
                case 62:
                case 61:
                case 60:

                    Console.WriteLine("A");
                    Console.ReadLine();

                    break;


                case 59:
                case 58:
                case 57:
                case 56:
                case 55:
                case 54:
                case 53:
                case 52:
                case 51:
                case 50:
                case 49:
                case 48:
                case 47:
                case 46:
                case 45:
                case 44:
                case 43:
                case 42:
                case 41:
                case 40:

                    Console.WriteLine("B+");
                    Console.ReadLine();

                    break;


                default:

                    Console.WriteLine("F");
                    Console.ReadLine();

                    break;
            }










        }
    }
}
