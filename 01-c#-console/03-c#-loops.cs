using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _03_c__loops
    {
        static void Main(string[] args)
        {
            // For Döngüsü
            // 0 dan 10 a kadar 2şer sayan program
            int i;
            int toplam = 0;
            for (i = 0; i <= 10; i += 2)
            {
                // toplam = toplam + i
                toplam += i;
            }
            Console.WriteLine(toplam);
            Console.WriteLine("-------------------");

            // 9 a tam bölünen sayıları yazdıran program
            for (int j = 0; j < 100; j++)
            {
                if (j % 9 == 0)
                {
                    Console.WriteLine(j);
                }

            }

            Console.WriteLine("-------------------");
            // fibonacci ilk 10 değer
            int a = 1;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int k = 1; k <= 8; k++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.WriteLine("-------------------");
            // While Döngüsü
            int num3;
            Console.Write("Fakröriyeli alınacak sayıyı giriniz: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            while (num3 > 0)
            {
                factorial = factorial * num3;
                num3--;
            }
            Console.WriteLine(factorial);

            Console.ReadKey();
        }
    }
}
