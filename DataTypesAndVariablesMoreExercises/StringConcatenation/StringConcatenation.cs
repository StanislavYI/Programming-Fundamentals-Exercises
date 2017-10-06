using System;

class StringConcatenation
{
    static void Main()
    {
        char delimiter = char.Parse(Console.ReadLine());
        string oddOrEven = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        string result = "";
        string words = "";

        for (int i = 0; i < n; i++)
        {
            words = Console.ReadLine();

            if (i % 2 == 0 && oddOrEven == "odd")
            {
                result += words;
                result += delimiter;
            }
            else if (i % 2 != 0 && oddOrEven == "even")
            {
                result += words;
                result += delimiter;
            }
        }

        Console.WriteLine(result.Remove(result.Length - 1));
    }
}
