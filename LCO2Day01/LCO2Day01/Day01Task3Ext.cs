namespace LCO2Day01;

public class Day01Task3Ext
{
    public static void Run()
    {
        bool tryAgain = true;
        while (tryAgain)
        {
            Console.WriteLine(GetPi());
            Console.Write("Try again? [y/n]: ");
            string input = Console.ReadLine();
            if (input == "n")
                tryAgain = false;
        }   
    }

    public static double GetPi()
    {
        Random random = new Random();
        int count = 9999999; // HAS TO BE GREATER THAN 0
        
        double x = 0, y = 0;
        double distance = 0;

        double countInside = 0;
        double countTotal = 0;
        for (int i = 0; i < count; i++)
        {
            x = random.NextDouble();
            y = random.NextDouble();
            
            distance = Math.Sqrt(x * x + y * y);

            if (distance <= 1)
            {
                countInside++;
            }
            countTotal++;
        }
        
        return ((4.0 * (countInside / countTotal)));
    }
}
