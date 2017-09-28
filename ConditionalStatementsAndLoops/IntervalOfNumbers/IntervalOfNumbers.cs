using System;

class IntervalOfNumbers
{
    static void Main()
    {
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());

        int temp = 0;

        if (firstNum > secondNum)
        {
            temp = secondNum;
            secondNum = firstNum;
            firstNum = temp;
        }

        for (int i = firstNum; i <= secondNum; i++)
        {
            Console.WriteLine(i);
        }
    }
}