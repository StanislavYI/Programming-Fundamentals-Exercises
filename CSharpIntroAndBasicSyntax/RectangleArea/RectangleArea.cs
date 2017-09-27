using System;

class RectangleArea
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double result = width * height;

        Console.WriteLine("{0:0.00}", result);
    }
}
