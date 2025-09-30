namespace LCO2Day04;

public class Day04Task2
{
    public static void Run()
    {
        CreateTriangle(4);
    }

    public static void CreateTriangle(int n)
    {
        string star = "*";
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(star);
            star += "*";
        }
    }
}