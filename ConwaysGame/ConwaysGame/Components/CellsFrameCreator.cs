using ConwaysGame.Entity;

namespace ConwaysGame.Components
{
    public class CellsFrameCreator
    {
        public static Cell[,] Create(int width, int height)
        {
            Cell[,] cells = new Cell[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    cells[x, y] = Cell.RandomlyGenerate();
                }
            }
            return cells;
        }
    }
}
