using System;

class DebitCardNumber
{
    static void Main()
    {
        string firstNum = Console.ReadLine();
        string secondNum = Console.ReadLine();
        string thirdNum = Console.ReadLine();
        string fourtNum = Console.ReadLine();

        string result = firstNum.PadLeft(4, '0') + " " +
            secondNum.PadLeft(4, '0') + " " +
            thirdNum.PadLeft(4, '0') + " " +
            fourtNum.PadLeft(4, '0');

        Console.WriteLine(result);
    }
}
