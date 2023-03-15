using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a temperatura em graus Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine($"A temperatura em Fahrenheit é {fahrenheit:F1}.");
    }
}