using ConwaysGame.Entity;
using System;

namespace ConwaysGame.Components.Tests
{
    internal class World
    {
        private readonly int width;
        private readonly int height;
        private readonly Cell[,] cells;

        public World(int width, int height)
        {
            this.width = width;
            this.height = height;
            cells = new Cell[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cells[x, y] = Cell.RandomlyGenerate();
                }
            }
        }

        public int Width { get => width; }
        public int Height { get => height; }

        public Cell GetCell(int x, int y)
        {
            return cells[x, y];
        }
    }
}