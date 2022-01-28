using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsSample1
{
    internal class Circle : Dimension_Shape
    {
        private double _radius;
        public Circle(string color , double radius) : base(color)
        {
            _radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * _radius;
        }
    }
}
