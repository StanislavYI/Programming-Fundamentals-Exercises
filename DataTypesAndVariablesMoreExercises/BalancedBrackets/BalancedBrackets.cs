using System;
using System.Collections.Generic;

class BalancedBrackets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string inputLine = "";

        bool isBalanced = true;

        List<int> odds = new List<int>();
        List<int> evens = new List<int>();

        int count = 0;

        for (int i = 0; i < n; i++)
        {
            inputLine = Console.ReadLine().Trim();

            if (inputLine == "(")
            {
                evens.Add(count);
                count++;
            }
            else if (inputLine == ")")
            {
                odds.Add(count);
                count++;
            }
        }

        if (odds.Count == evens.Count)
        {
            for (int i = 0; i < odds.Count; i++)
            {
                if (odds[i] % 2 == 0)
                {
                    isBalanced = false;
                }
            }

            for (int i = 0; i < evens.Count; i++)
            {
                if (evens[i] % 2 != 0) 
                {
                    isBalanced = false;
                }
            }

            Console.WriteLine(isBalanced ? "BALANCED" : "UNBALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}
