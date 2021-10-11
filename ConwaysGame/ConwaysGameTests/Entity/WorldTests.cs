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

        [TestMethod()]
        public void 世界充满细胞()
        {
            World newWorld = new World(10, 10);
            Assert.IsNotNull(newWorld.GetCell(0, 0));
            Assert.IsInstanceOfType(newWorld.GetCell(0, 0), typeof(Cell));
            Assert.IsInstanceOfType(newWorld.GetCell(9, 9), typeof(Cell));
        }

    }
}