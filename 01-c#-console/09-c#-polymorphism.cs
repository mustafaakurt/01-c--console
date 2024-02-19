using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _09_c__polymorphism
    {
        // Polymorphism örneği
        class Animal
        {
            public virtual void Sound()
            {
                Console.WriteLine("Hayvan sesi");
            }
        }

        class Dog : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Hav hav");
            }
        }

        class Cat : Animal
        {
            public override void Sound()
            {
                Console.WriteLine("Miyav");
            }
        }
        
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Sound();

            animal = new Dog();
            animal.Sound();

            animal = new Cat();
            animal.Sound();

            Console.ReadKey();
        }
    }
}
