using rock_papper_scissors.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors
{
    public class Paper : IWeapon
    {

        public string Name { get; set; }
        public int WeaponNumber {get; set; }
    }
}
