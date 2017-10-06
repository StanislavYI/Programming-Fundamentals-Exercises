using System;
using System.Collections.Generic;

class CatchTheThief
{
    static void Main()
    {
        string type = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string ids = "";

        sbyte first = 0;
        int second = 0;
        long third = 0;

        List<sbyte> sbyteList = new List<sbyte>();
        List<int> intList = new List<int>();
        List<long> longList = new List<long>();

        for (int i = 0; i < n; i++)
        {
            ids = Console.ReadLine();

            if (type == "sbyte" &&
                sbyte.TryParse(ids, out first))
            {
                sbyteList.Add(first);
            }
            else if (type == "int" &&
                int.TryParse(ids, out second))
            {
                intList.Add(second);
            }
            else if (type == "long" &&
                long.TryParse(ids, out third))
            {
                longList.Add(third);
            }
        }


        if (type == "sbyte")
        {
            sbyte max = sbyte.MinValue;

            for (int i = 0; i < sbyteList.Count; i++)
            {
                if (max < sbyteList[i])
                {
                    max = sbyteList[i];
                }
            }

            Console.WriteLine(max);
        }
        else if (type == "int")
        {
            int max = int.MinValue;

            for (int i = 0; i < intList.Count; i++)
            {
                if (max < intList[i])
                {
                    max = intList[i];
                }
            }

            Console.WriteLine(max);
        }
        else if (type == "long")
        {
            long max = long.MinValue;

            for (int i = 0; i < longList.Count; i++)
            {
                if (max < longList[i])
                {
                    max = longList[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
