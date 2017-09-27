using System;

class TriangleOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int a = 1; a <= n; a++)
        {
            for (int b = 0; b < a; b++)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
