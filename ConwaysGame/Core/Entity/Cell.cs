using ConwaysGame.Components;
using System;

namespace ConwaysGame.Entity
{
    public class Cell
    {
        private Cell(CellStatus initStatus)
        {
            this.Status = initStatus;
        }

        public CellStatus Status { get; set; }

        public static Cell CreateAlive()
        {
            return new Cell(CellStatus.Alive);
        }

        public static Cell CreateDead()
        {
            return new Cell(CellStatus.Dead);
        }

        public static Cell RandomlyGenerate()
        {
            return new Random().Next(0, 9) % 2 == 0 ? CreateAlive() : CreateDead();
        }
    }
}
