namespace LCO2Day06;

// Variable Name helper
public class Day06Task7
{
    public static void Run()
    {
        Console.WriteLine(VariableNameHelper("Hello World", "snake_case"));
    }

    private static string VariableNameHelper(string input, string format)
    {
        string output = "";
        switch (format)
        {
            case "camelCase": // capitalise the first letter of every word after the first, no spaces
                string[] words = input.Split(' ');
                
                break;
            
            case "PascalCase": // capitalise the first letter of every word, no spaces 
                PascalCase(input);
                break;
            
            case "snake_case": // every word is separated by an underscore
                string result = "";
                foreach (string word in input.Split(' '))
                {
                    result += word.ToLower();
                    result += "_";
                }
                output = result.TrimEnd('_');
                break;
            
            default:
                throw new Exception("VariableNameHelper: Invalid string format, can only be camelCase, PascalCase or snake_case");
        }
        
        return output;
    }

    private static void CapitaliseWords(ref string input)
    {
        string firstChar = input[0].ToString().ToUpper();
        // input = input.Remove(0, 1);
        
        input = firstChar + input.Substring(1).ToLower();
    }
    
    private static string PascalCase(string input)
    {
        string output = "";
        
        foreach (string word in input.Split(' '))
        {
            string temp = word;
            CapitaliseWords(ref temp);
            output += temp;
        }
        
        return output;
    }
}