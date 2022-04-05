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
        int length;
        int height;

        Console.WriteLine("This program finds the perimeter of a right triange.");
        Console.WriteLine("");
        Console.Write("Enter the base: ");
        length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height: ");
        height = Convert.ToInt32(Console.ReadLine());
        Double perimeter = length + height + (Math.Pow((Math.Pow(length, 2) + Math.Pow(height, 2)), 0.5));
        Console.WriteLine("");
        Console.Write("Perimeter: " + perimeter.ToString("0.00") + "cm");
        Console.ReadKey();
        Console.WriteLine("\nDone.");
    }
}