using System;
class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Enter Radius: ");
        double Radius = Convert.ToDouble(Console.ReadLine());
        double Area = Math.PI * Radius * Radius;
        double circumferenceOfCircle = 2 * Math.PI * Radius;
        Console.WriteLine("Area of circle: " + Area);
        Console.WriteLine("\n\nCircumference of circle is: " + circumferenceOfCircle);
        Console.ReadKey();
    }
}

