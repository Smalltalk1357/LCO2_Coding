using System.Diagnostics;

namespace LCO2Day03;

// return a string that has the binary or hex representations of the input value as a string, pass this in as an integer parameter
public class Day03Task6
{
    public static void Run()
    {
        int input = 1509;
        Console.WriteLine($"\"{input}\" in binary is {Translate(input, 2)}");
        Console.WriteLine($"\"{input}\" in hex is {Translate(input, 16)}");
    }

    public static string Translate(int input, int baseType)
    {
        string output = "";
        string temp;
        switch (baseType)
        {
            case 2:
                temp = Convert.ToString(input, 2);
                while (temp.Length % 4 != 0) temp = "0" + temp;
                output = "0b" + temp;
                break;

            case 16:
                temp = Convert.ToString(input, 16).ToUpper();
                while (temp.Length % 4 != 0) temp = "0" + temp;
                output = "0x" + temp;
                break;

            default:
                output = "0d" + Convert.ToString(input);
                break;
        }

        return output;
    }

    public static void RunTest()
    {
        Debug.Assert(Translate(84, 2) == "0b01010100", "Error - 84,2");
        Debug.Assert(Translate(84, 16) == "0x0054", "Error - 84,16");
        Debug.Assert(Translate(84, 10) == "0d84", "Error - 84,10");
        // Debug.Assert(Translate(0, 0) == "", "Task Failed Successfully :)");
    }
}