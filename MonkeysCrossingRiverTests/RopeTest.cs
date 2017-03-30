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
    }
}
