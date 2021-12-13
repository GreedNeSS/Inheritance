using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_base
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        
        public new bool Equals(Object obj)
        {
            Person person = (Person) obj;
            Console.WriteLine("Работает переопределённый метод Equals");
            return (Firstname == person.Firstname) &&
                (Lastname == person.Lastname);
        }
        public string ComparePersons(Person person)
        {
            bool equilParams = Equals(person);
            bool fullEquil = base.Equals(person);
            if (fullEquil)
            {
                return "Абсолютно одинаковые обьекты";
            }
            if (equilParams)
            {
                return "Одинаковые свойства обьектов";
            }
            return "Обьекты разные";
        }
    }
}
