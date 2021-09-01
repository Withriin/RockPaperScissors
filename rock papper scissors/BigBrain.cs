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
                RPSOptions rpsOptions = new RPSOptions();
                Console.WriteLine($"Please select an option {Environment.NewLine}{rpsOptions.WeaponOptions()}");
                string userWeaponChoice = Console.ReadLine();

                Dictionary<string, IWeapon> weaponDictionary = rpsOptions.GetWeaponDictionary();

                Random  computerChoice = new Random();
                int debugComputerChoice = computerChoice.Next(1, weaponDictionary.Count + 1);
                IWeapon playerWeapon = weaponDictionary.GetValueOrDefault(userWeaponChoice, null);
                IWeapon computerWeapon = weaponDictionary.GetValueOrDefault(debugComputerChoice.ToString(),null);
                Console.WriteLine($"The player selected {playerWeapon.Name}");
                Console.WriteLine($"The computer selected {computerWeapon.Name}");
                
            } 
         }
    }
}
