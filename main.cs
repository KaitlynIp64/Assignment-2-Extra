// Created by: Kaitlyn Ip
// Created on: Mar 2022
//
// This program finds the perimeter of a right triangle.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int Base;
        int Height;

        Console.WriteLine("This program finds the income of the user.");
        Console.WriteLine("");
        Console.Write("Enter the base: ");
        Base = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height: ");
        Height = Convert.ToInt32(Console.ReadLine());
        Double perimeter = Base + Height + (Math.Pow((Math.Pow(Base, 2) + Math.Pow(Height, 2)), 0.5));
        Console.WriteLine("");
        Console.Write("Perimeter: " + perimeter.ToString("0.00") + "cm");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}