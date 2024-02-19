using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _06_c__getter_setter
    {
        static void Main(String[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Ali";
            ogrenci.Soyad = "Veli";
            ogrenci.Yas = 20;
            Console.WriteLine(ogrenci.Ad);
            Console.WriteLine(ogrenci.Soyad);
            Console.WriteLine(ogrenci.Yas);

            Console.ReadKey();
        }

        // Private olarak öğrenci classı tanımlama getter ve setter metodları
        private class Ogrenci
        {
            private string ad;
            private string soyad;
            private int yas;


            public string Ad
            {
                get { return ad; }
                set { ad = value; }
            }

            public string Soyad
            {
                get { return soyad; }
                set { soyad = value; }
            }

            public int Yas
            {
                get { return yas; }
                set
                {
                    if (value < 18)
                    {
                        Console.WriteLine("Yaş değeri 18'den küçük olamaz");
                    }
                    else
                    {
                        yas = value;
                    }
                }
            }


        }
    }
}
