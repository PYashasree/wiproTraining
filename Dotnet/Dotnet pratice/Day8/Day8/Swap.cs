using System;
class Swap
{
    static void Main(string[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine($"Before swapping:a={a},b={b}");
        a = a ^ b;
        b=a^ b; 
        a= a ^ b;
        Console.WriteLine($"After swapping: a={a},b={b}");
}
}