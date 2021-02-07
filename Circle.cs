using System;

namespace MausbachProject2
{
    class Circle
    {
        public static void Main(string[] args)
        {
            MausbachHeading.getHeading("Assignment 2"); //open heading

            //begin of circle assignment
            Console.WriteLine("Enter the radius of a circle ");
            int radius = int.Parse(Console.ReadLine());

            //test formulas
            /*double diameter = 2 * radius;
            double circumference = 2 * 3.14159 * radius;
            double area = 3.14159 * radius * radius;
            */

            double pi = Math.PI;

            //display results
            Console.WriteLine();
            Console.WriteLine($"Diameter {2 * radius}\nCircumference {2 * pi * radius}\nArea {pi * radius * radius}");


            MausbachHeading.getClosing(); //open closing
        }
    }
}
