using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsLibrary.Weapon;

namespace RockPaperScissorsLibrary
{
    public class RockPaperScissorsStrategy
    {
        public CombatConclusion GetCombatResult(IWeapon userWeapon, IWeapon computerWeapon)
        {
            if (userWeapon.IsDraw(computerWeapon))
            {
                return CombatConclusion.Draw;
            }
            else if (userWeapon.IsWinner(computerWeapon))
            {
                return CombatConclusion.Victory;
            }
            else
            {
                return CombatConclusion.Defeat;
            }
        }
    }
}
