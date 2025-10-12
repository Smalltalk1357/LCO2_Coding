namespace LCO2Day07;

public class Day07Task7
{
    public static void Run()
    {
        
    }

    public static List<char> DisplayFile(string filename, int startRange = 0, int endRange = 10)
    {
        List<string> lines = Utils.FileToList(filename);

        string textFile = string.Join(' ', lines);
        
    }
}