using System;
using _9_abstract_class.Models;

namespace _9_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon[] weapons = { new Bow(), new Gun(), new LaserGun() };
            Player player = new();

            foreach (var item in weapons)
            {
                player.CheckWeaponInfo(item);
                player.Fire(item);
                Console.WriteLine();
            }
        }
    }
}
