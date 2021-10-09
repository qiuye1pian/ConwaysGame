using ConwaysGame.Entity;
using System;

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

        /// <summary>
        /// 周围有多少个活细胞
        /// </summary>
        /// <returns></returns>
        internal int AroundAliveCount()
        {
            return 2;
        }
    }
}