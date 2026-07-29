using System;

class Program
{
    static void Main()
    {
        console.Write("Enter your first name: ");
        string firstName = console.ReadLine();

        console.Write("Enter your last name: ");
        string lastName = console.ReadLine();

        string fullName = firstName + " " + lastName;

        console.WriteLine("Full Name: " + fullName);
    }
}
