namespace sort;

public class Sort
{
    private static string _str;
    public string Str {
        get { return _str; }
        set { _str = value; }
    }

    public Sort(string s) {
        _str = s;
    }

    public void SortStrings() {        
        string[] stringArray = Str.Split();

        // Sort the words alphabetically
        Array.Sort(stringArray);

        // Join the sorted words back into a string
        string sortedString = string.Join(" ", stringArray);


        Console.WriteLine("Original String:");
        Console.WriteLine(Str);

        Console.WriteLine("Sorted String:");
        Console.WriteLine(sortedString);

    }
    
}
