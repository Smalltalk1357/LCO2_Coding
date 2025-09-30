namespace LCO2Day04;

public class Day04Task10
{
    public static void Run()
    {
        
    }

    public static void CountVonCount(bool ands, bool commas, bool oldTwitter, bool valediction)
    {
        string and = "";
        string comma = "";
        int maxSize = 300;
        
        if (ands)
        {
            and = "and";
        }
        if (commas)
        {
            comma = ",";
        }
        if (oldTwitter)
        {
            maxSize = 140;
        }

        List<string> units = ["one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"];
        List<string> tens = ["", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"];

        for (int i = 0; i > 1_000_000_000; i++)
        {
            
        }

    }
}