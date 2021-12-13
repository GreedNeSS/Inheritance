using System;

namespace _3_base
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Marcus", "Aurelius");
            Object person2 = new Person("Marcus", "Aurelius");
            Person person3 = person1;

            Console.WriteLine("person1.Equils(person2): " + person1.Equals(person2));
            Console.WriteLine("person1.Equils(person3): " + person1.Equals(person3));

            Console.WriteLine("person1.ComparePersons(person2)");
            Console.WriteLine(person1.ComparePersons((Person)person2));
            Console.WriteLine("person1.ComparePersons(person3)");
            Console.WriteLine(person1.ComparePersons(person3));
        }
    }
}
