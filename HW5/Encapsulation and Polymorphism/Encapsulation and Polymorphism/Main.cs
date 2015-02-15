using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_and_Polymorphism
{
    class Application
    {
        public static void Main()
        {
            Triangle tri=new Triangle(10,20);
            Rectangle rec = new Rectangle(10, 200);
            Circle circ = new Circle(10);
            IList<Shapes> shapes = new List<Shapes>();
            shapes.Add(tri);
            shapes.Add(rec);
            shapes.Add(circ);
            //{
                //new Triangle (10,20){Height=10,Width=20},
                //new Rectangle (10,20){Height=10,Width=20},
                //new Circle(10){Radius=10},
                
            //};          
            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetType().Name + " Area is: " + item.Height + " Perimeter is: " + item.Width);
            }
        }
    }
}
