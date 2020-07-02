using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipCS
{
    interface IBoard
    {
        void Setup(char[ , ] board);
        void DrawBoard(int whichBoard);
    }
}
