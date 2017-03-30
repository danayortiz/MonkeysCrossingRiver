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

            Assert.IsTrue(rope.IsFree());
        }

        [TestMethod]
        public void TestIsFree_AfterAddingMonkey_ShouldBeFalse()
        {
            var rope = new Rope();
            rope.AddMonkey();

            Assert.IsFalse(rope.IsFree());
        }

        [TestMethod]
        public void TestAddMonkey_WhenNoSpaceAvailable_ShouldBeFalse()
        {
            var rope = new Rope();
            rope.AddMonkey();

            Assert.IsFalse(rope.AddMonkey());
        }
    }
}
