using System.Security.Cryptography;
using hello;
using multiplication;
using calculate;
using longest;
using length;
using print;
using isPrime;
using sort;
using rectangle;
using circle;
using fizzbuzz;

// See https://aka.ms/new-console-template for more information
static void ReturnMenu() {
    System.Console.WriteLine("Press enter to return to menu");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    // System.Console.WriteLine(keyInfo.Key);
    if (keyInfo.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        ShowMenu();
    }
    else {
        Console.WriteLine("\nYou pressed a different key. Waiting for Enter...");
        ReturnMenu();
    }
    
}
while (true)
{
    ShowMenu();

    ReturnMenu();
    
}

static void ShowMenu() {
    Console.WriteLine("1) Hello");
    Console.WriteLine("2) Multiplication Table");
    Console.WriteLine("3) Calculations");
    Console.WriteLine("4) Longest word");
    Console.WriteLine("5) Length of string");
    Console.WriteLine("6) Print numbers");
    Console.WriteLine("7) Is Prime?");
    Console.WriteLine("8) Sort");
    Console.WriteLine("9) Get Area");
    Console.WriteLine("10) FizzBuzz");
    Console.WriteLine("99) EXIT");

    int prompt = int.Parse(Console.ReadLine());
    switch (prompt)
    {
        case 1:
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            Hello h1 = new();
            h1.PrintHello(name);
            
            break;

        case 2:
            Console.WriteLine("Enter a number:");
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            }

            Multiplication m1 = new();
            m1.PrintTable(number);

            break;

        case 3:
            Console.WriteLine("Enter two numbers:");
            int number1, number2;
            try
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            }

            Calculate c = new Calculate(number1, number2);
            
            break;

        case 4:
            Console.WriteLine("Enter a string:");
            string? words = Console.ReadLine();
            // Split the input string into an array of substrings
            string[] stringArray = words.Split();

            // Convert the array to a List<string>
            List<string>? stringList = new(stringArray);

            Longest l = new(stringList);
            string longest = l.FindLongest();
            Console.WriteLine($"Longest word is: '{longest}'");

            break;

        case 5:
            Console.WriteLine("Enter a string:");
            string? str = Console.ReadLine();

            Length length = new(str);
            length.FindLength();

            break;

        case 6:
            Console.WriteLine("Enter integer n:");
            int n;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            }

            Print p = new(n);

            p.PrintNumbers();

            break;

        case 7:
            Console.WriteLine("Enter integer number:");
            int numb;
            try
            {
                numb = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            }

            Prime prime = new(numb);
            prime.checkPrime();

            break;

        case 8:
            Console.WriteLine("Enter a string:");
            string? inputString = Console.ReadLine();
            Sort sort = new(inputString);

            sort.SortStrings();
            
            break;

        case 9:
            Console.WriteLine("Rectangle:\n Enter coordinate x1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate x2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y2:");
            double y2 = double.Parse(Console.ReadLine());
            Point p1 = new(x1, y1);
            Point p2 = new(x2, y2);

            Rectangle r = new(p1, p2);
            r.getCircumference();

            Console.WriteLine("Circle:\n Enter coordinate x:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y:");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius r:");
            double radius = double.Parse(Console.ReadLine());

            Circle circle = new(x, y, radius);
            circle.getArea();
            
            break;

        case 10:
            Console.WriteLine("Define count length: ");
            int len;
            try
            {
                len = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            } 

            Console.WriteLine("Define number for fizz: ");
            int fizz;
            try
            {
                fizz = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            } 

            Console.WriteLine("Define number for buzz: ");
            int buzz;
            try
            {
                buzz = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                throw;
            } 

            FizzBuzz fizzBuzz = new(len, fizz, buzz);
            fizzBuzz.calcFizzBuzz();

            break;

        case 99:
            Environment.Exit(0); // Exit the program
            break;
            
        default:
            Console.WriteLine("Invalid option. Press enter to show the menu.");
            Console.ReadLine();
            break;
    }

}