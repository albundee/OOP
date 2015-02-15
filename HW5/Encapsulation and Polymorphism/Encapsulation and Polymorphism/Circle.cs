using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Polymorphism
{
    class Circle:Shapes,IShape
    {
        public Circle(double radius)
            : base(0,0,radius )
        {
        }
        public virtual double CalculateArea()
        {
            return (2*Math.PI)*(double)radius;
        }

        public virtual double CalculatePerimeter()
        {
            return ((double)radius*(double)radius*Math.PI);
        }
    }
}
