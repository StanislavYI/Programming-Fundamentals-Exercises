using System;
using System.Numerics;

class TheaThePhotographer
{
    static void Main()
    {
        long totalPics = long.Parse(Console.ReadLine());
        long filterTime = long.Parse(Console.ReadLine());
        long filterFactor = long.Parse(Console.ReadLine());
        long uploadTime = long.Parse(Console.ReadLine());

        long filteredPics = (long)(Math.Ceiling(totalPics * (filterFactor / 100d)));

        BigInteger totalPicsTime = totalPics * filterTime;
        BigInteger totalUploadTime = filteredPics * uploadTime;
        
        BigInteger totalTime = totalPicsTime + totalUploadTime;
        
        BigInteger days = 0;
        BigInteger hours = 0;
        BigInteger minutes = 0;
        BigInteger seconds = 0;

        if (totalTime >= 86400)
        {
            days = totalTime / 86400;
            totalTime %= 86400; 
        }
        if (totalTime >= 3600)
        {
            hours = totalTime / 3600;
            totalTime %= 3600;
        }
        if (totalTime >= 60)
        {
            minutes = totalTime / 60;
            totalTime %= 60;
        }

        seconds = totalTime;


        Console.WriteLine($"{days}:{hours.ToString("D2")}:{minutes.ToString("D2")}:{seconds.ToString("D2")}");
    }
}
