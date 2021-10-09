using ConwaysGame.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConwaysGame.Components.Tests
{
    [TestClass()]
    public class WorldTests
    {
        [TestMethod()]
        public void 创建世界()
        {
            World newWorld = new World(10, 10);
            Assert.AreEqual(10, newWorld.Width);
            Assert.AreEqual(10, newWorld.Height);
        }


    }
}