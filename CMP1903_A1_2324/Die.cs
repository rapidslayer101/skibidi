﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die

    {
    // Die value Property
    private int dieValue;

    // Roll dice method
    public int Roll(Random random)
    {
        dieValue = random.Next(1, 7);
        return dieValue;
    }

    }
}
