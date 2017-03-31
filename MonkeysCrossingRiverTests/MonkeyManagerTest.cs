using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeysCrossingRiverProject.lib;

namespace MonkeysCrossingRiverTests
{
    [TestClass]
    public class MonkeyManagerTest
    {
        [TestMethod]
        public void TestRun_PassingNoMonkeys_ShouldReturnCeroIterations()
        {
            var monkeyManager = new MonkeyManager(0, 0);
            Assert.AreEqual(0, monkeyManager.Run());
        }

        [TestMethod]
        public void TestRun_PassingOneMonkeyLeftSide_ShouldReturnFourIterations()
        {
            var monkeyManager = new MonkeyManager(1, 0);
            Assert.AreEqual(4, monkeyManager.Run());
        }

        [TestMethod]
        public void TestRun_PassingOneMonkeyRightSide_ShouldReturnFourIterations()
        {
            var monkeyManager = new MonkeyManager(0, 1);
            Assert.AreEqual(4, monkeyManager.Run());
        }

        [TestMethod]
        public void TestRun_PassingOneMonkeyEachSide_ShouldReturnEightIterations()
        {
            var monkeyManager = new MonkeyManager(1, 1);
            Assert.AreEqual(8, monkeyManager.Run());
        }

        [TestMethod]
        public void TestRun_PassingMultipleMonkeys_ShouldReturnTwentyEightIterations()
        {
            var monkeyManager = new MonkeyManager(4, 9);
            Assert.AreEqual(28, monkeyManager.Run());
        }
    }
}
