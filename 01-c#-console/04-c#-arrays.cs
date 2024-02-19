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

            Console.ReadLine();
        }
}
