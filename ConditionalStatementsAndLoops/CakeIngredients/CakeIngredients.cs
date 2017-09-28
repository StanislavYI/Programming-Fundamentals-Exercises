using System;

class CakeIngredients
{
    static void Main()
    {
        string input = Console.ReadLine();

        int count = 0;

        while (input != "Bake!")
        {
            Console.WriteLine("Adding ingredient {0}.", input);
            count++;

            input = Console.ReadLine();
        }

        Console.WriteLine("Preparing cake with {0} ingredients.", count);
    }
}