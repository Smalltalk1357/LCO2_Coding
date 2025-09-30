namespace LCO2Day01;

public class Day01Task2
{
    public static void Run()
    {
        TimesTable();
    }

    private static void TimesTable()
    {
        int number = Utils.GetInt("any integer");
        
        // int limit = 12;
        int limit = Utils.GetInt("limit");
        
        for (int i = 1; i <= limit; i++)
        {
            string template = $"{i, 3} x {number, 3} = {i * number, 3}";
            Console.WriteLine(template);
        }
    }
}