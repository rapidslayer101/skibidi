using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        
        // Generate 3 dice rolls and sum them
        public int RollDice()
        {   
            // Create random object
            Random random = new Random();
            
            // Create 3 dice objects
            Die die1 = new Die();
            Die die2 = new Die();
            Die die3 = new Die();
            
            // Roll the dices
            var roll1 = die1.Roll(random);
            var roll2 = die2.Roll(random);
            var roll3 = die3.Roll(random);
            
            // Write dice outputs to console
            Console.WriteLine("Roll 1: " + roll1);
            Console.WriteLine("Roll 2: " + roll2);
            Console.WriteLine("Roll 3: " + roll3);
            
            // Sum all the dice rolls
            int total = roll1 + roll2 + roll3;
            return total;
        }
        
        // write the output of RollDice to the console
        public void ReportTotal(int total)
        {
            Console.WriteLine("The total of the three dice rolls is: " + total);
        }
    }
}
