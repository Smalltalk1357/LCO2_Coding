namespace LCO2Day07;

public class Day07Task1
{
    public static void Run()
    {
        List<string> writeToFile = ParseFile();
        CreateFile(writeToFile);
        Console.WriteLine("File Created");
    }

    public static List<string> ParseFile()
    {
        List<string> output = [];
        
        while (true)
        {
            string newLine = Console.ReadLine();
            if (newLine == "")
            {
                return output;
            }
            output.Add(newLine);
        }
    }
    
    public static void CreateFile(List<string> input, string filename = "sentences.txt")
    {
        File.WriteAllLines(filename, input);
    }
}