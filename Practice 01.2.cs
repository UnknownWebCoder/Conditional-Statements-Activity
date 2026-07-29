using System;

class Program
{
    static void Main()
    {
        int number;

        console.Write("Enter a number: ");
        number = Convert.ToInt32(console.ReadLine());

        if (number > 0)
        {
            console.WriteLibe("The number " + number + " is positive.");
        }
        else
        {
          console.WriteLine("The number " + number + " is negative.");
        }
    }
}
