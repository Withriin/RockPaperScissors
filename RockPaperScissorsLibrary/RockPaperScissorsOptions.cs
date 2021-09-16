using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsLibrary
{
    // attack options probably going to delete soon in favor of a better design *really dislike this as I'm moving forward: updated, work in progress
    public class RockPaperScissorsOptions
    {
        public Dictionary<string, IWeapon> GetWeaponDictionary()
        {
            return new Dictionary<string, IWeapon>()
                {
                    { "1", new Rock { Name = "Rock"} },
                    { "2", new Paper { Name = "Paper"} },
                    { "3", new Scissors { Name = "Scissors"} }
                };
        }

        public Dictionary<CombatConclusion, string> GetCombatConclusionMap()
        {
            return new Dictionary<CombatConclusion, string>()
            {
                {CombatConclusion.Draw, "Draw" },
                {CombatConclusion.Victory, "Victory" },
                {CombatConclusion.Defeat, "Defeat" }
            };
        }

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

        public string GetWeaponOptions()
        {
            StringBuilder weaponOptionString = new StringBuilder();
            foreach (KeyValuePair<string, IWeapon> entry in GetWeaponDictionary())
            {
                weaponOptionString.AppendLine($"{entry.Key}. {entry.Value.Name}");
            }

            return weaponOptionString.ToString();
            
        }
        // TO-DO Make Feature win count branch (git)
        // TO-DO Make input validation branch (git)

    }
}
