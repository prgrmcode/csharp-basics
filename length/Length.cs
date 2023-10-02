namespace length;

public class Length
{
    private static string _word;
    public string Word {
        get { return _word; }
    }

    public Length(string str) {
        _word = str;
    }

    public void FindLength() {
        int i = 0;
        foreach (var item in Word)
        {
            i++;
        }

        int length = Word.Length;

        Console.WriteLine($"FindLength length: {i}");
        Console.WriteLine($"string.Length: {length}");
    }

}
