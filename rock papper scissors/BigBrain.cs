using rock_papper_scissors.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors
{
    public class BigBrain
    {
        public bool MainGameLoop()
        {
            while (true)
            {
                //Ask player to select an attack option based off of weapon options
                RPSOptions rpsOptions = new RPSOptions();
                Dictionary<string, IWeapon> weaponDictionary = rpsOptions.GetWeaponDictionary();
                Console.WriteLine($"Please select an option {Environment.NewLine}{rpsOptions.WeaponOptions()}");
                string userWeapon = rpsOptions.ReadUserWeaponSelector();              

                //comuters weapon choice generator
                Random  computerChoice = new Random();
                int debugComputerChoice = computerChoice.Next(1, weaponDictionary.Count + 1);
                IWeapon computerWeapon = weaponDictionary.GetValueOrDefault(debugComputerChoice.ToString(),null);
                IWeapon playerWeapon = weaponDictionary.GetValueOrDefault(userWeapon, null);
                                
                string combatResult = rpsOptions.GetCombatResult(playerWeapon, computerWeapon );
                                
                Console.WriteLine($"The player selected {playerWeapon.Name}");
                Console.WriteLine($"The computer selected {computerWeapon.Name}");
                Console.WriteLine($"Results: {combatResult}. {Environment.NewLine}");
                
            } 
         }
    }
}
