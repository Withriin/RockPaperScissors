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
                //Draws++;
                return CombatConclusion.Draw;
            }
            else if (userWeapon.IsWinner(computerWeapon))
            {
                //Wins++;
                return CombatConclusion.Victory;
            }
            else
            {
                //Losses++;
                return CombatConclusion.Defeat;
            }
        }
    }
}
