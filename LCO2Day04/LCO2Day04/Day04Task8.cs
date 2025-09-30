namespace LCO2Day04;
// https://www.olympiad.org.uk/papers/2003/bio/bio03ex.pdf
// For part b, 3540678654 is the correct answer

public class Day04Task8
{
    public static void Run()
    {
        string  isbn = "3540678654";
        if (CheckSum(isbn))
        {
            Console.WriteLine("Valid ISBN");
        }
        else
        {
            char result = CalcMissingCheckSum(isbn);
            if (result != ' ')
            {
                Console.WriteLine($"Missing digit of [{isbn}] should be [{result}]");
            }
        }
    }

    private static bool CheckSum(string input)
    {
        if (input.Length != 10)
        {
            return false;
        }

        char lastDigit = char.ToLower(input[9]);
        int total = 0;
        
        for (int index = 0; index < input.Length - 1; index++)
        {
            if (int.TryParse(input[index].ToString(), out int tempNum))
            {
                total += tempNum * (10 - index);
            }
        }
        
        if (lastDigit == 'x')
        {
            total += 10;
        }
        else
        {
            if (int.TryParse(lastDigit.ToString(), out int tempNum))
            {
                total += tempNum;
            }
        }

        if (total % 11 == 0)
        {
            return true;
        }
        return false;
    }

    private static char CalcMissingCheckSum(string input)
    {
        // reads in input
        // checks location of ?
        // splits input into two parts based on ?
        // substitutes all possible values into the location
        
        int length = input.Length;
        int position = input.IndexOf('?');
        
        if (length == 10 && position >= 0)
        {
            string header = input.Substring(0, position);
            string footer = input.Substring(position + 1, length - position - 1);

            for (int i = 0; i < 10; i++)
            {
                string temp = header + i + footer;
                
                if (CheckSum(temp))
                {
                    return Convert.ToChar(i.ToString());
                }

                if (i == 9)
                {
                    temp = header + 'X' + footer;
                    if (CheckSum(temp))
                    {
                        return 'X';
                    }
                }
            }
        }
        
        Console.WriteLine("Invalid ISBN");
        return ' ';
    }
}