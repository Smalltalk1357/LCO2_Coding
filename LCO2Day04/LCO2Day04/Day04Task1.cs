namespace LCO2Day04;

public class Day04Task1
{
    public static void Run()
    {
        Countdown(2);
    }

    public static void Countdown(int time)
    {
        while (time > 0)
            Console.WriteLine(time--);
        Console.WriteLine("Liftoff! \a");
    }
    
    public static void Countdown2(int time)
    {
        int totalSeconds = Math.Max(0, time);
        while (totalSeconds >= 0)
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            Console.Clear();
            Console.WriteLine($"T-{hours:D2}:{minutes:D2}:{seconds:D2}");

            if (totalSeconds == 0) break;
            System.Threading.Thread.Sleep(1000);
            totalSeconds--;
        }
        
        Console.WriteLine("Liftoff! \a");
    }
}