﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Rectangle : Shape2D, IColor
    {
        public Rectangle(int width, int height) : base(width, height, "Prostokąt")
        {
        }

        public override float CalculateArea()
        {
            return Height * Height;
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
