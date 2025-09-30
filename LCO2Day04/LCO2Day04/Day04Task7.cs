namespace LCO2Day04;

public class Day04Task7
{
    public static void Run()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is {n} prime? {IsPrime(n)}");
        Console.WriteLine($"Is {n} perfect? {IsPerfect2(n)}");
        Console.WriteLine($"Is {n} abundant? {IsAbundant(n)}");
        Console.Write("Enter another integer: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is {n} friendly to {p}? {IsFriendly(n, p)}");
    }

    public static bool IsPrime(int n)
    {
        if (n < 0)
        {
            return false;
        }
        List<int> factors = GetFactors(n);
        if (factors.Count == 0)
        {
            return true;
        }
        return false;
    }

    public static bool IsPerfect(int n)
    {
        // only 5 perfect numbers can fit into int values :)
        
        switch (n)
        {
            case 6:
            case 28:
            case 496:
            case 8128:
            case 33550336:
                return true;
            default:
                return false;
        }
    }

    public static bool IsPerfect2(int n)
    {
        List<int> factors = GetFactors(n);

        if (factors.Sum() == n)
        {
            return true;
        }
        return false;   
    }
    
    public static bool IsAbundant(int n)
    {
        List<int> factors = GetFactors(n);
        
        if (factors.Sum() > n)
        {
            return true;
        }
        return false;
    }

    public static bool IsFriendly(int n, int p)
    {
        List<int> factorsN = GetFactors(n);
        List<int> factorsP = GetFactors(p);
        
        double abundancyIndexN = factorsN.Sum() / (double)n;
        double abundancyIndexP = factorsP.Sum() / (double)p;

        if (abundancyIndexN == abundancyIndexP)
        {
            return true;
        }
        return false;
    }
    
    private static List<int> GetFactors(int n)
    {
        // note that n is not counted as a factor

        List<int> factors = [];

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                factors.Add(i);
            }
        }
        
        return factors;
    }
}