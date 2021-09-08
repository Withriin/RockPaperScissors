﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLibrary.Weapon
{
    public interface IWeapon
    {
        public string Name { get; set; }

        public bool IsWinner(IWeapon opponentWeapon);

        public bool IsDraw(IWeapon opponentWeapon);
    }
}
