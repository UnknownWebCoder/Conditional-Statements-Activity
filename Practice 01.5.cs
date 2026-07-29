using System;

class Program
{
    static void Main()
    {
        char choice;
        double radius;

        Console.WriteLine("A - Area");
        Console.WriteLine("P - Perimeter");
        Console.WriteLine("X - Exit");

        Console.Write("Enter your choice: ");
        choice = Convert.ToChar(Console.ReadLine().ToUpper());

        if (choice == 'A')
        {
            Console.Write("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area: " + (3.14 * radius * radius));
        }
        else if (choice == 'P')
        {
            Console.Write("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Perimeter: " + (2 * 3.14 * radius));
        }
        else if (choice == 'X')
        {
            Console.WriteLine("Exiting...");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
