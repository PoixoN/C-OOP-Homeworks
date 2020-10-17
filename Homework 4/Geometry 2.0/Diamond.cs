using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_2._0
{
    class Diamond : Shape
    {
        public float Side { get; set; }

        public Diamond(float side)
        {
            Side = side;
        }

        public override float GetPerimeter()
        {
            return (float)Math.Round(Side * 4, 2);
        }

        public override float GetArea()
        {
            return (float)Math.Round(Side * Side, 2);
        }
    }
}
