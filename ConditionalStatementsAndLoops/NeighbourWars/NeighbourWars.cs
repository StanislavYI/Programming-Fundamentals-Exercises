using System;

class NeighbourWars
{
    static void Main()
    {
        int peshoDamage = int.Parse(Console.ReadLine());
        int goshoDamage = int.Parse(Console.ReadLine());

        int peshoHealth = 100;
        int goshoHealth = 100;

        int turnCount = 1;

        while (true)
        {
            if (turnCount % 2 != 0)
            {
                goshoHealth -= peshoDamage;

                if (goshoHealth <= 0)
                {
                    Console.WriteLine("Pesho won in {0}th round.", turnCount);
                    break;
                }

                Console.WriteLine("Pesho used Roundhouse kick and " +
                    "reduced Gosho to {0} health.", goshoHealth);
            }
            else
            {
                peshoHealth -= goshoDamage;

                if (peshoHealth <= 0)
                {
                    Console.WriteLine("Gosho won in {0}th round.", turnCount);
                    break;
                }

                Console.WriteLine("Gosho used Thunderous fist and " +
                    "reduced Pesho to {0} health.", peshoHealth);
            }

            if (turnCount % 3 == 0)
            {
                goshoHealth += 10;
                peshoHealth += 10;
            }

            turnCount++;
        }
    }
}