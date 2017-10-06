using System;

class HouseBuilder
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        sbyte sbyteNum = 0;
        int intNum = 0;

        long result = 0;

        if (sbyte.TryParse(first, out sbyteNum))
        {
            result += SbyteCalculation(sbyteNum);
            result += IntCalculation(int.Parse(second));
        }
        else if (int.TryParse(first, out intNum))
        {
            result += IntCalculation(intNum);
            result += SbyteCalculation(sbyte.Parse(second));
        }

        Console.WriteLine(result);
    }
    static int SbyteCalculation(sbyte sbyteNum)
    {
        int result = 4 * sbyteNum;

        return result;
    }
    static long IntCalculation(long intNum)
    {
        long result = 10 * intNum;

        return result;
    }
}
