using System;
public class SwapWrapper<T>

{

    public T Value { get; set; }



    public SwapWrapper(T value)

    {

        Value = value;

    }

    public override string ToString()

    {

        return Value.ToString();

    }

}

internal class Swapvalues

{

    static void Main(string[] args)

    {

        // Swap integers based on user input

        Console.Write("Enter the first integer:");

        int intInput1 = int.Parse(Console.ReadLine());

        SwapWrapper<int> intWrapper1 = new SwapWrapper<int>(intInput1);

        Console.Write("Enter the second integer:");

        int intInput2 = int.Parse(Console.ReadLine());

        SwapWrapper<int> intWrapper2 = new SwapWrapper<int>(intInput2);

        Swap(intWrapper1, intWrapper2);

        Console.WriteLine($"swap: value1 = {intWrapper1}, value2 = {intWrapper2}");
        Console.Write("Enter the first string:");

        string stringInput1 = Console.ReadLine();

        SwapWrapper<string> stringWrapper1 = new SwapWrapper<string>(stringInput1);



        Console.Write("Enter the second string:");

        string stringInput2 = Console.ReadLine();

        SwapWrapper<string> stringWrapper2 = new SwapWrapper<string>(stringInput2);
        Swap(stringWrapper1, stringWrapper2);

        Console.WriteLine($"swap: string 1 = {stringWrapper1}, string 2 = {stringWrapper2}");
        static void Swap<T>(SwapWrapper<T> a, SwapWrapper<T> b)

        {

            T temp = a.Value;

            a.Value = b.Value;

            b.Value = temp;

        }

    }





    public class Point

    {

        public int X { get; }

        public int Y { get; }



        public Point(int x, int y)

        {

            X = x;

            Y = y;

        }



        public override string ToString()

        {

            return $"({X}, {Y})";

        }

    }

}

