using System;

class Program
{
    static void Main(string[] args)
    {
        // Ler as notas das provas
        Console.Write("Digite a nota da primeira prova: ");
        float nota1 = float.Parse(Console.ReadLine());

        Console.Write("Digite a nota da segunda prova: ");
        float nota2 = float.Parse(Console.ReadLine());

        // Definir os pesos das provas
        Console.WriteLine("Levanto em conta que 1 é 100%, digite o peso de cada prova: (ex: 0.5 é 50% do total):");
        Console.WriteLine("Digite quanto vale o valor da primeira prova: ");
        float peso1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite quanto vale o valor da segunda prova: ");
        float peso2 = float.Parse(Console.ReadLine());

        // Calcular a média ponderada
        float media = (nota1 * peso1) + (nota2 * peso2);

        // Imprimir o resultado
        Console.WriteLine($"A média ponderada é: {media}");

        Console.ReadKey();
    }
}