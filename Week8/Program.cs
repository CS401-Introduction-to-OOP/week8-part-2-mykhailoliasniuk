
using Week8;

class Program
{
    public static void Main()
    {
        Point p1 = new Point { X = 1, Y = 2 };
        Point p2 = p1;
        p2.X = 6;
        
        p1.Print();
        p2.Print();


        PointRef r1 = new PointRef { X = 1, Y = 2 };
        PointRef r2 = r1;
        r1.X = 7;
        r1.Print();
        r2.Print();
        
        BoxingTaster.Test();
    }
    
}