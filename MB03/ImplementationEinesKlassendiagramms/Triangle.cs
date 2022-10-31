using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationEinesKlassendiagramms
{
    internal class Triangle
    {
        private Point center;

        public String Name { get; set; }
        public Color Color { get; private set; }

        protected Point[] Points { get; private set; }

        public int calcCircumference()
        {
            return 0;
        }
    }
}
