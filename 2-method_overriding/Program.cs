using System;

namespace _2_method_overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Marcus", "123456");
            Admin admin = new Admin("Ruslan", "32f23g4g");
            Console.WriteLine("type User user.Access(): ");
            user.Access();
            Console.WriteLine("type Admin admin.Access(): ");
            admin.Access();

            User user1 = new User("German", "4t2vvbs");
            User admin1 = new Admin("Alex", "32f323g4g");
            Console.WriteLine("type User user1.Access(): ");
            user1.Access();
            Console.WriteLine("type User admin1.Access(): ");
            admin1.Access();
            Console.WriteLine("type User user1.ShowTypeAccount(): ");
            user1.ShowTypeAccount();
            Console.WriteLine("type User admin1.ShowTypeAccount(): ");
            admin1.ShowTypeAccount();
        }
    }
}
