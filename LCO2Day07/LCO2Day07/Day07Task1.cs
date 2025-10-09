namespace LCO2Day07;

public class Day07Task1
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("--- EDITING --- (return empty line to exit)");
        List<string> writeToFile = ReadLines();
        Console.WriteLine("--- END OF EDITING ---\n");
        
        
        string outputPath = Utils.GetCurrentDirectory("sentences.txt");
        if (File.Exists(outputPath))
        {
            Console.WriteLine("--- APPENDING TO FILE ---");
            File.AppendAllLines(outputPath, writeToFile);
        }
        else
        {
            Console.WriteLine("--- CREATING FILE ---");
            File.WriteAllLines(outputPath, writeToFile);
        }
    }

    private static List<string> ReadLines()
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
}
