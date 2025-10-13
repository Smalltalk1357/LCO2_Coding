using System.Reflection;

namespace LCO2Day08;

public class BitwiseFunctions
{
    public static void Run()
    {
        Console.WriteLine(FindSignificantBit("1010", 3));
    }

    private static string FindSignificantBit(string binaryNumber, int index = 1, bool lsb = false)
    {
        List<char> bits = binaryNumber.ToList();
        string result = "";

        switch (lsb)
        {
            case false: // most significant bit
                for (int i = 0; i < index; i++)
                {
                    result += bits[i];
                }
                break;
            case true: // least significant bit
                for (int i = 0; i < index; i++)
                {
                    result += bits[(bits.Count - 1) - i];
                }
                break;
        }
        return result;
    }

    private static void RemoveBit(string binaryNumber, int length, bool lsb = false)
    {
        int stringLength = binaryNumber.Length;
        int index = lsb ? stringLength - length : length;
        binaryNumber.Substring();
    }
}
