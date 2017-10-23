using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUpgrade
{
    static void Main()
    {
        string input = Console.ReadLine();

        SortedDictionary<string, string> output = new SortedDictionary<string, string>();

        while (input != "END")
        {
            if (input == "ListAll")
            {
                foreach (var item in output)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }

                input = Console.ReadLine();
                continue;
            }

            string[] data = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstLetter = data[0];
            string name = data[1];
            string number = "";

            if (firstLetter == "A")
            {
                number = data[2];

                if (!output.ContainsKey(name))
                {
                    output.Add(name, "");
                }

                output[name] = number;
            }

            if (firstLetter == "S")
            {
                Console.WriteLine(output.ContainsKey(name) ? $"{name} -> {output[name]}" :
                    $"Contact {name} does not exist.");
            }

            input = Console.ReadLine();
        }
    }
}