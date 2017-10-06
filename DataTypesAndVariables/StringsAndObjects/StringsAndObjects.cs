using System;

class StringsAndObjects
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        object concat = first + " " + second;
        string third = (string)concat;

        Console.WriteLine(third);
    }
}
