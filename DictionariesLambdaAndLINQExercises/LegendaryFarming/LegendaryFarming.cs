using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main()
    {
        string lines = Console.ReadLine();

        Dictionary<string, int> legendary = new Dictionary<string, int>();
        legendary.Add("Shadowmourne", 0);
        legendary.Add("Valanyr", 0);
        legendary.Add("Dragonwrath", 0);

        Dictionary<string, int> remainingMaterials = new Dictionary<string, int>();
        remainingMaterials.Add("fragments", 0);
        remainingMaterials.Add("motes", 0);
        remainingMaterials.Add("shards", 0);

        Dictionary<string, int> junk = new Dictionary<string, int>();

        int quantity = 0;
        string material = "";

        bool check = false;

        while (true)
        {
            string[] data = lines.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < data.Length; i++)
            {
                if (i % 2 == 0)
                {
                    quantity = int.Parse(data[i]);
                }
                else
                {
                    material = data[i].ToLower();
                }

                if (material == "shards" && i % 2 != 0)
                {
                    remainingMaterials["shards"] += quantity;
                    legendary["Shadowmourne"] += quantity;
                }
                else if (material == "fragments" && i % 2 != 0)
                {
                    remainingMaterials["fragments"] += quantity;
                    legendary["Valanyr"] += quantity;
                }
                else if (material == "motes" && i % 2 != 0)
                {
                    remainingMaterials["motes"] += quantity;
                    legendary["Dragonwrath"] += quantity;
                }
                else if (material != "" && i % 2 != 0)
                {
                    if (!junk.ContainsKey(material))
                    {
                        junk.Add(material, 0);
                    }
                    junk[material] += quantity;
                }

                if (legendary["Shadowmourne"] >= 250)
                {
                    remainingMaterials["shards"] -= 250;

                    Console.WriteLine("Shadowmourne obtained!");

                    Print(remainingMaterials, junk);

                    check = true;
                    break;
                }
                else if (legendary["Valanyr"] >= 250)
                {
                    remainingMaterials["fragments"] -= 250;

                    Console.WriteLine("Valanyr obtained!");

                    Print(remainingMaterials, junk);

                    check = true;
                    break;
                }
                else if (legendary["Dragonwrath"] >= 250)
                {
                    remainingMaterials["motes"] -= 250;

                    Console.WriteLine("Dragonwrath obtained!");

                    Print(remainingMaterials, junk);

                    check = true;
                    break;
                }
            }

            if (check)
            {
                break;
            }

            lines = Console.ReadLine();
        }
    }

    private static void Print(Dictionary<string, int> remainingMaterials, Dictionary<string, int> junk)
    {
        var sortedRemainingMaterials = remainingMaterials.OrderByDescending(x => x.Value);
        var sortedJunk = junk.OrderBy(x => x.Key);

        foreach (var item in sortedRemainingMaterials)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        foreach (var item in sortedJunk)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
