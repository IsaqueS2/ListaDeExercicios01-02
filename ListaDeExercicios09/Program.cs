using System;

class Program
{
    static void Main(string[] args)
    {
        int numNotas;
        double somaInversosNotas = 0.0;
        double mediaHarmonica;

        Console.Write("Digite o número de notas do aluno: ");
        numNotas = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numNotas; i++)
        {
            Console.Write($"Digite a nota {i}: ");
            double nota = double.Parse(Console.ReadLine());
            somaInversosNotas += 1.0 / nota;
        }

        mediaHarmonica = numNotas / somaInversosNotas;

        Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica:F2}");
    }
}