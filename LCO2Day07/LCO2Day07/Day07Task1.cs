namespace LCO2Day07;

public class Day07Task1
{
    public static void Run()
    {
        Console.Clear();
        Console.WriteLine("--- EDITING --- (return empty line to exit)");
        List<string> writeToFile = ParseFile();
        Console.WriteLine("--- END OF EDITING ---\n");
        
        
        string outputPath = GetCurrentDirectory("sentences.txt");
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
            output.Add(newLine);
        }
    }

    private static string GetCurrentDirectory(string filename = "") 
    {
        // I used some help to find the file path - suggested by AI
        string currentDirectory = Directory.GetCurrentDirectory();
        string projectRoot = Path.GetFullPath(Path.Combine(currentDirectory, "../../../"));
        string outputPath = Path.Combine(projectRoot, filename);
        return outputPath;
    }
}