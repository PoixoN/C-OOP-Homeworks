using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_3._0
{
    abstract class Triangle
    {
        public float A { get; set; }
        public float B { get; set; }
        public float angleAB { get; set; }

        public Triangle(float sideA, float sideB, float angle)
        {
            A = sideA;
            B = sideB;
            angleAB = angle;
        }

        public abstract float GetPerimeter();

        public abstract float GetArea();
    }
}
