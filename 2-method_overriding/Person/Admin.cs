using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_method_overriding
{
    class Admin : User
    {
        bool isAdmin;
        public Admin(string login, string password)
            : base(login, password)
            {
            isAdmin = true;
            }

        public new void Access()
        {
            string resultString = "Login: " + Login + "Password: " + Password;
            if (isAdmin)
            {
                resultString += " Type account: Admin";
            }
            Console.WriteLine(resultString);
        }

        public override void ShowTypeAccount()
        {
            Console.WriteLine("Type account: Admin");
        }
    }
}
