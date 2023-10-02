namespace multiplication;

public class Multiplication
{
    public void PrintTable(int num) {
        for (int i = 1; i <= 10; i++)
        {
            int result = i * num;

            string iPart = i.ToString().PadLeft(2).PadRight(3);
            string numPart = num.ToString().PadLeft(2).PadRight(3);
            string resultPart = result.ToString().PadLeft(4);
            Console.WriteLine($"{iPart} * {numPart} = {resultPart}");
            
        }
    }

}
