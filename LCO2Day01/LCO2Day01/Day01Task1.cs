namespace LCO2Day01;

public class Day01Task1
{
    public static void Run()
    {
        Race();
    }

    private static void Race()
    {
        int distance = 10000; // distance in meters
        double conversionRatio = 3.6; // conversion between m/s and km/h
        
        int minutes = Utils.GetInt("minutes");
        int seconds = Utils.GetInt("seconds");
        
        int totalTime = minutes * 60 + seconds;
        int speed = distance / (totalTime);
        double newSpeed = speed * conversionRatio;
        
        Console.WriteLine("Speed: " + speed + " m/s");
        Console.WriteLine("Speed: " + newSpeed + " km/h");
    }
}