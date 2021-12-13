using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Marcus", "Aurelius");
            Console.WriteLine(person.ToString());
        }
    }
}

