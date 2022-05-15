using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackOfTheClones.Weapons
{
    class LightSaberBehaviour: IWeaponBehaviour
    {

        public void Display()
        {
            Console.WriteLine("A lightsaber. A weapon from a more civilzed period.");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Zoooom.");
        }
    }
}
