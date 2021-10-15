using ConwaysGame.Entity;
using System.Linq;
using System.Reflection;

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
            return (from property in GetType().GetRuntimeProperties()
                    where property.PropertyType == typeof(Cell)
                    && (property.Name != "Center") 
                    && (property.GetValue(this) as Cell) != null
                    && (property.GetValue(this) as Cell).Status == CellStatus.Alive
                    select property).Count();
        }
    }
}