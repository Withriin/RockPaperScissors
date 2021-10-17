using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsLibrary.Weapon;
namespace RockPaperScissorsLibrary
{
    public class RockPaperScissorsFactory
    {           
            RockPaperScissorsAdapter rpsAdapter = new RockPaperScissorsAdapter();
           
        public IWeapon GetComputerWeapon()
        {
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();
            //comuters weapon choice generator
            Random computerChoice = new Random();
            int debugComputerChoice = computerChoice.Next(1, weaponDictionary.Count + 1);
            weaponDictionary.TryGetValue(debugComputerChoice.ToString(), out IWeapon computerWeapon);
            return computerWeapon;
        }

        public IWeapon GetPlayerWeapon(string playerWeapon)
        {
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();
            if (weaponDictionary.TryGetValue(playerWeapon, out IWeapon playerWeaponDebug))
            {
                return playerWeaponDebug;
            }
            else
            {
                Console.WriteLine("You have entered an invalid input, please try again.");
                playerWeapon = Console.ReadLine();
                return GetPlayerWeapon(playerWeapon);
            }
        }
    }
}
