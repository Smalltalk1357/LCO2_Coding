namespace LCO2Day03;
// Take the multiplication code that you wrote for the Intro exercises and
// give default values for the multiplier (your choice) and the multiplicand (12).
// Call the function with some missing parameters to confirm that it works.

public class Day03Task7
{
    public static void Run()
    {
        Console.WriteLine("2, 10");
        TimesTable(2, 10);
        Console.WriteLine("\n 8, default value");
        TimesTable(8);
        Console.WriteLine("\n default value, 15");
        TimesTable(limit: 15);
        Console.WriteLine("\n default values");
        TimesTable();
    }

    public static void TimesTable(int number = 5, int limit = 12)
    {
        for (int i = 1; i <= limit; i++)
        {
            string template = $"{i,3} x {number,3} = {i * number,3}";
            Console.WriteLine(template);
        }
    }
}