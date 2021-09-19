using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLibrary.Weapon
{
    public interface IWeapon
    {
        string Name { get; set; }

        bool IsWinner(IWeapon opponentWeapon);

        bool IsDraw(IWeapon opponentWeapon);
    }
}
