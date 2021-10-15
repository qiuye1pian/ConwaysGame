using ConwaysGame.Entity;
using System;

namespace ConwaysGame.Components
{
    public class CellGroupPicker
    {
        public static CellGroup PickCellGroup(Cell[,] cells, int x, int y)
        {
            if (cells == null) return null;
            return new CellGroup()
            {
                TopLeft = Pickup(cells, x - 1, y - 1),
                Top = Pickup(cells, x, y - 1),
                TopRight = Pickup(cells, x + 1, y - 1),
                Left = Pickup(cells, x - 1, y),
                Center = Pickup(cells, x, y),
                Right = Pickup(cells, x + 1, y),
                BottomLeft = Pickup(cells, x - 1, y + 1),
                Bottom = Pickup(cells, x, y + 1),
                BottomRight = Pickup(cells, x + 1, y + 1)
            };
        }

        private static Cell Pickup(Cell[,] cells, int x, int y)
        {
            if (x < 0 || x > cells.GetLength(0) - 1)
            {
                return null;
            }
            if (y < 0 || y > cells.GetLength(1) - 1)
            {
                return null;
            }
            return cells[x, y];
        }
    }
}
