using System;

class ComparingFloats
{
    static void Main()
    {
        double first = double.Parse(Console.ReadLine());
        double second = double.Parse(Console.ReadLine());

        double difference = Math.Abs(first - second);

        bool checkDifference = difference <= 0.000001d ? true : false;

        Console.WriteLine(checkDifference);
    }
}
