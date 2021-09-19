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
        private RockPaperScissorsAdapter _rpsOptions;
        
        [TestInitialize]
        public void TestStart()
        {
            _rpsOptions = new RockPaperScissorsAdapter();
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
            Assert.AreEqual(CombatConclusion.Draw, _rpsOptions.GetCombatResult(new Rock(), new Rock()));
            Assert.AreEqual(CombatConclusion.Victory, _rpsOptions.GetCombatResult(new Rock(), new Scissors()));
            Assert.AreEqual(CombatConclusion.Defeat, _rpsOptions.GetCombatResult(new Rock(), new Paper()));
        }

        [TestMethod]
        public void GetWeaponOptionsTest()
        {
            Assert.AreNotEqual(String.Empty, _rpsOptions.GetWeaponOptions());
        }
    }
}
