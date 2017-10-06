using System;

class BooleanVariable
{
    static void Main()
    {
        string input = Console.ReadLine();

        bool output = input == "True" ? true : false;

        Console.WriteLine(output == true ? "Yes" : "No");
    }
}
