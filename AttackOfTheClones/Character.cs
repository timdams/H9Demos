using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackOfTheClones
{
    public abstract class Character
    {
        private IWeaponBehaviour weapon;

        public IWeaponBehaviour Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Character(IWeaponBehaviour startWeapon)
        {
            Weapon = startWeapon;
        }

        abstract public void Display();

        public void Fight()
        {
            Weapon.UseWeapon();
        }

    }
}

