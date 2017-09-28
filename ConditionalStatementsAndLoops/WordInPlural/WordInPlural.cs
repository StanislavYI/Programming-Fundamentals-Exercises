using System;

class WordInPlural
{
    static void Main()
    {
        string input = Console.ReadLine();

        string result = "";

        string[] letters = { "o", "ch", "s", "sh", "x", "z" };

        for (int i = 0; i < letters.Length; i++)
        {
            if (input.EndsWith(letters[i]))
            {
                result = input;
                result += "es";
            }
        }

        if (input.EndsWith("y"))
        {
            result = input.Substring(0, input.Length - 1);
            result += "ies";
        }
        else if (!result.EndsWith("es"))
        {
            result = input;
            result += "s";
        }

        Console.WriteLine(result);
    }
}