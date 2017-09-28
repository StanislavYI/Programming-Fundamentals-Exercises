using System;

class GameOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicalNumber = int.Parse(Console.ReadLine());

        int result = 0;

        int num1 = 0;
        int num2 = 0;

        bool check = false;
        int numOfCombinations = 0;

        for (int a = n; a <= m; a++)
        {
            for (int b = n; b <= m; b++)
            {
                if ((a + b) == magicalNumber)
                {
                    num1 = a;
                    num2 = b;

                    result = 0;
                    result = a + b;

                    check = true;
                }

                numOfCombinations++;
            }
        }

        if (check)
        {
            Console.WriteLine("Number found! {0} + {1} = {2}", num1, num2, result);
        }
        else
        {
            Console.WriteLine("{0} combinations - neither equals {1}",
                numOfCombinations, magicalNumber);
        }
    }
}