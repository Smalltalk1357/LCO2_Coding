namespace LCO2Day03;
// swaps the values of two integer numbers (hint: by value vs by reference - use the ref or out keyword)

public class Day03Task5
{
    public static void Run()
    {
        int a = 1;
        int b = 2;
        Console.WriteLine($"a = {a}, b = {b}");
        SwapValues(ref a, ref b);
        Console.WriteLine($"a = {a}, b = {b}");
    }

    public static void SwapValues(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}