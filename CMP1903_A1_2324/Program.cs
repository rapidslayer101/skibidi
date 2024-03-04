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
            try
            {
                var game = new Game();
                var total = game.RollDice();
                
                // write the output of RollDice to the console
                Console.WriteLine("The total of the three dice rolls is: " + total);
            }
            // Catch exception of the game method
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            // Creates a testing object and calls its method
            try
            {
                var test = new Testing();
                test.TestGame();
            }
            // Catch exception of the test method
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
