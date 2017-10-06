using System;

class DecryptingMessages
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string output = "";
        char ch = ' ';

        for (int i = 0; i < n; i++)
        {
            ch = char.Parse(Console.ReadLine());

            output += (char)(ch + key);
        }

        Console.WriteLine(output);
    }
}
