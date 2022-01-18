using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    class Knife : Weapon
    {
        public override int Damage => 60;

        public override void Fire()
        {
            Console.WriteLine("Knife Throw"); ;
        }

        public override void MeleeAttack()
        {
            Console.WriteLine("Melee hit"); ;
        }
    }
}

