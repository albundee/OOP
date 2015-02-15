using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Polymorphism
{
    public abstract class Shapes
    {
        protected double? width = 0;
        protected double? height = 0;
        protected double? radius = 0;
        public Shapes(double width, double height, double radius)
        {
            this.Width = width;
            this.Height = height;
            this.Radius = radius;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
    }
}
