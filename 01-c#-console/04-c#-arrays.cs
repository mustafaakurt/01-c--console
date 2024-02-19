using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _04_c__arrays
    {
        static void Main(string[] args)
        {
            // Array dizi tanımlama
            int[] numbers = new int[5];
            string[] citys = new string[3];

            // Array initialization (kullanılacak indekse değer atama)
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Arrayin indekslerine ulasma
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            // Array tanımlama ve ilklendirme
            int[] numbers2 = new int[] { 10, 20, 30, 40, 50 };


            // Arrayin elemanlarına for döngüsü ile erişme
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Array declaration and initialization
            int[] numbers6 = new int[5] { 10, 20, 30, 40, 50 };

            // Arrayin elemanlarına foreach döngüsü ile erişme
            foreach (int number in numbers6)
            {
                Console.WriteLine(number);
            }

            // Arrayin elemanları arasındaki en büyük sayıyı bulma
            int[] numbers7 = new int[5] { 10, 20, 30, 40, 50 };
            int biggest = numbers7[0];
            for (int i = 0; i < numbers7.Length; i++)
            {
                if (numbers7[i] > biggest)
                {
                    biggest = numbers7[i];
                }
            }
            Console.WriteLine("En büyük sayı: " + biggest);

            // Arrayin elemanları arasındaki 2'ye tam bölünen sayıları bulma foreach ile
            int[] numbers8 = new int[5] { 10, 20, 30, 40, 50 };
            foreach (int number in numbers8)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            // Arrayde karışık sıralı değerleri önce sırala sonra en küçük ve en büyük sayıları bulma
            int[] numbers9 = new int[5] { 10, 20, 30, 40, 50 };
            Array.Sort(numbers9);
            Console.WriteLine("En küçük sayı: " + numbers9[0]);
            Console.WriteLine("En büyük sayı: " + numbers9[numbers9.Length - 1]);

            // Çok boyutlu 2*2 array tanımlama ve ilklendirme
            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;

            // Çok boyutlu diziyi yazdırma
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Çok boyutlu 2*2 array tanımlama, ilklendirme ve bu iki çok boyutlu arrayi toplama
            int[,] matrix1 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] matrix2 = new int[2, 2] { { 5, 6 }, { 7, 8 } };
            int[,] result = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.WriteLine(result[i, j] + " ");
                }
                Console.WriteLine();
            }






            Console.ReadLine();
        }
    }
}