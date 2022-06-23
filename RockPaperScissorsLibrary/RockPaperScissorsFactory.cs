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
        /// Validates user input for player weapon.
        /// </summary>
        /// <param name="playerWeapon">User integer input for weapons keycode</param>
        /// <returns>IWeapon</returns>
        public bool isValidPlayerWeapon(string playerWeapon)
        {
            Dictionary<string, IWeapon> weaponDictionary = rpsAdapter.GetWeaponDictionary();
            return (weaponDictionary.TryGetValue(playerWeapon, out IWeapon playerWeaponDebug));
        }
    }
}
