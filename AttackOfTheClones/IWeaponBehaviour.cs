using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackOfTheClones
{

    //Inspiratie: http://www.primaryobjects.com/2008/01/07/a-c-net-adventure-game-sim-and-the-strategy-pattern/ 
    public interface IWeaponBehaviour
    {
        void Display();
        void UseWeapon();
    }
}
