using RockPaperScissorsLibrary;
using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApplication
{
    public class GameLoop
    {
        public bool MainGameLoop()
        {
            RockPaperScissorsAdapter rpsAdapter = new RockPaperScissorsAdapter();
            RockPaperScissorsStrategy rpsStrategy = new RockPaperScissorsStrategy();
            RockPaperScissorsFactory rpsFactory = new RockPaperScissorsFactory();
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();

            while (true)
            {
                //Ask player to select an attack option based off of weapon options                
                Console.WriteLine($"Please select an option {Environment.NewLine}{rpsAdapter.GetWeaponOptions()}");
                Dictionary<CombatConclusion, string> combatConclusionDictionary = rpsAdapter.GetCombatConclusionMap();
                IWeapon playerWeapon = rpsFactory.PlayerWeapon(Console.ReadLine());
                IWeapon computerWeapon = rpsFactory.ComputerWeapon();
                CombatConclusion combatResult = rpsStrategy.GetCombatResult(playerWeapon, computerWeapon);

                Console.WriteLine($"The player selected {playerWeapon.Name}");
                Console.WriteLine($"The computer selected {computerWeapon.Name}");
                Console.WriteLine($"Results: {combatConclusionDictionary[combatResult]}. {Environment.NewLine} {rpsAdapter.GetBattleStatisticsText(combatResult)} {Environment.NewLine}");

            }
        }
    }
}
