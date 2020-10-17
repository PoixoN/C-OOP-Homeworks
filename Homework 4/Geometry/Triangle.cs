using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    class Triangle
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

        /// <summary>
        /// Return double array of angles
        /// </summary>
        /// <returns>angleAB, angleBC, angleCA</returns>
        public double[] GetAngles()
        {
            float cosAB = (A * A + C * C - B * B) / (2 * A * C);
            float cosBC = (A * A + B * B - C * C) / (2 * A * B);
            float cosCA = (B * B + C * C - A * A) / (2 * B * C);

            double angleAB = Math.Round(Math.Acos(cosAB) * 180 / Math.PI, 2);
            double angleBC = Math.Round(Math.Acos(cosBC) * 180 / Math.PI, 2);
            double angleCA = Math.Round(Math.Acos(cosCA) * 180 / Math.PI, 2);

            return new double[] { angleAB, angleBC, angleCA };
        }

        public float GetPerimeter()
        {
            return A + B + C;
        }

        public virtual float GetArea()
        {
            //p is halfperimeter
            float p = this.GetPerimeter() / 2;
            return (float)Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }
    }
}
