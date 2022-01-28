using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    internal class Rectangle : Dimension_Shape
    {
        private double _length;
        private double _width;
        public Rectangle(string color, double length, double width) : base(color)
        {
            this._length = length;
            this._width = width;
        }

        public override double GetArea()
        {
            return _length * _width;
        }
    }
}
