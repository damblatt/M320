using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    internal class Rechteck : Figure, IRotatable
    {
        public void Rotate()
        {
            Console.WriteLine("Rechteck dreht sich.");
        }
    }
}
