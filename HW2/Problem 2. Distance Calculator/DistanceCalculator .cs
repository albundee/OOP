using System;

class DistanceCalculator
{
    public int x;
    public int y;
    public int z;

    public DistanceCalculator(int x, int y, int z)
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
    public double Calcdistance(DistanceCalculator point) //instance
    {
        return Math.Sqrt(Math.Pow((point.x-this.x),2)+Math.Pow((point.y-this.y),2)+Math.Pow((point.z - this.z),2));
    }
    public static double Calcdistance(DistanceCalculator point1,DistanceCalculator point2) //static
    {
        return Math.Sqrt(Math.Pow((point1.x-point2.x),2)+Math.Pow((point1.y-point2.y),2)+Math.Pow((point1.z - point2.z),2));
    }
}
class program
{
    static void Main() 
    {
        DistanceCalculator startpoint = new DistanceCalculator(0,0,0);
        DistanceCalculator topoint = new DistanceCalculator(1,2,3);
        Console.WriteLine(startpoint.Calcdistance(topoint)); //instance
        Console.WriteLine(DistanceCalculator.Calcdistance(startpoint,topoint)); //static 
    }
}

