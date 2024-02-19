using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _01_c__basics
    {
        static void Main(string[] args)
        {
            // Ekrana çıktı vermek için kullanılır
            Console.Write("Hello World");

            // Kullanıcıdan girdi almamız için kullanılır
            Console.WriteLine("Adınızı giriniz: ");
            string str = Console.ReadLine();

            // Ekrana çıktı verirken birden fazla değişken + kullanılarak birbirine concatlenebilir
            Console.WriteLine(str + " hoşgeldin..");

            // Ekrana birden fazla parametrenin çıktısını verirken {0} şeklinde kullanılabilir
            string str1 = Console.ReadLine();
            Console.WriteLine("Ad : {0} Soyad : {1}", str, str1);


            // Değişkenler 
            // string
            string str2 = "Mustafa"; //string değişkeni alfanumerik karakterler girmemizi sağlar
            int num = 1500; // int değişkeni tam sayı değerleri girmemizi sağlar

            Console.ReadKey();

            // Integer (int)
            int num1, num2, sum;
            num1 = Console.Read();
            num2 = Console.Read();
            sum = num1 + num2;
            Console.WriteLine(sum);

            // int sayıları dönüştürülebilir
            int num3 = Convert.ToInt32((Console.ReadKey()));


            // Double 
            double doub1 = 3.14;// double değişkeni tam sayıları tutar
            
            Console.Read();

        }
    }
}
