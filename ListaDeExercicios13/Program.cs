using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de pães vendidos: ");
        int qtdPao = int.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de broas vendidas: ");
        int qtdBroa = int.Parse(Console.ReadLine());

        double valorPao = qtdPao * 0.12;
        double valorBroa = qtdBroa * 1.50;
        double totalArrecadado = valorPao + valorBroa;
        double valorPoupanca = totalArrecadado * 0.1;

        Console.WriteLine($"Valor arrecadado com a venda de pães e broas: R${totalArrecadado:F2}");
        Console.WriteLine($"Valor a ser guardado na conta de poupança: R${valorPoupanca:F2}");
    }
}