﻿namespace OOpShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square(5); // inside () is the value that we assign to the field 
            Shape square2 = new Square(2); //can't create from child to parent but can create from parent to child

            Console.WriteLine($"Area of the square1: {square1.GetArea()}");
            Console.WriteLine($"Area of the square2: {square2.GetArea()}");

            Circle circle1 = new Circle(5);

            Console.WriteLine($"Area of the circle1: {circle1.GetArea()}");

            Triangle triangle1 = new Triangle(4, 4);
            Console.WriteLine($"Area of the triangle1: {triangle1.GetArea()}");
        }
    }
}