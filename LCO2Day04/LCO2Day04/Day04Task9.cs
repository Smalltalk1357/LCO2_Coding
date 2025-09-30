namespace LCO2Day04;

public class Day04Task9
{
    public static void Run()
    {
        Console.Write("Enter a top range: ");
        int top = int.Parse(Console.ReadLine());
        Console.Write("Enter a bottom range: ");
        int bottom = int.Parse(Console.ReadLine());
        
        int counter = 0;
        
        Console.Write($"Think of a number between {bottom}-{top}, press enter once done.");
        Console.ReadLine();
        
        while (true)
        {
            if (top == bottom)
            {
                Console.WriteLine($"Your number must be {top}");
                Console.WriteLine($"Your number was found in {counter} guesses. ");
                Console.WriteLine($"Predicted number of guesses: {(int)(Math.Log(2, top - bottom)) + 1}");
                return;
            }
            
            int computerGuess = BinarySearchIndex(bottom, top);
            Console.WriteLine($"Computer guessed {computerGuess}");
            
            Console.Write("Was your number higher [1], lower [2] or the same [3] as this value: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    bottom = computerGuess + 1;
                    break;
                case "2":
                    top = computerGuess - 1;
                    break;
                case "3":
                    Console.WriteLine($"Your number is {computerGuess}, found in {counter} guesses. ");
                    Console.WriteLine($"Predicted number of guesses: {(int)(Math.Log(top - bottom)) + 1}");
                    return;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            counter += 1;
        }
    }

    private static int BinarySearchIndex(int lowerRange, int upperRange)
    {
        int result = (int)((lowerRange + upperRange)/2);
        return result;
    }
}