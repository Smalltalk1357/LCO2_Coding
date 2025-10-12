using System.Diagnostics;

namespace LCO2Day07;

// Questions for stations.txt
public class Day07Task2
{
    // Q2:  Battersea Power Station
    // Q3a: St. John's Wood
    // Q3b: Stockwell
    // Q3c: Balham
    // Q3d: None
    // Q4:  
    
    public static void Question2()
    {
        List<string> stations = Utils.FileToList("stations.txt");
        List<string> output = SearchForTerm("Station", stations);
        Console.WriteLine(string.Join(", ", output));
    }
    
    public static void Question3()
    {
        List<string> stations = Utils.FileToList("stations.txt");
        
        string[] checkNames = ["Mackerel", "Piranha", "Sturgeon", "Bacteria"];
        foreach (string name in checkNames)
        {
            Console.WriteLine($"Checking for {name}");
            foreach (string station in stations)
            {
                string stationName = ParseTerm(station);
                List<char> temp = ShareLetters(stationName, name);
                if (temp.Count == 0)
                {
                    Console.WriteLine($"-{stationName}");
                }
            }
        }
    }

    public static void Question4()
    {
        List<string> stations = Utils.FileToList("stations.txt");
        foreach (string station in stations)
        {
            string stationName = ParseTerm(station);
            string[] temp = stationName.Split(" ");
            if (temp.Length == 2)
            {
                Console.WriteLine(stationName);
            }
        }
    }
    
    private static string ParseTerm(string input, int index = 0)
    {
        string[] inputTerms = input.Split(", ");
        return inputTerms[index]; // by default returns the first term, i.e. station name
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

    // Looks to see if the substring shares letters with the reference string, returns the shared characters
    private static List<char> ShareLetters(string subString, string refString)
    {
        refString = refString.ToLower();
        subString = subString.ToLower();
        
        char[] letters = subString.ToCharArray();
        List<char> shareLetters = [];
        
        foreach (char character in letters)
        {
            if (refString.Contains(character))
            {
                shareLetters.Add(character);
            }
        }
        
        return shareLetters;
    }

    public static void RunTest()
    {
        string testBaseString = "Mackerel";
        Debug.Assert(ShareLetters(testBaseString, "Mackerel").Count == 8);
        Debug.Assert(ShareLetters(testBaseString, "Kernel").Count == 5);
        Debug.Assert(ShareLetters(testBaseString, "Real").Count == 4);
    }

    public static void RunTest2()
    {
        string testBaseString = "Abbey Road, Docklands Light Railway";
        Console.WriteLine(ParseTerm(testBaseString));
    }
}