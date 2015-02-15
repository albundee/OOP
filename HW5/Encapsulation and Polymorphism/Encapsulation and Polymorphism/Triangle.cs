using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Polymorphism
{
    public class Triangle : Shapes,IShape
    {
        public Triangle(double width, double height)
            : base(width, height, 0)
        {
        }
        public virtual double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public virtual double CalculatePerimeter()
        {
            return (this.Width + this.Width + this.Height + this.Height) / 2;
        }
    }
}
