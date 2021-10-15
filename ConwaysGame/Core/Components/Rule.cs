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
        private Rule()
        {

        }

        public static Cell Generate(CellGroup cellGroup)
        {
            switch (cellGroup.Center.Status)
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
            if (cellGroup.AroundAliveCount() == 3)
            {
                return Cell.CreateAlive();
            }

            return Cell.CreateDead();
        }

        private static Cell DealAliveCell(CellGroup cellGroup)
        {
            if (cellGroup.AroundAliveCount() >= 4)
            {
                return Cell.CreateDead();
            }

            if (cellGroup.AroundAliveCount() <= 1)
            {
                return Cell.CreateDead();
            }
 
            return Cell.CreateAlive();
        }
    }
}
