using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class EqualTriangle : Triangle
    {
        public float Area { get; set; }
        public EqualTriangle(float A, float B, float C) : base(A, B, C)
        {
            Area = (float)Math.Round(Math.Sqrt(3) * A * A / 4, 2);
        }

        public override float GetArea() 
        {
            return Area;
        }
    }
}
