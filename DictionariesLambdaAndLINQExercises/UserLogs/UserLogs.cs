using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

class UserLogs
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, int>> output = new Dictionary<string, Dictionary<string, int>>();

        while (input != "end")
        {
            Regex regex = new Regex(@"IP=(.*) message='(.*)' user=(.*)");
            Match match = regex.Match(input);

            string IP = "";
            string message = "";
            string user = "";

            if (match.Success)
            {
                IP = match.Groups[1].ToString();
                message = match.Groups[2].ToString();
                user = match.Groups[3].ToString();
            }

            if (!output.ContainsKey(user))
            {
                output.Add(user, new Dictionary<string, int>());
            }

            if (!output[user].ContainsKey(IP))
            {
                output[user].Add(IP, 0);
            }
            output[user][IP]++;

            input = Console.ReadLine();
        }

        var sortedOutput = output.OrderBy(x => x.Key);

        foreach (var item in sortedOutput)
        {
            Console.WriteLine(item.Key + ":");

            StringBuilder builder = new StringBuilder();

            foreach (var secondItem in item.Value)
            {
                builder.Append(secondItem.Key + " => " + secondItem.Value + ", ");
            }

            string endResult = builder.ToString().Substring(0, builder.ToString().Length - 2) + ".";

            Console.WriteLine(endResult);
        }
    }
}
