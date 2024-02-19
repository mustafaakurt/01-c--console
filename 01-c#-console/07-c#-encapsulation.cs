using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_c__console
{
    internal class _07_c__encapsulation
    {
        static void Main(String[] args)
        {
            Person person = new Person();
            person.Name = "Mustafa";
            person.Age = 25;
            Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            Console.ReadKey();

        }
        // Encapsulation örneği 
        public class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }
        }
    }
}
