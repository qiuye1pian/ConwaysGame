using ConwaysGame.Entity;

namespace ConwaysGame.Components
{
    public class CellGroup
    {
        public Cell TopLeft { get; set; }
        public Cell Top { get; set; }
        public Cell TopRight { get; set; }
        public Cell Left { get; set; }
        public Cell Center { get; set; }
        public Cell Right { get; set; }
        public Cell BottomLeft { get; set; }
        public Cell Bottom { get; set; }
        public Cell BottomRight { get; set; }

    }
}