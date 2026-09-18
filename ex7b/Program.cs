using System;

class DataValidation
{
    static void Main()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age;

        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Enter a valid age.");
            return;
        }

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
            Console.WriteLine("Name is required.");

        else if (age < 18 || age > 60)
            Console.WriteLine("Age must be between 18 and 60.");

        else if (!email.Contains("@"))
            Console.WriteLine("Enter a valid email.");

        else
            Console.WriteLine("Data validation successful!");
    }
}