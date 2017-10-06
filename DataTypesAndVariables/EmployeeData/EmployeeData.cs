using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        byte age = byte.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        ulong personalIDNumber = ulong.Parse(Console.ReadLine());
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + personalIDNumber);
        Console.WriteLine("Unique Employee number: " + uniqueEmployeeNumber);
    }
}
