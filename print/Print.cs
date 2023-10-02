namespace print;

public class Print
{
    private static int _n;
    public int N {
        get { return _n; }
        set { _n = value; }
    }

    public Print(int num) {
        _n = num;
    }

    public void PrintNumbers() {
        if (N >= 1)
        {
            Console.Write($"{N}  ");
            N = N-1;
            PrintNumbers();
        }
        else
        {
            Console.WriteLine();
        }
    }

}
