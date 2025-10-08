namespace LCO2Day07;

public class Day07Task2
{
    public static void Run()
    {
        string filename = Utils.GetCurrentDirectory("stations.txt");
    }
    
    private static List<string> ParseFile()
    {
        List<string> output = [];
        
        while (true)
        {
            string newLine = Console.ReadLine();
            if (newLine == "")
            {
                return output;
            }
        }
    }
    private static void ParseTerm(string term, List<string> lines)
    {
        
    }
}