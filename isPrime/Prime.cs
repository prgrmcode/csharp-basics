namespace isPrime;

public class Prime
{
    private static int _num;
    public int Num {
        get { return _num; }
        set { _num = value; }
    }

    public Prime(int n) {
        _num = n;
    }

    public void checkPrime(int i=2) {
        
        if (Num % i == 0)
        {
            Console.WriteLine($"{Num} is not a prime!");      
            return;      
        } else
        {
            i++;
            if (i < Num)
            {
                checkPrime(i);                
            } else
            {
                Console.WriteLine($"{Num} is a prime.");
            }
        }
        
        
    }
}
