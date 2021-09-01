﻿using rock_papper_scissors.Weapon;
using System;
using System.Collections.Generic;
using System.Text;

namespace rock_papper_scissors
{
    // attack options probably going to delete soon in favor of a better design *really dislike this as I'm moving forward
    public class RPSOptions
    {
        public string WeaponOptions()
        {
            StringBuilder weaponOptionString = new StringBuilder();
            foreach (KeyValuePair<string, IWeapon> entry in GetWeaponDictionary())
            {
                weaponOptionString.AppendLine($"{entry.Key}. {entry.Value.Name}");
            }

            return weaponOptionString.ToString();
            
        }

        public Dictionary<string, IWeapon> GetWeaponDictionary()
        {
            return   new Dictionary<string, IWeapon>()
                {
                    { "1", new Rock { Name = "Rock"} },
                    { "2", new Paper { Name = "Paper" } },
                    { "3", new Scissors { Name = "Scissors" } }
                };
        }
    }    
}