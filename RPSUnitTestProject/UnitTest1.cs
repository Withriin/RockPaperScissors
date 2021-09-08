using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsLibrary;
using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;


namespace RPSUnitTestProject
{
    [TestClass]
    public class RockPaperScissorsOptionsUnitTest
    {
        private RockPaperScissorsOptions _rpsOptions;
        
        [TestInitialize]
        public void TestStart()
        {
            _rpsOptions = new RockPaperScissorsOptions();
        }

        [TestMethod]
        public void GetWeaponDictionaryTest()
        {
            Dictionary<string, IWeapon> testWeaponDictionary = _rpsOptions.GetWeaponDictionary();
            Assert.AreNotEqual(0, testWeaponDictionary.Count);
        }

        [TestMethod]
        public void GetCombatResultsTest()
        {
            
        }

        [TestMethod]
        public void GetWeaponOptionsTest()
        {            
            
        }
    }
}
