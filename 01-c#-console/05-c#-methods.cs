using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _05_c__methods
    {
        private static int Topla(int a, int b)
        {
            return a + b;
        }

        private static int Kupu(int a)
        {
            return a * a * a;
        }

        private static int factorial(int num)
        {
            int fact = 1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            return fact;
        }
        // recursive faktöriyel method
        private static int factorial_recursive(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return num * factorial_recursive(num - 1);
            }
        }
        


        static void Main(String[] args)
        {
            //Methodlar
            // Methodlar tekrar tekrar kullanılabilir kod bloklarıdır
            // Methodlar geriye bir değer döndürebilirler
            // Methodlar parametre alabilirler

            // Method tanımlama
            // Erişim_belirleyici geri_dönüş_tipi method_ismi(parametre_listesi)

            // Topla methodunu çağırma
            int toplam = Topla(5, 6);
            Console.WriteLine(toplam);


            // Kupu methodunu çaırma
            int kup = Kupu(5);
            Console.WriteLine(kup);

            // Factorial methodunu çağırma
            int fact = factorial(5);
            Console.WriteLine(fact);

            // Recursive factorial methodunu çağırma
            int fact_recursive = factorial_recursive(5);
            Console.WriteLine(fact_recursive);
           
            Console.ReadKey();


        }
    }
}
