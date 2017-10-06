using System;
using System.Collections.Generic;

class SentenceTheThief
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

        double result = 0d; 

        if (type == "sbyte")
        {
            sbyte sbyteMax = sbyte.MinValue;

            for (int i = 0; i < sbyteList.Count; i++)
            {
                if (sbyteMax < sbyteList[i])
                {
                    sbyteMax = sbyteList[i];
                }
            }

            if (sbyteMax > 0)
            {
                result = sbyteMax / 127d;
            }
            else
            {
                result = sbyteMax / -128d;
            }

            result = Math.Ceiling(result);

            Console.WriteLine(result > 1 ? $"Prisoner with id {sbyteMax} is sentenced to {result} years" :
                $"Prisoner with id {sbyteMax} is sentenced to {result} year");
        }
        else if (type == "int")
        {
            int intMax = int.MinValue;

            for (int i = 0; i < intList.Count; i++)
            {
                if (intMax < intList[i])
                {
                    intMax = intList[i];
                }
            }

            if (intMax > 0)
            {
                result = intMax / 127d;
            }
            else
            {
                result = intMax / -128d;
            }

            result = Math.Ceiling(result);

            Console.WriteLine(result > 1 ? $"Prisoner with id {intMax} is sentenced to {result} years" :
                $"Prisoner with id {intMax} is sentenced to {result} year");
        }
        else if (type == "long")
        {
            long longMax = long.MinValue;

            for (int i = 0; i < longList.Count; i++)
            {
                if (longMax < longList[i])
                {
                    longMax = longList[i];
                }
            }

            if (longMax > 0)
            {
                result = longMax / 127d;
            }
            else
            {
                result = longMax / -128d;
            }

            result = Math.Ceiling(result);

            Console.WriteLine(result > 1 ? $"Prisoner with id {longMax} is sentenced to {result} years" :
                $"Prisoner with id {longMax} is sentenced to {result} year");
        }   
    }
}
