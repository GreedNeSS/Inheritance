using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    class Gun : Weapon
    {
        public override int Damage => 80;

        public override void Fire()
        {
            Console.WriteLine("Бах");
        }

        public override void MeleeAttack()
        {
            Console.WriteLine("Melee attack"); ;
        }
    }
}
