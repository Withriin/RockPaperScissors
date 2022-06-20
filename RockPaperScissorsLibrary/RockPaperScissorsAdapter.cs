using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;


namespace RockPaperScissorsLibrary
{
    /// <summary>
    /// Transforms data and generates console output.
    /// </summary>
    public class RockPaperScissorsAdapter
    {
        /// <summary>
        /// Returns a dictionary with an integer key that the user inputs to select a weapon.
        /// </summary>
        public Dictionary<string, IWeapon> GetWeaponDictionary()
        {
            return new Dictionary<string, IWeapon>()
                {
                    { "1", new Rock { Name = "Rock"} },
                    { "2", new Paper { Name = "Paper"} },
                    { "3", new Scissors { Name = "Scissors"} }
                };
        }

        /// <summary>
        /// Returns a dictionary that transforms combatconclusion enumeration to a human readible string.
        /// </summary>
        public Dictionary<CombatConclusion, string> GetCombatConclusionMap()
        {
            return new Dictionary<CombatConclusion, string>()
            {
                {CombatConclusion.Draw, "Draw" },
                {CombatConclusion.Victory, "Victory" },
                {CombatConclusion.Defeat, "Defeat" }
            };
        }

         /// <summary>
         /// Generates weapon names in a human readible string.
         /// </summary>
        public string GetWeaponOptions()
        {
            StringBuilder weaponOptionString = new StringBuilder();
            foreach (KeyValuePair<string, IWeapon> entry in GetWeaponDictionary())
            {
                weaponOptionString.AppendLine($"{entry.Key}. {entry.Value.Name}");
            }

            return weaponOptionString.ToString();
        }

        /// <summary>
        /// A dictionary that keeps track of combat conclusions.
        /// </summary>
        Dictionary<CombatConclusion , int> _battleStatistics = new Dictionary<CombatConclusion , int>
        {
            {CombatConclusion.Draw , 0},
            {CombatConclusion.Victory , 0},
            {CombatConclusion.Defeat , 0 }
        };

        /// <summary>
        /// Retunrns battle statistics to a string to output to user. To be changed, currently adds most recent combat conclusion to battle statistics.
        /// </summary>
        /// <param name="combatConclusion">To be depricated, currently incriments battle statitstics most recent combat conclusion.</param>
        public string GetBattleStatisticsText(CombatConclusion combatConclusion)
        {
            _battleStatistics[combatConclusion] = _battleStatistics[combatConclusion] + 1;
            return $"{_battleStatistics[CombatConclusion.Draw]} Draws, {_battleStatistics[CombatConclusion.Victory]} Wins, {_battleStatistics[CombatConclusion.Defeat]} Losses.";
        }

        // TODO Make input validation branch (git)
        // TODO Move the _battleStatistics increment to strategy
    }
}