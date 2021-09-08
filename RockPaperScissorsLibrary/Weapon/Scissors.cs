using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLibrary
{
    public class Scissors : IWeapon
    {

        public string Name { get; set; }

        public bool IsWinner(IWeapon oponentWeapon)
        {
            return oponentWeapon.GetType() == typeof(Paper);
        }

        public bool IsDraw(IWeapon opponentWeapon)
        {
            return opponentWeapon.GetType() == this.GetType();
        }
    }
}
