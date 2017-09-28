using System;

class DifferentNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        bool check = false;

        for (int nOne = a; nOne <= b; nOne++)
        {
            for (int nTwo = nOne; nTwo <= b; nTwo++)
            {
                for (int nThree = nTwo; nThree <= b; nThree++)
                {
                    for (int nFour = nThree; nFour <= b; nFour++)
                    {
                        for (int nFive = nFour; nFive <= b; nFive++)
                        {
                            if (nOne >= a && nTwo > nOne && nThree > nTwo && nFour > nThree && nFive > nFour && nFive <= b)
                            {
                                Console.WriteLine(nOne + " " + nTwo + " " + nThree + " " +
                                    nFour + " " + nFive);

                                check = true;
                            }
                        }
                    }
                }
            }
        }

        if (!check)
        {
            Console.WriteLine("No");
        }
    }
}