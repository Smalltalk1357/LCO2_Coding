namespace LCO2Day01;

public class Day01Task3
{
    public static void Run()
    {
        CircleCalculator();
    }

    private static void CircleCalculator()
    {
        bool valid = false;
        double radius = 0;
        double area = 0;
        double circumference = 0;
        
        // double pi = Math.PI;
        double pi = Day01Task3Ext.GetPi();
        
        while (!valid)
        {
            Console.Write("Select radius, area or circumference to input [r, a, c]: ");
            string selection = Console.ReadLine();
            
            if (selection == "r")
            {
                radius = Utils.GetDouble("radius");
                area = pi * Math.Pow(radius, 2);
                circumference = pi * radius * radius;
                valid = true;
            }
            else if (selection == "a")
            {
                area = Utils.GetDouble("area");
                radius = Math.Sqrt(area / pi);
                circumference = pi * radius * radius;
                valid = true;
            }
            else if (selection == "c")
            {
                circumference = Utils.GetDouble("circumference");
                radius = (circumference / pi) / 2;
                area = pi * Math.Pow(radius, 2);
                valid = true;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
            
        }
        Console.WriteLine($"The radius is {radius}, area is {area} and circumference is {circumference}");
    }
}