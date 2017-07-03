using System;

class Solution
{
    static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        numOfPathsToDest(n);
    }

    static void numOfPathsToDest(int n) // n == 5
    {
        var result = travel(0, 0, n);
        Console.WriteLine(result);
    }


    static int travel(int i, int j, int n)
    {
        if (i == n - 1 && j == n - 1)
        {
            return 1;
        }

        var count = 0;
        if (i >= j)
        {
            if (i < n - 1)
            {
                count += travel(i + 1, j, n);
            }

            if (j < n - 1)
            {
                count += travel(i, j + 1, n);
            }
        }
        return count;
    }
}