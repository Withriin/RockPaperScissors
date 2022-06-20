using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsLibrary.Weapon;

namespace RockPaperScissorsLibrary
{
    /// <summary>
    /// Handles and defines the game rules and statistics
    /// </summary>
    public class RockPaperScissorsStrategy
    {
        // Internal hashmap for player statistics
        private Dictionary<CombatConclusion, int> _battleStatistics = new Dictionary<CombatConclusion, int>
        {
            {CombatConclusion.Draw , 0},
            {CombatConclusion.Victory , 0},
            {CombatConclusion.Defeat , 0 }
        };

        /// <summary>
        /// Read-only output for player statistics hashmap
        /// </summary>
        /// <returns>Dictionary</returns>
        public Dictionary<CombatConclusion, int> GetBattleStatisticsMap()
         {
             return _battleStatistics;
         }
       
       /// <summary>
       /// Takes User and computers weapon selections and checks what the outcome was for the User
       /// </summary>
       /// <param name="userWeapon">User IWeapon</param>
       /// <param name="computerWeapon">Computer generated IWeapon</param>
       /// <returns>CombatConclusion enumerable</returns>
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
        
        /// <summary>
        /// Adds one to the players combat conclusion that is inputed
        /// </summary>
        /// <param name="combatResult">The result of user and computer comparison</param>
        public void CombatConclusionIncrement(CombatConclusion combatResult)
        {
            _battleStatistics[combatResult]++;
        }
    }
}
