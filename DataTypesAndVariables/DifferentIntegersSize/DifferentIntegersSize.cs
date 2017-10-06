using System;
using System.Collections.Generic;

class DifferentIntegersSize
{
    static void Main()
    {
        string n = Console.ReadLine();

        sbyte a = 0;
        byte b = 0;
        short c = 0;
        ushort d = 0;
        int e = 0;
        uint f = 0;
        long g = 0;

        bool checkIfEx = false;

        List<string> types = new List<string>();

        for (int i = 0; i < 7; i++)
        {
            try
            {
                switch (i)
                {
                    case 0:
                        a = sbyte.Parse(n);
                        types.Add("sbyte");
                        break;
                    case 1:
                        b = byte.Parse(n);
                        types.Add("byte");
                        break;
                    case 2:
                        c = short.Parse(n);
                        types.Add("short");
                        break;
                    case 3:
                        d = ushort.Parse(n);
                        types.Add("ushort");
                        break;
                    case 4:
                        e = int.Parse(n);
                        types.Add("int");
                        break;
                    case 5:
                        f = uint.Parse(n);
                        types.Add("uint");
                        break;
                    case 6:
                        g = long.Parse(n);
                        types.Add("long");
                        break;
                    default:
                        break;
                }
                checkIfEx = false;
            }        
            catch (OverflowException)
            {
                checkIfEx = true;
            }
        }

        if (checkIfEx)
        {
            Console.WriteLine($"{n} can't fit in any type");
        }
        else
        {
            Console.WriteLine($"{n} can fit in:");

            for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine("* " + types[i]);
            }
        }
    }
}
