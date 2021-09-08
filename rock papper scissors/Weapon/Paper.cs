using rock_papper_scissors.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors
{
    public class Paper : IWeapon
    {

        public string Name { get; set; }
       
        public bool isWinner(IWeapon oponentWeapon)
        {
            return oponentWeapon.GetType() == typeof(Rock);
        }
        public bool isDraw(IWeapon opponentWeapon)
        {
            return opponentWeapon.GetType() == this.GetType();
        }
    }
}
