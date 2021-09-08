using RockPaperScissorsLibrary;
using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsApplication
{
    public class BigBrain
    {
        public bool MainGameLoop()
        {
            while (true)
            {
                //Ask player to select an attack option based off of weapon options
                RockPaperScissorsOptions rpsOptions = new RockPaperScissorsOptions();
                Dictionary<string, IWeapon> weaponDictionary = rpsOptions.GetWeaponDictionary();
                Console.WriteLine($"Please select an option {Environment.NewLine}{rpsOptions.GetWeaponOptions()}");
                string userWeapon = Console.ReadLine();

                //comuters weapon choice generator
                Random computerChoice = new Random();
                int debugComputerChoice = computerChoice.Next(1, weaponDictionary.Count + 1);
                weaponDictionary.TryGetValue(debugComputerChoice.ToString(), out IWeapon computerWeapon);
                weaponDictionary.TryGetValue(userWeapon, out IWeapon playerWeapon);

                string combatResult = rpsOptions.GetCombatResult(playerWeapon, computerWeapon);

                Console.WriteLine($"The player selected {playerWeapon.Name}");
                Console.WriteLine($"The computer selected {computerWeapon.Name}");
                Console.WriteLine($"Results: {combatResult}. {Environment.NewLine}");

            }
        }
    }
}
