using System;

class WeatherForecast
{
    static void Main()
    {
        string number = Console.ReadLine();

        sbyte first = 0;
        int second = 0;
        long third = 0;

        if (sbyte.TryParse(number, out first))
        {
            Console.WriteLine("Sunny");
        }
        else if (int.TryParse(number, out second))
        {
            Console.WriteLine("Cloudy");
        }
        else if (long.TryParse(number, out third))
        {
            Console.WriteLine("Windy");
        }
        else
        {
            Console.WriteLine("Rainy");
        }
    }
}
