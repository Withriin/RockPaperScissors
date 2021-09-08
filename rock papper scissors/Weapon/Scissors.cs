using rock_papper_scissors.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors
{
    public class Scissors : IWeapon
    {

        public string Name { get; set; }

        public bool isWinner(IWeapon oponentWeapon)
        {
            return oponentWeapon.GetType() == typeof(Paper);
        }

        public bool isDraw(IWeapon opponentWeapon)
        {
            return opponentWeapon.GetType() == this.GetType();
        }
    }
}
