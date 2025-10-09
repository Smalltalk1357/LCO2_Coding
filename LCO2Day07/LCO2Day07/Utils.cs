namespace LCO2Day07;

public class Utils
{
    public static string GetCurrentDirectory(string filename = "") 
    {
        // I used some help to find the file path - suggested by AI
        string currentDirectory = Directory.GetCurrentDirectory();
        string projectRoot = Path.GetFullPath(Path.Combine(currentDirectory, "../../../"));
        string outputPath = Path.Combine(projectRoot, filename);
        return outputPath;
    }
    
    public static List<string> FileToList(string filename)
    {
        List<string> output = [];
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            output.Add(line);
        }
        return output;
    }
}