using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_2._0
{
    abstract class Shape
    {
        public virtual float GetPerimeter() { return 0; }

        public virtual float GetArea() { return 0; }
    }
}
