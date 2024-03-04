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
            var game = new Game();
            var total = game.RollDice();
            
            // write the output of RollDice to the console
            Console.WriteLine("The total of the three dice rolls is: " + total);
            
            // Creates a testing object and calls its method
            var test = new Testing();
            test.TestGame();
        }
    }
}
