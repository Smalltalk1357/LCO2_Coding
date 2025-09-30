namespace LCO2Day02;

public class Day02Task2
{
    public static void Run()
    {
        int number = 2;
        string type = "";
        if (IsEven(number))
        {
            type = "even";
        }
        else
        {
            type = "odd";
        }
        Console.WriteLine($"{number} is {type}");

    }

    public static bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;
        return false;
    }
}