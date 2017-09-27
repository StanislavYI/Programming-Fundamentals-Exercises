using System;

class CharacterStats
{
    static void Main()
    {
        string name = Console.ReadLine();

        int currentHealth = int.Parse(Console.ReadLine());
        int maxHealth = int.Parse(Console.ReadLine());
        int currentEnergy = int.Parse(Console.ReadLine());
        int maxEnergy = int.Parse(Console.ReadLine());

        string displayHealth = new string('|', currentHealth) +
            new string('.', maxHealth - currentHealth);
        string displayEnergy = new string('|', currentEnergy) +
            new string('.', maxEnergy - currentEnergy);

        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("Health: |{0}|", displayHealth);
        Console.WriteLine("Energy: |{0}|", displayEnergy);
    }
}