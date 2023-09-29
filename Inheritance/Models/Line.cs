using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Line : Shape1D, IColor
    {
        public Line(int width) : base(width, "Odcinek")
        {
        }

        private string _colorName;

        public string GetColor()
        {
            return _colorName;
        }

        public void SetColor(string colorName)
        {
            _colorName = colorName;
        }
    }
}
