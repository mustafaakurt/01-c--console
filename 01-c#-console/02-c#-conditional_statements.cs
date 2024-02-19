using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _02_c__conditional_statements
    {
        static void Main(string[] args)
        {
            // If-else 
            //
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Poizitif");
            }
            else if (num == 0)
            {
                Console.WriteLine("Sıfır");
            }
            else
            {
                Console.WriteLine("Negatif");
            }


            // tek çift kontrol
            Console.WriteLine("Sayıyı giriniz");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Çift sayı");
            }
            else
            {
                Console.WriteLine("Tek sayı");
            }

            // Switch - case
            int num2;
            Console.Write("1 ile 7 arasında bir sayı giriniz: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            switch (num2)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }

            Console.ReadLine();
        }
    }
}
