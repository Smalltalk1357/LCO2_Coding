namespace LCO2Day02;

public class Day02Task6
{
    public static void Run()
    {
        char c = 'b';
        switch (IsVowel(c))
        {
            case true:
                Console.WriteLine($"{c} is a vowel");
                break;
            case false:
                Console.WriteLine($"{c} is a consonant");
                break;
        }
    }
    
    public static bool IsVowel(char letter)
    {
        switch (letter)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}