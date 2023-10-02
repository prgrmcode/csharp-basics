namespace longest;

public class Longest
{
    private static List<string> _wordsList;

    public List<string> WordsList {
        get { return _wordsList; }
    }

    public Longest (List<string> list1) {
        _wordsList = list1;
    }

    public string FindLongest() {
        string longest = null;
        int length = 0;
        foreach (var word in WordsList)
        {
            if (word.Length > length)
            {
                length = word.Length;
                longest = word;                
            }            
        }
        
        return longest;

    }

}
