using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_abstract_class.Models
{
    class Player
    {
        public void Fire(Weapon weapon)
        {
            weapon.Fire();
        }

        public void CheckWeaponInfo(Weapon weapon)
        {
            weapon.ShowInfo();
        }
    }
}
