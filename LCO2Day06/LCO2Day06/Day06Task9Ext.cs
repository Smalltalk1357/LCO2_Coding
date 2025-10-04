using System.Diagnostics;

namespace LCO2Day06;

// search screen looks like this:
// a[00] b[01] c[02] d[03] e[04]
// f[05] g[06] h[07] i[08] j[09]
// k[10] l[11] m[12] n[13] o[14]
// p[15] q[16] r[17] s[18] t[19]
// u[20] v[21] w[22] x[23] y[24]
// z[25] _[26] <[27]
// find number of key presses to type in string + spaces + select key

public class Day06Task9Ext
{
    public static void Run()
    {
        Console.WriteLine(FindKeyPresses("War and Peace"));
    }

    public static void TestFunction()
    {
        Debug.Assert(FindDistance('a', 'e') == 4);
        Debug.Assert(FindDistance('e', 't') == 3);
        Debug.Assert(FindDistance('t', '<') == 4);
        Debug.Assert(FindKeyPresses("et") == 14);
    }

    private static int FindKeyPresses(string sentence)
    {
        // starts at a, so add a if first char is not a
        if (sentence[0] != 'a')
            sentence = 'a' + sentence;
        // always ends on <, adds it to end of sentence
        sentence = sentence.ToLower() + '<';

        char[] chars = sentence.ToCharArray();
        
        int result = 0;
        for (int i = 0; i < chars.Length - 1; i++)
        {
            result += FindDistance(chars[i], chars[i + 1]);
            result ++; // add 1 for the select key
        }
        return result;
    }

    private static int FindDistance(char start, char end)
    {
        // to find distance between two characters, get int value of start & end
        // int division and modulo gives row and column of each
        // then add the difference between the two together to get the distance
        
        if (start == end)
        {
            return 0;
        }
        
        int[] startCoords = GetRowCol(start);
        int[] endCoords = GetRowCol(end);
        
        int changeInX = Math.Abs(startCoords[0] - endCoords[0]);
        int changeInY = Math.Abs(startCoords[1] - endCoords[1]);
        
        int result = changeInX + changeInY;
        
        return result;
    }
    
    private static int GetIntValue(char c)
    {
        // search screen looks like this:
        // a[00] b[01] c[02] d[03] e[04]
        // f[05] g[06] h[07] i[08] j[09]
        // k[10] l[11] m[12] n[13] o[14]
        // p[15] q[16] r[17] s[18] t[19]
        // u[20] v[21] w[22] x[23] y[24]
        // z[25] _[26] <[27]
        int charValue = 0;
        switch (c)
        {
            case ' ':
            case '_':
                charValue = 26; // value assigned above
                break;
            case '<':
                charValue = 27;
                break;
            default:
                // a = 97 in ascii, so sets codepoints to start at 0
                charValue = (int)c - 97;
                break;
        }
        
        // if (charValue is >= 0 and <= 30)
        // {
        //     return charValue;
        // }
        // return -1;
        
        return charValue;
    }

    private static int[] GetRowCol(char c)
    {
        int charValue = GetIntValue(c);

        int row = charValue / 5; // gets row using int division
        int col = charValue % 5; // gets column using remainder
        return [row, col];
    }
}
