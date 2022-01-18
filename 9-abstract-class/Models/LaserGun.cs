using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_abstract_class.Models
{
    class LaserGun : Weapon
    {
        public override int Damage => 100;

        public override void Fire()
        {
            Console.WriteLine("Пиу пиу пиу");
        }
    }
}
