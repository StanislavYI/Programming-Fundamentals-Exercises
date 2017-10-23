using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class SrubskoUnleashed
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, long>> output = new Dictionary<string, Dictionary<string, long>>();

        while (input != "End")
        {
            Regex regex = new Regex(@"(.+) @([\w+\s*\w+]+) (\d+) (\d+)");

            string singer = "";
            string venue = "";
            long ticketsPrice = 0;
            long ticketsCount = 0;

            Match match = regex.Match(input);

            if (match.Success)
            {
                singer = match.Groups[1].ToString();
                venue = match.Groups[2].ToString();
                ticketsPrice = long.Parse(match.Groups[3].ToString());
                ticketsCount = long.Parse(match.Groups[4].ToString());
            }
            else
            {
                input = Console.ReadLine();
                continue;
            }

            if (!output.ContainsKey(venue))
            {
                output.Add(venue, new Dictionary<string, long>());
            }

            if (!output[venue].ContainsKey(singer))
            {
                output[venue].Add(singer, 0);
            }

            output[venue][singer] += (ticketsCount * ticketsPrice);

            input = Console.ReadLine();
        }

        foreach (var item in output)
        {
            Console.WriteLine(item.Key);

            var sorted = item.Value.OrderByDescending(x => x.Value);

            foreach (var secondItem in sorted)
            {
                Console.WriteLine("#  " + secondItem.Key + " -> " + secondItem.Value);
            }
        }
    }
}
