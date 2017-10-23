using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, string> output = new Dictionary<string, string>();

        while (input != "END")
        {
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
