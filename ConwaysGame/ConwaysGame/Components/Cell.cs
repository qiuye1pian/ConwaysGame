namespace ConwaysGame.Components
{
    public class Cell
    {
        public Cell()
        {

        }

        public CellStatus Status { get; set; }

        public static Cell CreateAlive()
        {
            return new Cell() { Status = CellStatus.Alive };
        }

        public static Cell CreateDead()
        {
            return new Cell() { Status = CellStatus.Dead };
        }
    }
}
