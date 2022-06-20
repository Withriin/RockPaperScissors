using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RockPaperScissorsLibrary.Weapon;
namespace RockPaperScissorsLibrary
{
    /// <summary>
    /// Generates IWeapons
    /// </summary>
    public class RockPaperScissorsFactory
    {           
        RockPaperScissorsAdapter rpsAdapter = new RockPaperScissorsAdapter();
        
        /// <summary>
        /// Generates a random computer IWeapon
        /// </summary>
        /// <returns>IWeapon[Computer]</returns>
        public IWeapon GetComputerWeapon()
        {
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();
           
            // computers weapon choice generator and debugger
            Random computerChoice = new Random();
            int debugComputerChoice = computerChoice.Next(1, weaponDictionary.Count + 1);
            weaponDictionary.TryGetValue(debugComputerChoice.ToString(), out IWeapon computerWeapon);
            return computerWeapon;
        }

        /// <summary>
        /// Validates user input for player weapon and converts it to an IWeapon.
        /// </summary>
        /// <param name="playerWeapon"></param>
        /// <returns>IWeapon</returns>
        public IWeapon GetPlayerWeapon(string playerWeapon)
        {   
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();
            weaponDictionary.TryGetValue(playerWeapon, out IWeapon playerWeaponDebug);
            return playerWeaponDebug;
        }
    }
}
