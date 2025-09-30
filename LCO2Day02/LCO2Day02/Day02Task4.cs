namespace LCO2Day02;

public class Day02Task4
{
    public static void Run()
    {
        while (true)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FizzBuzz(number));
        }
    }

    public static string FizzBuzz(int number)
    {
        string result = "";

        if (number % 3 == 0)
        {
            result += "Fizz";
        }
        if (number % 5 == 0)
        {
            result += "Buzz";
        }

        if (result.Length == 0)
        {
            result = number.ToString();
        }
        
        return result;
    }
}