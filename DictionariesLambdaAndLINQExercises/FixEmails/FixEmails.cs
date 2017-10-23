using System;
using System.Collections.Generic;

class FixEmails
{
    static void Main()
    {
        Dictionary<string, string> output = new Dictionary<string, string>();

        string name = Console.ReadLine();
        string email = Console.ReadLine();

        while (name != "stop" && email != "stop")
        {
            string lastTwoLetters = email.Substring(email.Length - 2, 2);

            if (lastTwoLetters != "uk" && lastTwoLetters != "us" &&
                !output.ContainsKey(name))
            {
                output.Add(name, email);
            }

            name = Console.ReadLine();
            if (name == "stop") { break; }
            email = Console.ReadLine();
            if (email == "stop") { break; }
        }

        foreach (var item in output)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
