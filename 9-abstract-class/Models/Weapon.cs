using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_abstract_class.Models
{
    abstract class Weapon
    {
        public abstract int Damage { get; }

        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine($"Weapon: {GetType().Name}, Damage: {Damage}");
        }

    }
}
