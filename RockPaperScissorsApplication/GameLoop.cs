using RockPaperScissorsLibrary;
using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApplication
{
    /// <summary>
    /// This is the main loop of the program.
    /// </summary>
    public class GameLoop
    {
        /// <summary>
        /// While true, the program is running.
        /// </summary>
        /// <returns>Boolean</returns>
        public bool MainGameLoop()
        {   
            // Constructing library class objects
            RockPaperScissorsAdapter rpsAdapter = new RockPaperScissorsAdapter();
            RockPaperScissorsStrategy rpsStrategy = new RockPaperScissorsStrategy();
            RockPaperScissorsFactory rpsFactory = new RockPaperScissorsFactory();

            // Human readability hash map creation
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();
            Dictionary<CombatConclusion, string> combatConclusionDictionary = rpsAdapter.GetCombatConclusionMap();
          
            // The main loop that runs everything
            while (true)
            {
                 
                // Ask player to select an attack option based off of weapon options                
                Console.WriteLine($"Please select an option {Environment.NewLine}{rpsAdapter.GetWeaponOptions()}");

                // Ask user for integer input, convert to IWeapon and store in a variable
                IWeapon playerWeapon = rpsFactory.GetPlayerWeapon(Console.ReadLine());

                // Creates computer weapon randomly and stores it in a variable
                IWeapon computerWeapon = rpsFactory.GetComputerWeapon();
                
                // Checks to see if the player draws, wins or loses and stores into a variable
                CombatConclusion combatResult = rpsStrategy.GetCombatResult(playerWeapon, computerWeapon);

                // Increments appropriate battle condition to persistantly show player draw, wins, loses
                rpsStrategy.CombatConclusionIncrement(combatResult);

                // Various outputs to user
                Console.WriteLine($"The player selected {playerWeapon.Name}");
                Console.WriteLine($"The computer selected {computerWeapon.Name}");
                Console.WriteLine($"Results: {combatConclusionDictionary[combatResult]}. {Environment.NewLine} {rpsAdapter.GetBattleStatisticsText(rpsStrategy.GetBattleStatisticsMap())} {Environment.NewLine}");

            }
        } // TODO Add way to end program.
    }
}
