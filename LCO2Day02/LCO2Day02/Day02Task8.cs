namespace LCO2Day02;

public class Day02Task8
{
    public static void Run()
    {
        Console.Write("Enter income per week: ");
        float moneyPerWeek = Convert.ToSingle(Console.ReadLine());
        Console.Write("Enter percent to save: ");
        float percent = Convert.ToSingle(Console.ReadLine());
        CalcSavings(moneyPerWeek, percent);
    }

    public static void CalcSavings(float amountPerWeek, float percent)
    {
        percent = percent / 100;
        float savingsPerWeek = amountPerWeek * percent;
        float savingsPerYear = savingsPerWeek * 52;
        
        Console.WriteLine($"Savings per week: {savingsPerWeek, 2:C2}");
        Console.WriteLine($"Savings per year: {savingsPerYear, 2:C2}");
    }
}