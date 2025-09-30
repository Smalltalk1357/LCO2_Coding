namespace LCO2Day02;

public class Day02Task1
{
    public static void Run()
    {
        int num1 = 4;
        int num2 = 5;
        
        Console.WriteLine($"Statement ({num1} = {num2}) is {IsEqual(num1, num2)}");
    }

    public static bool IsEqual(int num1, int num2)
    {
        if (num1 == num2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}