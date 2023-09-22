using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Calculate the perimeter of a square");
            Console.WriteLine("2. Calculate the area of a square");
            Console.WriteLine("3. Calculate the area of a rectangle");
            Console.WriteLine("4. Calculate the perimeter of a rectangle");
            Console.WriteLine("5. Calculate the circumference of a circle");
            Console.WriteLine("6. Calculate the volume of a cube");
            Console.WriteLine("7. Calculate the surface area of a cube");
            Console.WriteLine("8. Calculate the volume of a prism");
            Console.WriteLine("9. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateSquarePerimeter();
                    break;
                case 2:
                    CalculateSquareArea();
                    break;
                case 3:
                    CalculateRectangleArea();
                    break;
                case 4:
                    CalculateRectanglePerimeter();
                    break;
                case 5:
                    CalculateCircleCircumference();
                    break;
                case 6:
                    CalculateCubeVolume();
                    break;
                case 7:
                    CalculateCubeSurfaceArea();
                    break;
                case 8:
                    CalculatePrismVolume();
                    break;
                case 9:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CalculateSquarePerimeter()
    {
        Console.Write("Enter the length of a side of the square: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double perimeter = 4 * a;
        Console.WriteLine("The perimeter of the square is: " + perimeter);
    }

    static void CalculateSquareArea()
    {
        Console.Write("Enter the length of a side of the square: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double area = a * a;
        Console.WriteLine("The area of the square is: " + area);
    }

    static void CalculateRectangleArea()
    {
        Console.Write("Enter the length of the longer side of the rectangle: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the shorter side of the rectangle: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double area = a * b;
        Console.WriteLine("The area of the rectangle is: " + area);
    }

    static void CalculateRectanglePerimeter()
    {
        Console.Write("Enter the length of the longer side of the rectangle: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the shorter side of the rectangle: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (a + b);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }

    static void CalculateCircleCircumference()
    {
        Console.Write("Enter the diameter of the circle: ");
        double d = Convert.ToDouble(Console.ReadLine());

        double circumference = 3.14 * d;
        Console.WriteLine("The circumference of the circle is: " + circumference);
    }

    static void CalculateCubeVolume()
    {
        Console.Write("Enter the length of a side of the cube: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double volume = Math.Pow(a, 3);
        Console.WriteLine("The volume of the cube is: " + volume);
    }

    static void CalculateCubeSurfaceArea()
    {
        Console.Write("Enter the length of a side of the cube: ");
        double a = Convert.ToDouble(Console.ReadLine());

        double surfaceArea = 6 * Math.Pow(a, 2);
        Console.WriteLine("The surface area of the cube is: " + surfaceArea);
    }

    static void CalculatePrismVolume()
    {
        Console.Write("Enter the length of one side of the prism: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of another side of the prism: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the prism: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double volume = a * b * c;
        Console.WriteLine("The volume of the prism is: " + volume);
    }
}
