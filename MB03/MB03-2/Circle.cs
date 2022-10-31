using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB03_2
{
    internal class Circle
    {
        private static Circle instance;

        private Circle()
        {

        }

        public Circle Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Circle();
                }
                return instance;
            }
        }
    }
}
