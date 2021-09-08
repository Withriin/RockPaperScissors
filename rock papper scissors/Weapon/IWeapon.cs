using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors.Weapon
{
    public interface IWeapon
    {
        public string Name { get; set; }

        public bool isWinner(IWeapon opponentWeapon);

        public bool isDraw(IWeapon opponentWeapon);
    }
}
