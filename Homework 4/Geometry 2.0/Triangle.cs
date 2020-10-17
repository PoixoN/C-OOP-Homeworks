using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_2._0
{
    class Triangle : Shape
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        /// <summary>
        /// Checks if you may create a triangle with your sides
        /// </summary>
        public Triangle(float sideA, float sideB, float sideC)
        {
            //Умови чи можна зробити трикутник
            if (sideA + sideB <= sideC ||
                sideA + sideC <= sideB ||
                sideB + sideC <= sideA)
            {
                throw new ArgumentException("The sides do not fit");
            }

            A = sideA;
            B = sideB;
            C = sideC;
        }

        public override float GetPerimeter()
        {
            return (float)Math.Round(A + B + C, 2);
        }

        public override float GetArea()
        {
            //p is halfperimeter
            float p = this.GetPerimeter() / 2;
            return (float)Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }
    }
}
