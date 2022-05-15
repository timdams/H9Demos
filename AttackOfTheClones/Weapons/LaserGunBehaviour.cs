using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackOfTheClones.Weapons
{
    class LaserGunBehaviour : IWeaponBehaviour
    {
        public int Battery { get; private set; }
        public LaserGunBehaviour()
        {
            Battery = 10;
        }
        public void Display()
        {
            Console.WriteLine($"A standard lasergun. Battery left: {Battery}");
        }

        public void UseWeapon()
        {
            if (Battery > 0)
            {
                Battery--;

                Console.WriteLine("Pew pew pew");
            }
            else
                Console.WriteLine("Click...Dang. It's empty.");
        }
    }
}
