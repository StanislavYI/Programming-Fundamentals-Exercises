using System;

class CaloriesCounter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string ingredient = "";
        int calories = 0;

        for (int i = 0; i < n; i++)
        {
            ingredient = Console.ReadLine();

            if (string.Equals("Cheese", ingredient,
                StringComparison.OrdinalIgnoreCase))
            {
                calories += 500;
            }
            else if (string.Equals("Tomato sauce", ingredient,
                StringComparison.OrdinalIgnoreCase))
            {
                calories += 150;
            }
            else if (string.Equals("Salami", ingredient,
                StringComparison.OrdinalIgnoreCase))
            {
                calories += 600;
            }
            else if (string.Equals("Pepper", ingredient,
                StringComparison.OrdinalIgnoreCase))
            {
                calories += 50;
            }
        }

        Console.WriteLine("Total calories: {0}", calories);
    }
}