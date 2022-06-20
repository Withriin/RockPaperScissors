using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;
using RockPaperScissorsLibrary;


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
        /// Returns battle statistics to a string to output to user.
        /// </summary>
        public string GetBattleStatisticsText(Dictionary<CombatConclusion, int> _battleStatistics)
        {
            return $"{_battleStatistics[CombatConclusion.Draw]} Draws, {_battleStatistics[CombatConclusion.Victory]} Wins, {_battleStatistics[CombatConclusion.Defeat]} Losses.";
        }

        // TODO Make input validation branch (git)
    }
}