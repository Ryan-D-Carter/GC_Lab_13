using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GC_Lab_Rock_Paper_Scissors
{
    class RandomPlayer : Player
    {
        public string Name { get; set; }


        public RPS GenerateRPS()
        {
            // generate a random value
            Random rnd = new Random();
            Type rps = typeof(RPS);
            Array values = rps.GetEnumValues();
            int index = rnd.Next(values.Length);
            RPS num = (RPS)values.GetValue(index);


            // returning either rock, paper, or scissors
            return num;
        }
    }
}
