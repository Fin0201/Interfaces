using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area();
    }
}