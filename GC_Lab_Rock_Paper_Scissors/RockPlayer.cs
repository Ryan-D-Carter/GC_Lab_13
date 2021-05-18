using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Rock_Paper_Scissors
{
    class RockPlayer : Player
    {
        public string Name { get; set; }

        public RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }
}
