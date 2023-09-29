using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal abstract class Shape2D : Shape1D
    {
        public int Height { get; private set; }
        public Shape2D(int width, int height, string name) : base(width, name)
        {
            Height = height;
        }


        public override string ToString()
        {
            return $"{base.ToString()} i wysokości {Height}";
        }



        public abstract float CalculateArea();

    }
}
