using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_2._0
{
    class Circle : Shape
    {
        public float Radius { get; set; }
        public Circle(float radius)
        {
            Radius = radius;
        }   
        public override float GetPerimeter()
        {
            return (float)Math.Round(2 * (float)Math.PI * Radius, 2);
        }

        public override float GetArea()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}
