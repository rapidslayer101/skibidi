﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        
        public void TestGame()
        {   
            // Create random object
            Random random = new Random();
            
            // Create game object
            Game game = new Game();
            
            // Die rolls are between 1 and 6 (inclusive)
            Die die = new Die();
            Debug.Assert(die.Roll(random) >= 1 && die.Roll(random) <= 6, "Die roll is not between 1 and 6");
            
            // The total of the three dice rolls is between 3 and 18 (inclusive)
            var total = game.RollDice();
            Debug.Assert(total >= 3 && total <= 18, "Die rolls total is not between 3 and 18");
        }
    }
}
