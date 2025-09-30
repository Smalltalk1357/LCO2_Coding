namespace LCO2Day01;

public class Utils
{
    public static int GetInt(string varName)
    {
        int output = 0;
        Console.Write($"Enter {varName}: ");
        string input = Console.ReadLine();

        bool valid = int.TryParse(input, out output);

        if (!valid || output < 1)
        {
            return GetInt(varName);
        }

        return output;
    }
    
    public static double GetDouble(string varName)
    {
        double output = 0;
        Console.Write($"Enter {varName}: ");
        string input = Console.ReadLine();
        
        bool valid = double.TryParse(input, out output);

        if (!valid || output < 1)
        {
            return GetDouble(varName);
        }
        return output;
    }
}