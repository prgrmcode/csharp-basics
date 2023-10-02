namespace calculate;

public class Calculate
{
    private static int _num1;
    private static int _num2;

    public int Num1 {
        get { return _num1; }
        set {}
    }

    public int Num2 {
        get { return _num2; }
        set {}
    }

    public Calculate(int n1, int n2) {
        _num1 = n1;
        _num2 = n2;

        Add();
        Substract();
        Multiply();
        Divide();
    }

    private void Add() {
        int add = Num1 + Num2;
        Console.WriteLine($"{Num1} + {Num2} = {add}");
    }

    private void Substract() {
        int subt = Num1 - Num2;
        Console.WriteLine($"{Num1} - {Num2} = {subt}");
    }

    private void Multiply() {
        int m = Num1 * Num2;
        Console.WriteLine($"{Num1} * {Num2} = {m}");
    }

    private void Divide() {
        float d = (float)Num1 / Num2;
        Console.WriteLine($"{Num1} / {Num2} = {d}");
    }

}
