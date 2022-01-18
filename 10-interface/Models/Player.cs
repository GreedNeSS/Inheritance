using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    class Player
    {
        public void Fire(IWeapon weapon)
        {
            weapon.Fire();
        }

        public void CheckInfo(IHasInfo item)
        {
            item.ShowInfo();
        }

        public void MeleeAttack(IMeleeWeapon weapon)
        {
            weapon.MeleeAttack();
        }
    }
}
