using System;

class CountTheIntegers
{
    static void Main()
    {
        string input = Console.ReadLine();

        int num = 0;
        int count = 0;

        while (int.TryParse(input, out num))
        {
            count++;

            input = Console.ReadLine();
        }

        Console.WriteLine(count);
    }
}