using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    abstract class Weapon : IWeapon, IHasInfo, IMeleeWeapon
    {
        public abstract int Damage { get; }

        public abstract void Fire();

        public abstract void MeleeAttack();

        public void ShowInfo()
        {
            Console.WriteLine($"Weapon: {GetType().Name}, Damage: {Damage}");
        }

    }
}
