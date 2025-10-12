using System.Diagnostics;

namespace LCO2Day07;

// Questions for stations.txt
public class Day07Task2
{
    // Q2: Battersea Power Station
    // Q3a: St. John's Wood
    // Q3b: Stockwell
    // Q3c: Balham
    // Q3d: None
    // Q4: 5 stations: Charing Cross, Clapham Common, Golders Green, Seven Sisters, Sloane Square
    // Q5: District Line has the most, with 60 stations
    
    // Main Functions
    
    public static void Question2()
    {
        // Which is the only station with the word "station" in its name?"
        List<string> stations = Utils.FileToList("stations.txt");
        List<string> output = SearchForTerm("Station", stations);
        Console.WriteLine(string.Join(", ", output));
    }
    
    public static void Question3()
    {
        // Which tube stations share no letters with the following words:
        string[] checkNames = ["Mackerel", "Piranha", "Sturgeon", "Bacteria"];

        List<string> stations = Utils.FileToList("stations.txt");
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
        // Which tube stations are formed of two words, each beginning with the same letter?
        List<string> stations = Utils.FileToList("stations.txt");

        int total = 0;
        foreach (string station in stations)
        {
            string stationName = ParseTerm(station);
            string[] temp = stationName.Split(" ");
            if (temp.Length != 2) continue;
            if ((temp[0])[0] != (temp[1])[0]) continue;
            Console.WriteLine(stationName);
            total++;
        }
        
        Console.WriteLine($"Number of stations that fit condition: {total}");
    }

    public static void Question5()
    {
        // What tube line has the most stations?
        List<string> stations = Utils.FileToList("stations.txt");
        
        Dictionary<string, int> tubeLines = new Dictionary<string, int>();
        
        foreach (string station in stations)
        {
            List<string> lines = station.Split(", ").ToList();
            lines.RemoveAt(0);

            foreach (string line in lines)
            {
                if (tubeLines.ContainsKey(line))
                {
                    tubeLines[line]++;
                }
                else
                {
                    tubeLines.Add(line, 1);
                }
            }
        }

        int maxStations = 0;
        string maxLine = "";
        foreach (KeyValuePair<string, int> line in tubeLines)
        {
            if (line.Value > maxStations)
            {
                maxStations = line.Value;
                maxLine = line.Key;
            }
        }
        Console.WriteLine($"Line with most stations: {maxLine}, with {maxStations} stations");
    }
    
    // Helper functions
    
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

    private static List<char> ShareLetters(string subString, string refString)
    {
        // Looks to see if the substring shares letters with the reference string, returns the shared characters

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

    // Test cases
    
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
