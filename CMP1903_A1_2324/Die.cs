using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die

    {
    // Die value property
    private int DieValue = 0;

    // Roll dice method
    public int Roll(Random random)
    {
        DieValue = random.Next(1, 7);
        return DieValue;
    }

    }
}
