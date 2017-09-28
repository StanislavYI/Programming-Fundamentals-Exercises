using System;

class MagicLetter
{
    static void Main()
    {
        char first = Console.ReadLine()[0];
        char second = Console.ReadLine()[0];
        string third = Console.ReadLine();

        for (char a = first; a <= second; a++)
        {
            for (char b = first; b <= second; b++)
            {
                for (char c = first; c <= second; c++)
                {
                    string result = "" + a + b + c;

                    if (!result.Contains(third))
                    {
                        Console.Write(result + " ");
                    }
                }
            }
        }
    }
}
