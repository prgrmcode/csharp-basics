namespace fizzbuzz;

public class FizzBuzz
{
    private static int _length;
    public int Length {
        get { return _length; }
        set { _length = value; }
    }

    private static int _fizz;
    public int Fizz {
        get { return _fizz; }
        set { _fizz = value; }
    }

    private static int _buzz;
    public int Buzz {
        get { return _buzz; }
        set { _buzz = value; }
    }


    public FizzBuzz(int len, int fizz, int buzz) {
        _length = len;
        _fizz = fizz;
        _buzz = buzz;
    }

    public void calcFizzBuzz() {
        for (int i = 1; i <= Length; i++)
        {
            if (i % 10 == 1)
            {
                Console.WriteLine();                
            }

            if (i % Fizz == 0 && i % Buzz == 0)
            {
                Console.Write("fizzbuzz, ");
            }
            else if (i % Fizz == 0)
            {
                Console.Write("fizz, ");
                
            } else if (i % Buzz == 0)
            {
                Console.Write("buzz, ");                
            } else
            {
                Console.Write(i + ", ");
            }
            
        }

        // empty line after counting:
        Console.WriteLine();
    }
}
