using System;
using System.Collections.Generic;
using System.Linq;

class LogsAggregator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string data = Console.ReadLine();

        SortedDictionary<string, int> outerDict = new SortedDictionary<string, int>();
        Dictionary<string, List<string>> innerDict = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string[] lines = data.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string user = lines[1];
            string IP = lines[0];
            int duration = int.Parse(lines[2]);

            if (!outerDict.ContainsKey(user))
            {
                outerDict.Add(user, 0);
                innerDict.Add(user, new List<string>());
            }

            outerDict[user] += duration;

            if (!innerDict[user].Contains(IP))
            {
                innerDict[user].Add(IP);
            }

            data = Console.ReadLine();
        }

        foreach (var item in outerDict)
        {
            innerDict[item.Key] = innerDict[item.Key].OrderBy(x => x).ToList();
            Console.WriteLine(item.Key + ": " + item.Value + " [" + String.Join(", ", innerDict[item.Key]) + "]");
        }
    }
}
