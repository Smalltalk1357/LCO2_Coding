using System.Diagnostics;

namespace LCO2Day03;

// calculates the sum of the individual digits of a given integer.
public class Day03Task2
{
    public static void Run()
    {
        int input = 1509;
        Console.WriteLine($"The sum of all the digits is {CalcSumDigit(input)}");
    }

    private static int CalcSumDigit(int input)
    {
        int number = Math.Abs(input);
        int total = 0;

        while (number > 0)
        {
            total += number % 10;
            number /= 10;
        }

        return total;
    }

    public static void RunTest()
    {
        int input = 1509;
        Debug.Assert(CalcSumDigit(input) == 15);
        input = -1509;
        Debug.Assert(CalcSumDigit(input) == 15);
        input = 123456789;
        Debug.Assert(CalcSumDigit(input) == 45);
        // input = 0;
        // Debug.Assert(CalcSumDigit(input) == 1, "Task Failed Successfully");
    }
}