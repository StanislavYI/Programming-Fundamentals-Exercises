using System;

class IntegerToHexAndBinary
{
    static void Main()
    {
        int integer = int.Parse(Console.ReadLine());

        HexRepresentation(integer);
        BinaryRepresentation(integer);
    }
    static void BinaryRepresentation(int integer)
    {
        string binary = "";

        int mod = 0;

        while (integer > 0)
        {
            mod = integer % 2;

            binary += mod;

            integer /= 2;
        }

        Console.WriteLine(ReverseString(binary));
    }
    static void HexRepresentation(int integer)
    {
        int mod = 0;

        string hex = "";

        while (integer > 0)
        {
            mod = integer % 16;

            hex += ReturnHexDigit(mod);

            integer /= 16;
            mod = integer;
        }

        Console.WriteLine(ReverseString(hex));
    }
    static string ReverseString(string str)
    {
        string result = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        return result;
    }
    static char ReturnHexDigit(int digit)
    {
        char result = ' ';

        if (digit > 9)
        {
            result = (char)((digit - 10) + 65);
        }
        else
        {
            result = (char)(digit + 48);
        }

        return result; 
    }
}
