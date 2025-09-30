namespace LCO2Day02;

public class Day02Task9
{
    public static void Run()
    {
        int length = 3;
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            Console.Write("Please enter a number: ");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            numbers[i] = newNumber;
        }
        Console.WriteLine($"Largest value was {FindLargest(numbers)}");
    }

    public static int FindLargest(int[] numbers)
    {
        int largest = 0;
        for (int index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] > largest)
            {
                largest = numbers[index];
            }
        }
        return largest;
    }
}