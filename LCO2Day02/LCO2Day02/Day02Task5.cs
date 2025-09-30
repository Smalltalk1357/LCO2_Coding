namespace LCO2Day02;

public class Day02Task5
{
    public static void Run()
    {
        int number = 10;
        Console.WriteLine($"{number} has {FindFactors(number)} factors");
    }

    public static int FindFactors(int number)
    {
        number = Math.Abs(number);
        if (number == 0)
        {
            return 0;
        }

        if (number == 1)
        {
            return 1;
        }

        int count = 0;
        int root = (int)Math.Sqrt(number);
        for (int i = 1; i <= root; i++)
        {
            if (number % i == 0)
            {
                int paired = number / i;
                count += (paired == i) ? 1 : 2;
            }
        }
        return count;

    }
}