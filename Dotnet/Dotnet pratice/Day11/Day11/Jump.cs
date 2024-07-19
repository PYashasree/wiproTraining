using System;
public class JumpSearch

{
    public static int Square(int n)

    {

        if (n <= 1)

            return n;
        int x = n;

        int y = (x + 1) / 2;

        while (y < x)

        {
            x = y;

            y = (x + n / x) / 2;

        }
        return x;

    }
    public static int Min(int a, int b)

    {

        if (a < b)

            return a;

        else

            return b;

    }
    public static int Jump(int[] array, int target)

    {

        int n = array.Length;

        int jumpSize = Square(n);

        int left = 0;

        int right = 0;



        while (right < n && array[right] < target)

        {

            left = right;

            right = Min(n - 1, right + jumpSize);

        }

        for (int i = left; i <= Min(right, n - 1); i++)

        {

            if (array[i] == target)

                return i;

        }

        return -1;

    }
public static void main()

    {

        int[] sortedArray = { 10, 50, 90, 40, 30, 20, 80, 70 };
       Array.Sort(sortedArray);
        int target = 20;
        int index = Jump(sortedArray, target);



        if (index != -1)

            Console.WriteLine($"Element {target} found at index {index}");

        else

            Console.WriteLine($"Element {target} not found in the array");

    }

}

