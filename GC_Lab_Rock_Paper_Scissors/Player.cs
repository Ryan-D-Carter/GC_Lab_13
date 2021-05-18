using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_Rock_Paper_Scissors
{
    public interface Player
    {
        public string Name { get; set; }

        public abstract RPS GenerateRPS();
    }
}
