using ConwaysGame.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGame.Components
{
    public class Rule
    {
        public static Cell Evolution(CellGroup cellGroup)
        {
            Cell currentCell = cellGroup.Center;
            if(CellStatus.Alive == currentCell.Status && cellGroup.AroundAliveCount()==2)
            {
                return Cell.CreateAlive();
            }
            if (CellStatus.Dead == currentCell.Status && cellGroup.AroundAliveCount() == 2)
            {
                return Cell.CreateDead();
            }

            return null;
        }
    }
}
