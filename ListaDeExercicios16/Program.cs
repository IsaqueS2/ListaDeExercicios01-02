using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o salário do funcionário: ");
        double salario = double.Parse(Console.ReadLine());

        double salarioComAumento = salario * 1.15;
        double salarioFinal = salarioComAumento * 0.92;

        Console.WriteLine($"Salário inicial: R${salario:F2}");
        Console.WriteLine($"Salário com aumento: R${salarioComAumento:F2}");
        Console.WriteLine($"Salário final após descontos: R${salarioFinal:F2}");
    }
}