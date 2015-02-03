using System;


class Point3D
{
    public int x;
    public int y;
    public int z;
    private static readonly Point3D StartingPoint = new Point3D(0, 0, 0); 
    public Point3D(int x, int y, int z)
    {
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    public int X
    {
        get
        {
            return this.x;
        }
        set
        {
            this.x = value;
        }
    }
    public int Y
    {
        get
        {
            return this.y;
        }
        set
        {
            this.y = value;

        }
    }
    public int Z
    {
        get
        {
            return this.z;
        }
        set
        {
            this.z = value;

        }
    }
  
    public override string ToString()
    {
        return string.Format("  Static coordinates: {0}, {1}, {2}Instance coordinates: {3}, {4}, {5}",StartingPoint.x,StartingPoint.y,StartingPoint.z +"\n",x, y, z);
    }
    class program
    {
        public static void Main()
        {
            Point3D StartingPoint = new Point3D(10, 100, 1000);
            Console.WriteLine(StartingPoint);
            Point3D.StartingPoint.x=200;//read-only
        }
    }
}
