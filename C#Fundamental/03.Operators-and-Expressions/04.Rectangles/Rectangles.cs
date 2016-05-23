using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());

        double area = width * heigth;
        double perimeter = 2 * width + 2 * heigth;

        Console.WriteLine("{0:f2} {1:f2}", area, perimeter);
    }
}

