using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        // Method generates 3 dice rolls and sums them
        public int RollDice()
        {   
            // Create random object
            var random = new Random();
            
            // Create 3 dice objects
            var die1 = new Die();
            var die2 = new Die();
            var die3 = new Die();
            
            // Roll the dices
            var roll1 = die1.Roll(random);
            var roll2 = die2.Roll(random);
            var roll3 = die3.Roll(random);
            
            // Write dice outputs to console
            Console.WriteLine("Roll 1: " + roll1);
            Console.WriteLine("Roll 2: " + roll2);
            Console.WriteLine("Roll 3: " + roll3);
            
            // Sum all the dice rolls
            var total = roll1 + roll2 + roll3;
            return total;
        }
    }
}
