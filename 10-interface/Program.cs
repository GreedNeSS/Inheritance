using System;
using _10_interface.Models;

namespace _10_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon[] weapons = { new Knife(), new Gun(), new LaserGun(), new Bow() };
            Player player = new();

            foreach (var item in weapons)
            {
                player.CheckInfo(item);
                player.Fire(item);
                player.MeleeAttack(item);
                Console.WriteLine();
            }

            player.CheckInfo(new Box());
        }
    }
}
