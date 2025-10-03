namespace LCO2Day06;

// Variable Name helper
public class Day06Task7
{
    public static void Run()
    {
        Console.WriteLine(VariableNameHelper("Just a very long variable name", "camelCase"));
        Console.WriteLine(VariableNameHelper("Just a very long variable name", "PascalCase"));
        Console.WriteLine(VariableNameHelper("Just a very long variable name", "snake_case"));
    }

    private static string VariableNameHelper(string input, string format)
    {
        string output = "";
        switch (format)
        {
            case "camelCase": // capitalise the first letter of every word after the first, no spaces
                string LHS = input.Split(' ')[0];
                string RHS = input.Substring(LHS.Length + 1); // needs to get rid of space
                output += LHS.ToLower();
                output += PascalCase(RHS);
                break;
            
            case "PascalCase": // capitalise the first letter of every word, no spaces 
                output = PascalCase(input);
                break;
            
            case "snake_case": // every word is separated by an underscore
                foreach (string word in input.Split(' '))
                {
                    output += word.ToLower();
                    output += "_";
                }
                output = output.TrimEnd('_');
                break;
            
            default:
                throw new Exception("VariableNameHelper: Invalid string format, can only be camelCase, PascalCase or snake_case");
        }
        
        return output;
    }

    private static string CapitaliseWords(string input)
    {
        string firstChar = input[0].ToString().ToUpper();
        // input = input.Remove(0, 1);
        
        input = firstChar + input.Substring(1).ToLower();
        return input;
    }
    
    private static string PascalCase(string input)
    {
        string output = "";
        
        foreach (string word in input.Split(' '))
        {
            output += CapitaliseWords(word);
        }
        
        return output;
    }
}