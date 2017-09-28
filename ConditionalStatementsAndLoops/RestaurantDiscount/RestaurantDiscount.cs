using System;

class RestaurantDiscount
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        if (groupSize <= 50)
        {
            Console.WriteLine("We can offer you the Small Hall");
            Console.WriteLine("The price per person is {0:0.00}$",
                CalculatePricePerPerson(groupSize, 2500, package));
        }
        else if (groupSize > 50 && groupSize <= 100)
        {
            Console.WriteLine("We can offer you the Terrace");
            Console.WriteLine("The price per person is {0:0.00}$",
                CalculatePricePerPerson(groupSize, 5000, package));
        }
        else if (groupSize > 100 && groupSize <= 120)
        {
            Console.WriteLine("We can offer you the Great Hall");
            Console.WriteLine("The price per person is {0:0.00}$",
                CalculatePricePerPerson(groupSize, 7500, package));
        }
        else if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
        }
    }

    static double CalculatePricePerPerson(int groupSize, int hallPrice, string package)
    {
        double pricePerPerson = 0.0d;

        if (package == "Normal")
        {
            pricePerPerson = hallPrice + 500;
            pricePerPerson = pricePerPerson * 0.95d / groupSize;
        }
        else if (package == "Gold")
        {
            pricePerPerson = hallPrice + 750;
            pricePerPerson = pricePerPerson * 0.90d / groupSize;
        }
        else if (package == "Platinum")
        {
            pricePerPerson = hallPrice + 1000;
            pricePerPerson = pricePerPerson * 0.85d / groupSize;
        }

        return pricePerPerson;
    }
}