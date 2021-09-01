using System;

/* Main view layer of program.  Original concept is to be a simple command line game of rock, paper, scissors.  */

namespace rock_papper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*I understand that proper naming conventions should have it listed as RPSStrategy or 
             * some variation there of, but this gave me too much of a laugh to change. */
            BigBrain bigBrain = new BigBrain();
            bigBrain.MainGameLoop();
        }
    }
}
