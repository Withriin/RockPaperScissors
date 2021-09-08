using RPSLibary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLibary
{
    public class Rock : IWeapon
    {
        public string Name { get; set; }

        public bool isWinner(IWeapon oponentWeapon)
        {
            return oponentWeapon.GetType() == typeof(Scissors);
        }

        public bool isDraw(IWeapon opponentWeapon)
        {
            return opponentWeapon.GetType() == this.GetType();
        }
    }
}
