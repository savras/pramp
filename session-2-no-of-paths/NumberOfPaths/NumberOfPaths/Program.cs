using System;

class Solution
{
    static void Main(string[] args)
    {
        var n = Convert.ToInt32(Console.ReadLine());
        //numOfPathsToDest(n);
        numOfPathsToDestDp(n);
    }

    static void numOfPathsToDestDp(int n)
    {
        var dpArr = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            dpArr[0, i] = 1;
        }

        for (var i = 1; i < n; i++)
        {
            for (var j = i; j < n; j++)
            {
                dpArr[i, j] = dpArr[i - 1, j] + dpArr[i, j - 1];
            }
        }

        Console.WriteLine(dpArr[n - 1, n - 1]);
    }

    static void numOfPathsToDest(int n) // Test: n == 5
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