using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipCS
{
    public class Player : IBoard
    {
        private char[,] _playerBoard = new char[10, 10];

        public char[,] PlayerBoard
        {
            get
            {
                return _playerBoard;
            }
            set
            {
                _playerBoard = value;
            }
        }

        public void Setup(char[,] PlayerBoard)
        {
            bool orientation, placed, alreadySub = false;
            string input;
            int OK;
            char ship;

            DrawBoard(1);

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    PlayerBoard[i, j] = ' ';

        }

        public void DrawBoard(int whichBoard)
        {
            if (whichBoard == 0)
            {
                Console.SetCursorPosition(2, 56);
                Console.WriteLine("Computer's Board");
            }
            else
            {
                Console.SetCursorPosition(2, 9);
                Console.WriteLine("Player's Board");
            }
        }
    }
}
