using System.Diagnostics;

namespace LCO2Day06;

// search screen looks like this:
// a[01] b[02] c[03] d[04] e[05]
// f[06] g[07] h[08] i[09] j[10]
// k[11] l[12] m[13] n[14] o[15]
// p[16] q[17] r[18] s[19] t[20]
// u[21] v[22] w[23] x[24] y[25]
// z[26] _[27] <[28]
// find number of key presses to type in string
public class Day06Task9Ext
{
    public static void Run()
    {
        Console.WriteLine(FindKeyPresses("az"));
        
    }

    public static void TestFunction()
    {
        Debug.Assert(FindDistance('a', 'e') == 4);
        Debug.Assert(FindDistance('e', 't') == 3);
        Debug.Assert(FindDistance('t', '<') == 4);
        Debug.Assert(FindKeyPresses("et") == 11);
    }

    private static int FindKeyPresses(string sentence)
    {
        if (sentence[0] != 'a')
            sentence = 'a' + sentence;
        sentence = sentence.ToLower() + '<'; // starts at a, ends at >
        
        char[] chars = sentence.ToCharArray();
        
        int result = 0;
        for (int i = 0; i < chars.Length - 1; i++)
        {
            result += FindDistance(chars[i], chars[i + 1]);
        }
        return result;
    }

    private static int FindDistance(char start, char end)
    {
        // to find distance between two characters, get int value of start
        // int value / 5, and % 5 gives the row and column,
        // then it becomes a vector from the start to the end

        if (start == end)
        {
            return 0;
        }
        
        int startValue = GetIntValue(start);
        int endValue = GetIntValue(end);
        
        int changeInX = Math.Abs((startValue % 5 + 1) - (endValue % 5 + 1));
        int changeInY = Math.Abs((startValue / 5 + 1) - (endValue / 5 + 1));
        
        int result = changeInX + changeInY;
        
        return result;
    }
    
    private static int GetIntValue(char c)
    {
        // search screen looks like this:
        // a[01] b[02] c[03] d[04] e[05]
        // f[06] g[07] h[08] i[09] j[10]
        // k[11] l[12] m[13] n[14] o[15]
        // p[16] q[17] r[18] s[19] t[20]
        // u[21] v[22] w[23] x[24] y[25]
        // z[26] _[27] <[28]
        int charValue = 0;
        switch (c)
        {
            case ' ':
            case '_':
                charValue = 27;
                break;
            case '<':
                charValue = 28;
                break;
            default:
                charValue = ((int)c - 96);
                break;
        }
        
        if (charValue is >= 1 and <= 30)
        {
            return charValue;
        }
        return -1;
    }

    private static int[] GetCoordinates(char c)
    {
        int charValue = GetIntValue(c);

        int row = charValue / 6 + 1;
        int col = charValue % 6;
        return [row, col];
    }

    public static void TestFunctions2()
    {
        Console.WriteLine(String.Join(", ", GetCoordinates('a')));
    }
}
