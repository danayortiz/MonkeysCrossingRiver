using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonkeysCrossingRiverProject.lib;

namespace MonkeysCrossingRiverTests
{
    [TestClass]
    public class RopeTest
    {
        [TestMethod]
        public void TestIsSpaceAvailable_Initially_ShouldBeTrue()
        {
            var rope = new Rope();

            Assert.IsTrue(rope.IsSpaceAvailable());
        }

        [TestMethod]
        public void TestIsSpaceAvailable_AfterAddingMonkey_ShouldBeFalse()
        {
            var rope = new Rope();
            rope.AddMonkey();

            Assert.IsFalse(rope.IsSpaceAvailable());
        }

        [TestMethod]
        public void TestIsFree_Initially_ShouldBeTrue()
        {
            var rope = new Rope();

            Assert.IsTrue(rope.IsEmpty());
        }

        [TestMethod]
        public void TestIsFree_AfterAddingMonkey_ShouldBeFalse()
        {
            var rope = new Rope();
            rope.AddMonkey();

            Assert.IsFalse(rope.IsEmpty());
        }

        [TestMethod]
        public void TestAddMonkey_WhenNoSpaceAvailable_ShouldBeFalse()
        {
            var rope = new Rope();
            rope.AddMonkey();

            Assert.IsFalse(rope.AddMonkey());
        }

        [TestMethod]
        public void TestMoveMonkeys_AfterAddingMonkeys_ShouldWork()
        {
            var currentMonkeyCount = 0;
            var rope = new Rope();
            rope.AddMonkey();
            currentMonkeyCount = rope.MoveMonkeys();
            Assert.AreEqual(1, currentMonkeyCount, "Should be 1 monkey in the rope");

            rope.AddMonkey();
            currentMonkeyCount = rope.MoveMonkeys();
            Assert.AreEqual(2, currentMonkeyCount, "Should be 2 monkey in the rope");

            rope.AddMonkey();
            Assert.AreEqual(3, rope.Count, "Should be 3 monkey in the rope");
            currentMonkeyCount = rope.MoveMonkeys();
            Assert.AreEqual(2, currentMonkeyCount, "Should be 2 monkey in the rope");
        }
    }
}
