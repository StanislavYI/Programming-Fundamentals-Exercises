using System;
using System.Collections.Generic;

class DragonArmy
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, SortedDictionary<string, List<double>>> output = new Dictionary<string, SortedDictionary<string, List<double>>>();

        for (int i = 0; i < n; i++)
        {
            string[] dragonData = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string type = dragonData[0];
            string name = dragonData[1];
            double damage = 0d;
            double health = 0d;
            double armor = 0d;

            CheckForNullElseReturnInput(dragonData, out damage, out health, out armor);

            if (!output.ContainsKey(type))
            {
                output.Add(type, new SortedDictionary<string, List<double>>());
            }

            if (!output[type].ContainsKey(name))
            {
                output[type].Add(name, new List<double>());
            }

            if (output.ContainsKey(type) && output[type].ContainsKey(name))
            {
                output[type][name] = new List<double>();
            }

            output[type][name].AddRange(new List<double> { damage, health, armor });

        }

        foreach (var item in output)
        {
            Console.Write(item.Key + "::");
            Console.WriteLine("({0:0.00}/{1:0.00}/{2:0.00})", ReturnAverage(item.Value, 0), ReturnAverage(item.Value, 1),
                ReturnAverage(item.Value, 2));
            
            foreach (var secondItem in item.Value)
            {
                Console.Write("-" + secondItem.Key + " -> ");
                Console.WriteLine($"damage: {secondItem.Value[0]}, health: {secondItem.Value[1]}, armor: {secondItem.Value[2]}");
            }
        }
    }

    private static double ReturnAverage(SortedDictionary<string, List<double>> dict, int num)
    {
        double averageSum = 0;

        foreach (var item in dict)
        {
            averageSum += item.Value[num];
        }

        averageSum /= dict.Count;

        return averageSum;
    }
    private static void CheckForNullElseReturnInput(string[] dragonData, out double damage, out double health, out double armor)
    {
        if (dragonData[2] == "null")
        {
            damage = 45;
        }
        else
        {
            damage = double.Parse(dragonData[2]);
        }

        if (dragonData[3] == "null")
        {
            health = 250;
        }
        else
        {
            health = double.Parse(dragonData[3]);
        }

        if (dragonData[4] == "null")
        {
            armor = 10;
        }
        else
        {
            armor = double.Parse(dragonData[4]);
        }
    }
}
