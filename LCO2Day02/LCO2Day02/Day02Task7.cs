namespace LCO2Day02;

public class Day02Task7
{
    public static void Run()
    {
        int memoryUsed = 100;
        Console.WriteLine($"{memoryUsed} KiB of memory uses {CalcMemoryUsed(memoryUsed)} blocks");
    }

    public static int CalcMemoryUsed(int fileSize)
    {
        int numBlocks = 0;
        int newFileSize = fileSize * 1024; // KiB -> B
        
        numBlocks = newFileSize / 512;
        if (newFileSize % 512 != 0)
            numBlocks += 1;

        return numBlocks;
    }
}