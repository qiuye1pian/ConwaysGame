using ConwaysGame.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConwaysGame.Components.Tests
{
    [TestClass()]
    public class CellTests
    {
        [TestMethod()]
        public void 创建活细胞()
        {
            Cell aliveCell = Cell.CreateAlive();
            Assert.AreEqual(CellStatus.Alive, aliveCell.Status);
        }

        [TestMethod()]
        public void 创建死细胞()
        {
            Cell aliveCell = Cell.CreateDead();
            Assert.AreEqual(CellStatus.Dead, aliveCell.Status);
        }
    }
}