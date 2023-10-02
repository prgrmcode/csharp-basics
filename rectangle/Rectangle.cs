namespace rectangle;

public class Point
{
    private double _x;
    private double _y;
    public double X {
        get { return _x; }
        set { 
            _x = value; 
            }
    }

    public double Y {
        get { return _y; }
        set { _y = value; }
    }


    public Point(double x, double y) {
        _x = x;
        _y = y;
    }

}
public class Rectangle
{
    private Point _p1;
    private Point _p2;
    public Point P1 {
        get { return _p1; }
        set { 
            _p1 = value; 
            }
    }

    public Point P2 {
        get { return _p2; }
        set { _p2 = value; }
    }

    public double a {
        get {
            if (P1.X - P2.X > 0)
            {
                return P1.X - P2.X;
            } else
            {
                return P2.X - P1.X;                
            }
                        
        }
    }

    public double b {
        get {
            if (P1.Y - P2.Y > 0)
            {
                return P1.Y - P2.Y;
            } else
            {
                return P2.Y - P1.Y;                
            }
                        
        }
    }

    public Rectangle(Point po1, Point po2) {
        if (po1.X != po2.X && po1.Y != po2.Y)
        {
            _p1 = po1;
            _p2 = po2;
        } else
        {
            Console.WriteLine("Coordinates x1 and x2 or y1 and y2 cannot be the same!");
            throw new Exception("Coordinates x1 and x2 or y1 and y2 cannot be the same!!!");
        }
    }

    public void getCircumference() {
        double circumference = 2 * (a + b);
        Console.WriteLine($"Circumference of the rectangle: {circumference}");
    }

    public void getArea() {
        double area = a * b;
        Console.WriteLine($"Area of the rectangle: {area}");
    }


}
