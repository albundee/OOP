using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Polymorphism
{
    public class Rectangle : Shapes, IShape
    {
        public Rectangle(double width, double height)
            : base(width, height, 0)
        {
        }
        public virtual double CalculateArea()
        {
            return (this.Width * this.Height);
        }

        public virtual double CalculatePerimeter()
        {
            return (this.Width + this.Width + this.Height + this.Height);
        }
    }
}
