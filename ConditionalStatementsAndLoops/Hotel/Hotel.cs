using System;

class Hotel
{
    static void Main()
    {
        string month = Console.ReadLine();
        int nightsCount = int.Parse(Console.ReadLine());

        double priceStudio = 0d;
        double priceDouble = 0d;
        double priceSuite = 0d;

        if (month == "May" || month == "October")
        {
            priceStudio = 50;
            priceDouble = 65;
            priceSuite = 75;

            if (nightsCount > 7)
            {
                priceStudio *= 0.95d;
            }
        }
        else if (month == "June" || month == "September")
        {
            priceStudio = 60;
            priceDouble = 72;
            priceSuite = 82;

            if (nightsCount > 14)
            {
                priceDouble *= 0.90d;
            }
        }
        else if (month == "July" || month == "August" ||
            month == "December")
        {
            priceStudio = 68;
            priceDouble = 77;
            priceSuite = 89;

            if (nightsCount > 14)
            {
                priceSuite *= 0.85d;
            }
        }

        priceStudio *= nightsCount;
        priceDouble *= nightsCount;
        priceSuite *= nightsCount;

        if (nightsCount > 7 && month == "September")
        {
            priceStudio -= 60;
        }

        if (nightsCount > 7 && month == "October")
        {
            priceStudio -= (50 * 0.95d);
        }

        Console.WriteLine("Studio: {0:0.00} lv.", priceStudio);
        Console.WriteLine("Double: {0:0.00} lv.", priceDouble);
        Console.WriteLine("Suite: {0:0.00} lv.", priceSuite);
    }
}