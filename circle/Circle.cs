namespace circle;


public class Circle
{
    private double _x;
    private double _y;

    private double _pi;
    private double _r;

    private double _area;

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

    public double Pi {
        get 
        { 
            _pi = Math.PI; 
            return _pi;         
        }
    }

    public double R {
        get { return _r; }
        set 
        { 
            if (value > 0)
            {
                _r = value; 
            }
            else
            {
                throw new Exception("radius must be a positive number!");

            }
            
        }
    }
    private double Area {
        get 
        { 
            Console.WriteLine($"pi:{Pi}");
            Console.WriteLine($"r:{R}");
            double area = Pi * Math.Pow(R, 2); 
            _area = area; 
            return _area;
        }
    }

    public Circle(double x, double y, double r) {
        X = x;
        Y = y;
        R = r;
    }

    public void getArea() {
        Console.WriteLine($"Area of the circle: {Area}");
    }

}
