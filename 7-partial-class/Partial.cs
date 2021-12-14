using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_partial_class
{
    public partial class Partial
    {
        string user = "Ruslan";
        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public void Method1()
        {
            Console.WriteLine("Method1 User: " + User);
        }

    }
}
