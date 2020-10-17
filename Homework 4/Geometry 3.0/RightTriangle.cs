using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_3._0
{
    class RightTriangle : Triangle
    {
        public RightTriangle(float sideA, float sideB, float angleAB) : base(sideA, sideB, angleAB)
        {
        }

        public override float GetPerimeter()
        {
            if(angleAB == 90)
            {
                float C = (float)Math.Sqrt(A * A + B * B);
                return (float)Math.Round(A + B + C, 2);
            }
            else
            {
                //Якщо A більше тоді А буде гіпотенузою, інакше B гіпотенуза
                if(A > B)
                {
                    float C = (float)Math.Sqrt(A * A - B * B);
                    return (float)Math.Round(A + B + C, 2);
                }
                else
                {
                    float C = (float)Math.Sqrt(B * B - A * A);
                    return (float)Math.Round(A + B + C, 2);
                }
            }
        }

        public override float GetArea()
        {
            if(angleAB == 90)
                return (float)Math.Round(A * B / 2, 2);
            else
                return (float)Math.Round(A * B * Math.Sin(angleAB) / 2, 2);
        }
    }
}
