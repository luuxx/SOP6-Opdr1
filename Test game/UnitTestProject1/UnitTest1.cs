using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_game;

namespace UnitTestProject1
{
    [TestClass]
    public class TestGameTest1
    {
        private LetsPlayAGame game;

        [TestInitialize()]
        public void Initialize()
        {
            game = new LetsPlayAGame();
        }

        [TestMethod]
        public void TestIfTrue()
        {
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestIfOne()
        {
            Assert.AreEqual(1, game.RollD6());
        }
    }
}
