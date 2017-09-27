using System;

class MilesToKilometers
{
    static void Main()
    {
        double miles = double.Parse(Console.ReadLine());

        double result = miles * 1.60934d;

        Console.WriteLine("{0:0.00}", result);
    }
}
