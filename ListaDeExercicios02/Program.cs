﻿using System;

class Program
{
    static void Main(string[] args)
    {
        double fahrenheit, celsius;

        Console.Write("Digite a temperatura em graus Fahrenheit: ");
        fahrenheit = double.Parse(Console.ReadLine());

        celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("A temperatura em graus Celsius é: " + celsius.ToString("F2"));
        Console.ReadLine();
    }
}