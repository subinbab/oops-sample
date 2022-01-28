using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    internal class Square : Dimension_Shape
    {
        private double _sideLength;
        public Square(string color, double sideLenght) : base(color)
        {
            _sideLength = sideLenght;
        }
        public override double GetArea()
        {
            return _sideLength * _sideLength;
        }
    }
}
