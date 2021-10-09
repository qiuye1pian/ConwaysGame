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
            return Cell.CreateDead();
        }
    }
}
