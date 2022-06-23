using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsLibrary;
using RockPaperScissorsLibrary.Weapon;
using System;
using System.Collections.Generic;
using System.Text;


namespace RPSUnitTestProject
{
    [TestClass]
    public class RockPaperScissorsUnitTests
    {
        private RockPaperScissorsAdapter _rpsAdapter;
        private RockPaperScissorsFactory _rpsFactory;
        private RockPaperScissorsStrategy _rpsStrategy;
        
        [TestInitialize]
        public void TestStart()
        {
            _rpsAdapter = new RockPaperScissorsAdapter();
            _rpsFactory = new RockPaperScissorsFactory();
            _rpsStrategy = new RockPaperScissorsStrategy();
        }

        [TestMethod]
        public void GetWeaponDictionaryTest()
        {
            Dictionary<string, IWeapon> testWeaponDictionary = _rpsAdapter.GetWeaponDictionary();
            Assert.AreNotEqual(0, testWeaponDictionary.Count);
        }

        [TestMethod]
        public void GetCombatResultsTest()
        {
            Assert.AreEqual(CombatConclusion.Draw, _rpsStrategy.GetCombatResult(new Rock(), new Rock()));
            Assert.AreEqual(CombatConclusion.Victory, _rpsStrategy.GetCombatResult(new Rock(), new Scissors()));
            Assert.AreEqual(CombatConclusion.Defeat, _rpsStrategy.GetCombatResult(new Rock(), new Paper()));
        }

        [TestMethod]
        public void GetWeaponOptionsTest()
        {
            Assert.AreNotEqual(String.Empty, _rpsAdapter.GetWeaponOptions());
        }

        [TestMethod]
        public void GetBattleStatisticsMapTest()
        {
            Dictionary<CombatConclusion, int> testBattleStatisticsMap = _rpsStrategy.GetBattleStatisticsMap();
            Assert.AreNotEqual(0, testBattleStatisticsMap.Count);
        }

        [TestMethod]
        public void CombatConclusionIncrementTest()
        {
          
        }

        [TestMethod]
        public void isValidPlayerWeapon()
        {
            
        }
    }
}
