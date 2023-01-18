// Created by: Ashley Monaghan
// Created on: Jan 2023
//
//This program calculates Pi

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int numberOfLoops;
        int counter = 0;
        double denomonaitor = -1;
        double Pi = 0;

        Console.WriteLine("Calculating the number PI!");
        Console.WriteLine("");

        Console.WriteLine("Enter the disired number of calculations:");
        Console.WriteLine("");
        numberOfLoops = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine(" ");

        while (counter < numberOfLoops)
        {
            double numerator = 4;
            denomonaitor = denomonaitor + 2;
            double multiply = Math.Pow(-1, counter);
            double aLittleBit = (numerator / denomonaitor) * multiply;
            Pi = Pi + aLittleBit;
            counter = counter + 1;
        }

        Console.WriteLine("Pie: " + Pi.ToString("0.00") + "!");

        Console.WriteLine("\nDone.");
    }
}