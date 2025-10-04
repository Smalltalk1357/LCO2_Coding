namespace LCO2Day06;

// search screen looks like this:
// a b c d e
// f g h i j
// k l m n o
// p q r s t
// u v w x y
// z _ >
// find number of key presses to type in string
public class Day06Task9Ext
{
    public static void Run()
    {
        Console.WriteLine(GetIntValue('_'));
    }

    private static void FindKeyPresses(string word)
    {
        
    }
    
    private static int FindDistance(char start, char end)
    {
        // to find distance between two characters, get int value of start
        // int value // 5 and % 5 gives the row and column
        // then it becomes a vector from the start to the end

        int result = 0;
        
        
        
        return result;
    }
    
    private static int GetIntValue(char c)
    {
        switch (c)
        {
            case ' ':
            case '_':
                return 29;
            case '<':
                return 30;
            default:
                return (int)c - 96;
        }
        
    }
    
}