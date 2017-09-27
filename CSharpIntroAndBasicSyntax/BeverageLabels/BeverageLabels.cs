using System;

class BeverageLabels
{
    static void Main()
    {
        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energyContent = double.Parse(Console.ReadLine());
        double sugarContent = double.Parse(Console.ReadLine());

        double energyContentPerVolume = (energyContent * volume) / 100;
        double sugarContentPerVolume = (sugarContent * volume) / 100;

        Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",
            volume, name, energyContentPerVolume, sugarContentPerVolume);
    }
}