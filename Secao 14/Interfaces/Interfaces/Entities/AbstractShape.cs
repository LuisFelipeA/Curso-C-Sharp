using Interfaces.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
