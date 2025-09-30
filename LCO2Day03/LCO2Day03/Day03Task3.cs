using System.Diagnostics;

namespace LCO2Day03;
// takes an integer and returns a boolean, true if the input was prime, false otherwise.

public class Day03Task3
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is {input} prime? {IsPrime(input)}");
    }

    private static bool IsPrime(int input)
    {
        if (input < 2) return false;

        for (int i = 2; i <= Math.Sqrt(input); i++)
            if (input % i == 0)
                return false;

        return true;
    }

    public static void RunTest()
    {
        Debug.Assert(IsPrime(11));
        Debug.Assert(!IsPrime(12));
        Debug.Assert(IsPrime(13));
    }
}