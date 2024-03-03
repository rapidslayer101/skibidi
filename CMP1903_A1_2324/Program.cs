using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a game object and calls its methods
            Game game = new Game();
            var total = game.RollDice();
            game.ReportTotal(total);
            
            // Creates a testing object and calls its method
            Testing test = new Testing();
            test.TestGame();
        }
    }
}
