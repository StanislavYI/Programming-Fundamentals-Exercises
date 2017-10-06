using System;

class VowelOrDigit
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());

        if (symbol >= '0' && symbol <= '9')
        {
            Console.WriteLine("digit");
        }
        else if (symbol == 'a' || symbol == 'e' ||
            symbol == 'i' || symbol == 'o' || symbol == 'u')
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}
