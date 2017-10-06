using System;

class BeerKegs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string model = "";
        decimal radius = 0.0m;
        int height = 0;

        decimal volume = 0.0m;

        decimal max = decimal.MinValue;

        string biggest = "";

        for (int i = 0; i < n; i++)
        {
            model = Console.ReadLine();
            radius = decimal.Parse(Console.ReadLine());
            height = int.Parse(Console.ReadLine());

            volume = (decimal)Math.PI * (radius * radius) * height;

            if (max < volume)
            {
                max = volume;
                biggest = model;
            }
        }

        Console.WriteLine(biggest);
    }
}
