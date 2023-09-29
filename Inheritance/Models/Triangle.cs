using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Triangle : Shape2D
    {
        public int Angle { get; private set; }

        public Triangle(int width, int height, int angle) : base(width, height, "Trójkąt")
        {
            Angle = angle;
        }

        public override float CalculateArea()
        {
            return (float) (Height * Width * Math.Cos(Angle));
        }

        public override string ToString()
        {
            return base.ToString() + $" oraz o kącie między bokami {Angle}";
        }
    }
}
