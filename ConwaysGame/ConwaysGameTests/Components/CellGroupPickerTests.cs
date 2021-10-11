﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class CellGroupPickerTests
    {
        [TestMethod()]
        public void 二乘二的世界取第一个细胞的周围()
        {
            Cell[,] cellsFrame = CellsFrameCreator.Create(2, 2);

            CellGroup cellGroup = CellGroupPicker.PickCellGroup(cellsFrame, 0, 0);

            Assert.IsNull(cellGroup.TopLeft);
            Assert.IsNull(cellGroup.Top);
            Assert.IsNull(cellGroup.TopRight);
            Assert.IsNull(cellGroup.Left);
            Assert.IsNotNull(cellGroup.Center);
            Assert.IsNotNull(cellGroup.Right);
            Assert.IsNull(cellGroup.BottomLeft);
            Assert.IsNotNull(cellGroup.Bottom);
            Assert.IsNotNull(cellGroup.BottomRight);


        }
    }
}