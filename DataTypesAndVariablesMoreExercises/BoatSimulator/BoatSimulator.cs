using System;

class BoatSimulator
{
    static void Main()
    {
        char firstBoat = char.Parse(Console.ReadLine());
        char secondBoat = char.Parse(Console.ReadLine());

        int n = int.Parse(Console.ReadLine());

        int firstBoatMoves = 0;
        int secondBoatMoves = 0;

        for (int i = 1; i <= n; i++)
        {
            string tiles = Console.ReadLine();

            if (tiles == "UPGRADE")
            {
                firstBoat += (char)3;
                secondBoat += (char)3;
            }
            else if (i % 2 == 0)
            {
                secondBoatMoves += tiles.Length;
            }
            else
            {
                firstBoatMoves += tiles.Length;
            }

            if (firstBoatMoves >= 50 || secondBoatMoves >= 50)
                break;
        }

        if (firstBoatMoves > secondBoatMoves)
        {
            Console.WriteLine(firstBoat);
        }
        else
        {
            Console.WriteLine(secondBoat);
        }
    }
}
