using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //: - dziedziczenie
    internal abstract class Shape1D : Shape
    {
        public int Width { get; private set; }

        //base - wywołanie konstruktora klasy bazowej
        public Shape1D(int width, string name) : base(name)
        {
            Width = width;
        }

        //base - odwołanie się do implementracji z klasy bazowej
        //this - odwołanie się do siebie samego
        public override string ToString()
        {
            return $"{base.ToString()} o szerokości {Width}";
        }

    }
}
