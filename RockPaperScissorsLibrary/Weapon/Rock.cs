using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLibrary
{
    public class Rock : IWeapon
    {
        public string Name { get; set; }

        public bool IsWinner(IWeapon oponentWeapon)
        {
            return oponentWeapon.GetType() == typeof(Scissors);
        }

        public bool IsDraw(IWeapon opponentWeapon)
        {
            return opponentWeapon.GetType() == this.GetType();
        }
    }
}
