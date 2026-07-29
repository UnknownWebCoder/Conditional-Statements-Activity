Using System

class Program
{
    static void Main()
    {
        double radius, area;
        const double PI = 3.14159;

        console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = PI * radius * radius;

        console.WriteLine("Area of the circle: " + area);
    }
}

