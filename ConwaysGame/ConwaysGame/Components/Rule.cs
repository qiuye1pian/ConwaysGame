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

            switch (currentCell.Status)
            {
                case CellStatus.Alive:
                    return DealAliveCell(cellGroup);
                case CellStatus.Dead:
                    return DealDeadCell(cellGroup);
            }
            return null;
        }

        private static Cell DealDeadCell(CellGroup cellGroup)
        {
            if (cellGroup.AroundAliveCount() == 2)
            {
                return Cell.CreateDead();
            }

            if (cellGroup.AroundAliveCount() == 3)
            {
                return Cell.CreateDead();
            }
            return null;
        }

        private static Cell DealAliveCell(CellGroup cellGroup)
        {
            if (cellGroup.AroundAliveCount() == 4)
            {
                return Cell.CreateDead();
            }

            if (cellGroup.AroundAliveCount() == 2)
            {
                return Cell.CreateAlive();
            }

            if (cellGroup.AroundAliveCount() == 1)
            {
                return Cell.CreateDead();
            }
            return null;
        }
    }
}
