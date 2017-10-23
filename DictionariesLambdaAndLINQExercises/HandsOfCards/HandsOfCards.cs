using System;
using System.Collections.Generic;

class HandsOfCards
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

        while (input != "JOKER")
        {
            string[] data = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            string name = data[0];
            string[] restOfData = data[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (!output.ContainsKey(name))
            {
                output.Add(name, new List<string>());
            }

            for (int i = 0; i < restOfData.Length; i++)
            {
                if (!output[name].Contains(restOfData[i]))
                {
                    output[name].Add(restOfData[i]);
                }
            }

            input = Console.ReadLine();
        }

        if (output.Count > 0)
        {
            Dictionary<string, int> typeNum = new Dictionary<string, int>();
            typeNum.Add("S", 4);
            typeNum.Add("H", 3);
            typeNum.Add("D", 2);
            typeNum.Add("C", 1);

            Dictionary<string, int> powerNum = new Dictionary<string, int>();
            powerNum.Add("J", 11);
            powerNum.Add("Q", 12);
            powerNum.Add("K", 13);
            powerNum.Add("A", 14);

            foreach (var item in output)
            {
                Console.Write(item.Key + ": ");

                long cardValue = 0;

                for (int i = 0; i < item.Value.Count; i++)
                {
                    string card = item.Value[i];

                    string power = card.Substring(0, card.Length - 1);
                    string type = card.Substring(card.Length - 1, 1);

                    int powerNumValue = 0;

                    if (int.TryParse(power, out powerNumValue))
                    {
                        cardValue += powerNumValue * typeNum[type];
                    }
                    else
                    {
                        cardValue += powerNum[power] * typeNum[type];
                    }
                }

                Console.WriteLine(cardValue);
            }
        }
    }
}