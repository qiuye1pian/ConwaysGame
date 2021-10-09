using ConwaysGame.Components;

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
    }
}
