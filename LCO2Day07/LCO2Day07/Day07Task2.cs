using System.Diagnostics;

namespace LCO2Day07;

// Questions for stations.txt
public class Day07Task2
{
    // Q2: Battersea Power Station
    // Q3a: 
    
    public static void Run()
    {
        string filename = Utils.GetCurrentDirectory("stations.txt");
        List<string> input = Utils.FileToList(filename);
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
        term = term.ToLower();
        
        List<string> output = [];
        
        foreach (string line in input)
        {
            if (line.ToLower().Contains(term))
            {
                string returnValue = ParseTerm(line);
                output.Add(returnValue);
            }
        }
        return output;
    }

    private static bool ShareLetters(string subString, string baseString)
    {
        baseString = baseString.ToLower();
        subString = subString.ToLower();
        
        char[] letters = subString.ToCharArray();
        foreach (char character in letters)
        {
            if (!baseString.Contains(character))
            {
                return false;
            }
        }
        
        return true;
    }

    public static void RunTest()
    {
        string testBaseString = "Mackerel";
        Debug.Assert(ShareLetters("mackerel", testBaseString));
        Debug.Assert(ShareLetters("mac", testBaseString));
        Debug.Assert(ShareLetters("lack", testBaseString));
        Debug.Assert(ShareLetters("real", testBaseString));
        Debug.Assert(ShareLetters("kernel", testBaseString) == false);
    }
}