using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        uint distanceInMeters = uint.Parse(Console.ReadLine());
        uint hours = uint.Parse(Console.ReadLine());
        uint minutes = uint.Parse(Console.ReadLine());
        uint seconds = uint.Parse(Console.ReadLine());

        float allHours = hours + minutes / 60f + seconds / 3600f;

        
        float kilometersPerHour = (distanceInMeters / allHours) / 1000;
        float metersPerSecond = (kilometersPerHour / 3600f) * 1000f;
        float milesPerHour = kilometersPerHour / 1.609f; 

        Console.WriteLine(metersPerSecond);
        Console.WriteLine(kilometersPerHour);
        Console.WriteLine(milesPerHour);
    }
}
