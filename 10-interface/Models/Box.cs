using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    class Box : IHasInfo
    {
        public void ShowInfo()
        {
            Console.WriteLine("Обычная с виду коробка!");
        }
    }
}
