using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up player board
            // DrawBoard(player)
            // Initialize ships
            // Place ships
            // Display board

            IBoard player = new Player();

            char[,] playerBoard   = new char[10, 10];
            char[,] computerBoard = new char[10, 10];
            
            player.Setup(playerBoard);
            player.Setup(computerBoard);

            // Set up computer board
                // DrawBoard(computer)
                // Initialize ships
                // Place ships
                // Display board

            // Player turn

            // Computer turn

            //PrintUnicodeChars();
         
            Console.ReadKey();

            PlaceCharOnScreen();
        }

        static void PrintUnicodeChars()
        {
            Console.WriteLine("Unicode chars:");
            for (int i = 0x2554; i <= 0x255D; i += 0x10)
            {
                for (int c = 0; c <= 0xF; c++)
                {
                    Console.Write((char)(i + c));
                    Console.SetCursorPosition(10, 20);
                    Console.Write((char)(i + c));
                }
                Console.WriteLine();
            }
        }
         public static void PlaceCharOnScreen()
        {
            const char toWrite = '*'; // Character to write on-screen.

            int x = 0, y = 0; // Contains current cursor position.

            Write(toWrite); // Write the character on the default location (0,0).

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var command = Console.ReadKey().Key;

                    switch (command)
                    {
                        case ConsoleKey.DownArrow:
                            y++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (y > 0)
                            {
                                y--;
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            if (x > 0)
                            {
                                x--;
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            x++;
                            break;
                    }

                    Write(toWrite, x, y);
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
        public static void Write(char toWrite, int x = 0, int y = 0)
        {
            try
            {
                if (x >= 0 && y >= 0) // 0-based
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write(toWrite);
                }
            }
            catch (Exception)
            {
            }
        }

        
    }    
}
