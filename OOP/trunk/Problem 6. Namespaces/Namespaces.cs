using System;
using Geometry.UI;
using Geometry.Storage;
using Geometry.Geometry3D;
using Geometry.Geometry2D;

namespace Geometry
{
    class program
    {
        static void Main()
        {
            Point2D a = new Point2D();
            Figure2D b = new Figure2D();
            Square c = new Square();
            Rectangle d = new Rectangle();
            Circle e = new Circle();
            Elipse f = new Elipse();
            DistanceCalculator2D g = new DistanceCalculator2D();
            Point3D h = new Point3D();
            Path3D i = new Path3D();
            DistanceCalculator3D j = new DistanceCalculator3D();
            GeometryBinaryStorage k = new GeometryBinaryStorage();
            GeometrySVGStorage l = new GeometrySVGStorage();
            GeometryXMLStorage m = new GeometryXMLStorage();
            Screen2D n = new Screen2D();
            Screen3D o = new Screen3D();
        }
    }
}
