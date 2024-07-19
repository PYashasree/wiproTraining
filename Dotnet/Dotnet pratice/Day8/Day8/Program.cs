using System;
 class Program
{
    static int CountSetBits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count = count + n & 1;
            n >>= 1;

        }
        return count;
    }
    static int CountTotalSetBitsWithArray(int n)
    {
        int[] countSetBits = new int[n + 1];
        countSetBits[0] = 0;
        for (int i = 1; i < n; i++)
        {
            countSetBits[i] = countSetBits[i >> 1] + (i & 1);
        }
        int totalSetsBits = 0;
        for (int i = 1; i < n; i++)
        {
            totalSetsBits += countSetBits[i];

        }
        return totalSetsBits;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the values");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" set bit count from 1 to {n} is {CountTotalSetBitsWithArray(n)}");
    }
}