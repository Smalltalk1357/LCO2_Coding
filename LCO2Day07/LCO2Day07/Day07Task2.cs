namespace LCO2Day07;

// Questions for stations.txt
public class Day07Task2
{
    // For Q2, the station name is Battersea Power Station
    
    public static void Run()
    {
        string filename = Utils.GetCurrentDirectory("stations.txt");
        List<string> input = Utils.ParseFile(filename);
        List<string> output = SearchForTerm("Station", input);
        Console.WriteLine(output[0]);
    }
    
    
    private static string ParseTerm(string input, int index = 0)
    {
        string[] inputTerms = input.Split(",");
        return inputTerms[index]; // In the case of stations.txt, the first term is the station name
    }
    
    private static List<string> SearchForTerm(string term, List<string> input)
    {
        List<string> output = [];
        
        foreach (string line in input)
        {
            if (line.ToLower().Contains(term.ToLower()))
            {
                string returnValue = ParseTerm(line);
                output.Add(returnValue);
            }
        }
        return output;
    }

    private static string CheckLetters(string input1, string input2)
    {
        char[] letters = input1.ToCharArray();
        
        foreach (char character in letters)
        {
            
        }
        return "";
    }
}