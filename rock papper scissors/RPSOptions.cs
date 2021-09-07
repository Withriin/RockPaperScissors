using rock_papper_scissors.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors
{
    // attack options probably going to delete soon in favor of a better design *really dislike this as I'm moving forward: updated, work in progress
    public class RPSOptions
    {
        public Dictionary<string, IWeapon> GetWeaponDictionary()
        {
            return   new Dictionary<string, IWeapon>()
                {
                    { "1", new Rock { Name = "Rock" , WeaponNumber = 1} },
                    { "2", new Paper { Name = "Paper" , WeaponNumber = 2} },
                    { "3", new Scissors { Name = "Scissors" , WeaponNumber = 3} }
                };
        }

        public string Combat(int userWeapon, int computerWeapon)
        {
            if (userWeapon == computerWeapon)
            {
                return "draw";
            }
            else if (userWeapon == 1)
            {
                if (computerWeapon == 3)
                {
                    return "Victory";
                }
                else
                {
                    return "Defeat";
                }
            }
            else if (userWeapon == 2)
            {
                if (computerWeapon == 1)
                {
                    return "Victory";
                }
                else
                {
                    return "Defeat";
                }
            }
            else
            {
                if (computerWeapon == 2)
                {
                    return "Victory";
                }
                else
                {
                    return "Deafeat";
                }
            }
        }
         
        public string UserWeaponSelector()
        {
            string userWeaponChoice = Console.ReadLine();
            return userWeaponChoice;
        }

        public string WeaponOptions()
        {
            StringBuilder weaponOptionString = new StringBuilder();
            foreach (KeyValuePair<string, IWeapon> entry in GetWeaponDictionary())
            {
                weaponOptionString.AppendLine($"{entry.Key}. {entry.Value.Name}");
            }

            return weaponOptionString.ToString();
            
        }

       
    }    
}
