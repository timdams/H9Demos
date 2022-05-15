using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackOfTheClones.Characters
{
    class Stormtrooper: Character
    {
        public Stormtrooper(IWeaponBehaviour weapon): base(weapon)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Stormtrooper. The backbone of the empire.");
        }
    }
}
