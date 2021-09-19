using System;
using RockPaperScissorsLibrary;

/* Main view layer of program.  Original concept is to be a simple command line game of rock, paper, scissors.  */

namespace RockPaperScissorsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLoop gameLoop = new GameLoop();
            gameLoop.MainGameLoop();
        }
    }
}

