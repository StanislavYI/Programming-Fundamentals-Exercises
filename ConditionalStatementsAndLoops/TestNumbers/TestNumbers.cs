using System;

class TestNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int sumBoundary = int.Parse(Console.ReadLine());

        int totalSum = 0;
        int combinations = 0;

        for (int a = n; a >= 1; a--)
        {
            for (int b = 1; b <= m; b++)
            {
                totalSum = (a * b) * 3 + totalSum;
                combinations++;

                if (totalSum >= sumBoundary)
                {
                    break;
                }
            }
            if (totalSum >= sumBoundary)
            {
                break;
            }
        }

        if (totalSum >= sumBoundary)
        {
            Console.WriteLine("{0} combinations", combinations);
            Console.WriteLine("Sum: {0} >= {1}", totalSum, sumBoundary);
        }
        else if (totalSum < sumBoundary)
        {
            Console.WriteLine("{0} combinations", combinations);
            Console.WriteLine("Sum: {0}", totalSum);
        }
    }
}