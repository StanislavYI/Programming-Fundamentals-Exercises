using System;

class SumOfChars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int charSum = 0;

        for (int i = 0; i < n; i++)
        {
            charSum += char.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The sum equals: {charSum}");
    }
}
