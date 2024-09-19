// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");
Console.WriteLine(ArithmeticOperators.Circumference(13));
Console.WriteLine(ArithmeticOperators.Area(15));
Console.WriteLine(ArithmeticOperators.Divide(18,9));
Console.WriteLine(ArithmeticOperators.Hypotenuse(24,5));
ArithmeticOperators.BooksDiv();
ArithmeticOperators.KiB(2048);
ArithmeticOperators.Savings();



public class ArithmeticOperators
{
    public static double Circumference(double radiusofball)
    {
        double circumference = Math.PI * 2 * radiusofball;
        return Math.Round(circumference, 2);
    }

    public static double Area(double radiusofball)
    {
        return Math.PI * Math.Pow(radiusofball, 2);
    }

    public static bool Divide(int integer1, int integer2)
    {
        return integer1 % integer2 == 0;
    }

    public static double Hypotenuse(double sidea, double sideb)
    {
        return Math.Sqrt(Math.Pow(sidea, 2) + Math.Pow(sideb, 2));
    }

    public static void BooksDiv()
    {
        Console.WriteLine("Enter the number of students");
        string? student = Console.ReadLine();
        int noofstudent = int.Parse(student ?? string.Empty);
        Console.WriteLine("Enter the number of books");
        string? books = Console.ReadLine();
        int noofbook = int.Parse(books ?? string.Empty);
        int perperson = noofbook / noofstudent;
        Console.WriteLine($"The number of books each person can get is {perperson}");
        Console.WriteLine($"The number of remaining books are {noofbook % noofstudent}");
    }

    public static void KiB(int size)
    {
        const double block = 512;
        Console.WriteLine($"The number of blocks needed is {Math.Ceiling(size/block)}");
    }

    public static void Savings()
    {
        Console.WriteLine("Enter the amount of pocket money per week");
        string? money = Console.ReadLine();
        double total = double.Parse(money ?? string.Empty);
        Console.WriteLine("Enter the percentage you want to save");
        string? percentage = Console.ReadLine();
        double totalpercentage = double.Parse(percentage ?? string.Empty);
        Console.WriteLine($"You will be saving ${total*totalpercentage/100} per week");
        Console.WriteLine($"You will have ${52*total*totalpercentage/100} after one year");
    }
}