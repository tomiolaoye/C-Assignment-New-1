using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Triangle Area Calculator");

        // Get base and height input from the user
        Console.Write("Enter the base of the triangle: ");
        double triangleBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the triangle
        double area = CalculateTriangleArea(triangleBase, height);

        // Display the result
        Console.WriteLine($"The area of the triangle is: {area}");

        // Wait for user input before closing the console window
        Console.ReadLine();
    }

    static double CalculateTriangleArea(double triangleBase, double height)
    {
        // Formula for calculating the area of a triangle: Area = 0.5 * base * height
        return 0.5 * triangleBase * height;
    }
}