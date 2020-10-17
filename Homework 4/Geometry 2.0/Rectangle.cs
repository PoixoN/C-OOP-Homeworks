using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_2._0
{
    class Rectangle : Shape
    {
        public float SideA { get; set; }
        public float SideB { get; set; }

        public Rectangle(float sideA, float sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }      

        public override float GetPerimeter()
        {
            return (float)Math.Round(SideA * 2 + SideB * 2, 2);
        }

        public override float GetArea()
        {
            return (float)Math.Round(SideA * SideB, 2);
        }
    }
}
