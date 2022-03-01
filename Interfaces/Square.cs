using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Square : IShape, IColour
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Colours Colour { get; set; }
        public double Area()
        {
            return Width * Height;
        }

        public Square(double height, double width)
        {
            Height = height;
            Width = width;
        }
    }
}