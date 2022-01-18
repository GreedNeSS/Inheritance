using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_interface.Models
{
    interface IWeapon
    {
        int Damage { get; }
        void Fire();
    }
}
