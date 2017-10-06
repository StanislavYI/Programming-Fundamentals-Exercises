using System;
using System.Collections.Generic;

class VarInHexFormat
{
    static void Main()
    {
        string hex = Console.ReadLine().Substring(2);

        Dictionary<string, int> hexValues = new Dictionary<string, int>();
        hexValues.Add("0", 0);
        hexValues.Add("1", 1);
        hexValues.Add("2", 2);
        hexValues.Add("3", 3);
        hexValues.Add("4", 4);
        hexValues.Add("5", 5);
        hexValues.Add("6", 6);
        hexValues.Add("7", 7);
        hexValues.Add("8", 8);
        hexValues.Add("9", 9);
        hexValues.Add("A", 10);
        hexValues.Add("B", 11);
        hexValues.Add("C", 12);
        hexValues.Add("D", 13);
        hexValues.Add("E", 14);
        hexValues.Add("F", 15);

        double result = 0;
        int num = 0;
        double reversed = hex.Length - 1;

        for (int i = 0; i < hex.Length; i++)
        {
            num = hexValues[hex[i].ToString()];

            result += num * Math.Pow(16d, reversed);

            reversed--;
        }

        Console.WriteLine(result);
    }
}
