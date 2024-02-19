using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _08_c__inheritance
    {
        // Inheritance (Kalıtım) 
        // Base class (Ana sınıf) oluşturulur
        class Animal
        {
            public void animalSound()
            {
                Console.WriteLine("Hayvan ses yapar");
            }
        }
        // Derived class (Türetilmiş sınıf) oluşturulur
        class Dog : Animal
        {
            public void animalSound()
            {
                Console.WriteLine("Köpek ses yapar: hav hav");
            }
        }
        // Derived class (Türetilmiş sınıf) oluşturulur
        class Cat : Animal
        {
            public void animalSound()
            {
                Console.WriteLine("Kedi ses yapar: miyav miyav");
            }
        }
        
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog();
            myAnimal.animalSound();

            Dog myDog = new Dog();
            myDog.animalSound();

            Cat myCat = new Cat();
            myCat.animalSound();
        }

    }
}
