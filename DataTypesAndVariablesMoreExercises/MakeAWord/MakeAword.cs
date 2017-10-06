using System;
using System.Text;

class MakeAword
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //StringBuilder result = new StringBuilder();
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result += char.Parse(Console.ReadLine()); ;
        }

        Console.WriteLine($"The word is: {result}");
    }
}
