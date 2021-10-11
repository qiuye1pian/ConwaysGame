using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConwaysGame.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConwaysGame.Entity;

namespace ConwaysGame.Components.Tests
{
    [TestClass()]
    public class RuleTests
    {

        [TestMethod()]
        public void 规则测试_活细胞周围1个活细胞_则死()
        {
            //Given
            CellGroup cellGroup = new CellGroup()
            {
                TopLeft = Cell.CreateDead(),
                Top = Cell.CreateDead(),
                TopRight = Cell.CreateDead(),
                Left = Cell.CreateDead(),
                Center = Cell.CreateAlive(),
                Right = Cell.CreateDead(),
                BottomLeft = Cell.CreateDead(),
                Bottom = Cell.CreateAlive(),
                BottomRight = Cell.CreateDead()
            };
            //When
            Cell newCell = Rule.Evolution(cellGroup);

            //Then
            Assert.AreEqual(CellStatus.Dead, newCell.Status);
        }

        [TestMethod()]
        public void 规则测试_活细胞周围2个活细胞_则活()
        {
            //Given
            CellGroup cellGroup = new CellGroup()
            {
                TopLeft = Cell.CreateDead(),
                Top = Cell.CreateAlive(),
                TopRight = Cell.CreateDead(),
                Left = Cell.CreateDead(),
                Center = Cell.CreateAlive(),
                Right = Cell.CreateDead(),
                BottomLeft = Cell.CreateDead(),
                Bottom = Cell.CreateAlive(),
                BottomRight = Cell.CreateDead()
            };
            //When
            Cell newCell = Rule.Evolution(cellGroup);
            //Then
            Assert.AreEqual(CellStatus.Alive, newCell.Status);
        }


        [TestMethod()]
        public void 规则测试_活细胞周围4个活细胞_则死()
        {
            //Given
            CellGroup cellGroup = new CellGroup()
            {
                TopLeft = Cell.CreateDead(),
                Top = Cell.CreateDead(),
                TopRight = Cell.CreateDead(),
                Left = Cell.CreateAlive(),
                Center = Cell.CreateAlive(),
                Right = Cell.CreateAlive(),
                BottomLeft = Cell.CreateAlive(),
                Bottom = Cell.CreateAlive(),
                BottomRight = Cell.CreateDead()
            };
            //When
            Cell newCell = Rule.Evolution(cellGroup);

            //Then
            Assert.AreEqual(CellStatus.Dead, newCell.Status);
        }

        [TestMethod()]
        public void 规则测试_死细胞周围1个活细胞_则死()
        {
            //Given
            CellGroup cellGroup = new CellGroup()
            {
                TopLeft = Cell.CreateDead(),
                Top = Cell.CreateDead(),
                TopRight = Cell.CreateDead(),
                Left = Cell.CreateAlive(),
                Center = Cell.CreateAlive(),
                Right = Cell.CreateAlive(),
                BottomLeft = Cell.CreateAlive(),
                Bottom = Cell.CreateAlive(),
                BottomRight = Cell.CreateDead()
            };
            //When
            Cell newCell = Rule.Evolution(cellGroup);

            //Then
            Assert.AreEqual(CellStatus.Dead, newCell.Status);
        }

        [TestMethod()]
        public void 规则测试_死细胞周围2个活细胞_则死()
        {
            //Given
            CellGroup cellGroup = new CellGroup()
            {
                TopLeft = Cell.CreateDead(),
                Top = Cell.CreateAlive(),
                TopRight = Cell.CreateDead(),
                Left = Cell.CreateDead(),
                Center = Cell.CreateDead(),
                Right = Cell.CreateDead(),
                BottomLeft = Cell.CreateDead(),
                Bottom = Cell.CreateAlive(),
                BottomRight = Cell.CreateDead()
            };
            //When
            Cell newCell = Rule.Evolution(cellGroup);
            //Then
            Assert.AreEqual(CellStatus.Dead, newCell.Status);
        }

        [TestMethod()]
        public void 规则测试_死细胞周围3个活细胞_则死()
        {
            //Given
            CellGroup cellGroup = new CellGroup()
            {
                TopLeft = Cell.CreateDead(),
                Top = Cell.CreateAlive(),
                TopRight = Cell.CreateDead(),
                Left = Cell.CreateDead(),
                Center = Cell.CreateDead(),
                Right = Cell.CreateDead(),
                BottomLeft = Cell.CreateAlive(),
                Bottom = Cell.CreateAlive(),
                BottomRight = Cell.CreateDead()
            };
            //When
            Cell newCell = Rule.Evolution(cellGroup);
            //Then
            Assert.AreEqual(CellStatus.Dead, newCell.Status);
        }
    }
}