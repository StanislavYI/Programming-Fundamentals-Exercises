using System;

class WaterOverflow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        byte tank = 0;
        byte input = 0;

        for (int i = 0; i < n; i++)
        {
            try
            {
                input = byte.Parse(Console.ReadLine());

                checked
                {
                    tank += input;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }

        Console.WriteLine(tank);
    }
}
