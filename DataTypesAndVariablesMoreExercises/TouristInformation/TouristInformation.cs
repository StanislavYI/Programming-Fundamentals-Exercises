using System;

class TouristInformation
{
    static void Main()
    {
        string imperialUnit = Console.ReadLine();
        double value = double.Parse(Console.ReadLine());

        double convertedValue = 0d;

        string metricUnit = "";

        switch (imperialUnit)
        {
            case "miles":
                convertedValue = value * 1.6d;
                metricUnit = "kilometers";
                break;
            case "inches":
                convertedValue = value * 2.54d;
                metricUnit = "centimeters";
                break;
            case "feet":
                convertedValue = value * 30d;
                metricUnit = "centimeters";
                break;
            case "yards":
                convertedValue = value * 0.91d;
                metricUnit = "meters";
                break;
            case "gallons":
                convertedValue = value * 3.8d;
                metricUnit = "liters";
                break;
            default:
                break;
        }

        Console.WriteLine("{0} {1} = {2:0.00} {3}",
            value, imperialUnit, convertedValue, metricUnit);
    }
}
