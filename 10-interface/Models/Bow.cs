using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    class Bow : Weapon
    {
        public override int Damage => 40;

        public override void Fire()
        {
            Console.WriteLine("Стрела полетела");
        }

        public override void MeleeAttack()
        {
            Console.WriteLine("Bow can't melee attack");
        }
    }
}
