using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_method_overriding
{
    class User
    {
        string login, password;
        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login
        {
            get => login;
            set { login = value; }
        }

        public string Password
        {
            get => password;
            set 
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
            }
        }

        public void Access()
        {
            string resultString = "Login: " + Login + "Password: " + Password;
            resultString += " Type account: User";
            Console.WriteLine(resultString);
        }

        public virtual void ShowTypeAccount()
        {
            Console.WriteLine("Type account: User");
        }
    }
}
