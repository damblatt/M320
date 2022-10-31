using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB03_2
{
    internal class Rectangle
    {
        public int Height { get; set; } = 100;
        public int Width { get; set; } = 200;
        public string Color { get; set; } = "black";
        public int Alpha { get; set; } = 1;

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public Rectangle(int size) : this(size, size)
        {

        }

        public Rectangle(int height, int width, string color) : this(height, width)
        {
            Color = color;
        }

        public Rectangle(int height, int width, int alpha) : this(height, width)
        {
            Alpha = alpha;
        }
    }
}
