using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal interface IColor
    {
        public void SetColor(string colorName);
        public string GetColor();
    }
}
