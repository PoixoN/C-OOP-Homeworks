using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_3._0
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(float sideA, float sideB, float angleAB) : base(sideA, sideB, angleAB)
        {
        }

        /// <summary>
        /// c² = a² + b² - 2ab * cos(AB)
        /// </summary>
        /// <returns></returns>
        public override float GetPerimeter()
        {
            float C = (float)Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(angleAB));
            return (float)Math.Round(A + B + C, 2);
        }

        /// <summary>
        /// S = A * B * sin(AB) / 2
        /// </summary>
        /// <returns></returns>
        public override float GetArea()
        {
            return (float)Math.Round(A * B * Math.Abs(Math.Sin(angleAB)) / 2, 2);
        }
    }
}
