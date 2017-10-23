using System;
using System.Collections.Generic;

class MinerTask
{
    static void Main()
    {
        string input = Console.ReadLine();

        int i = 0;

        Dictionary<string, long> output = new Dictionary<string, long>();

        string resource = "";
        long quantity = 0;

        while (input != "stop")
        {
            if (i % 2 == 0)
            {
                resource = input;
            }
            else
            {
                quantity = long.Parse(input);

                if (!output.ContainsKey(resource))
                {
                    output.Add(resource, 0);
                }

                output[resource] += quantity;
            }

            input = Console.ReadLine();
            i++;
        }

        foreach (var item in output)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
