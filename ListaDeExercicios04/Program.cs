using System;

namespace Questao4.ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite a quilometragem inicial do percurso:");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final do percurso:");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustível em litros:");
            double consumoCombustivel = double.Parse(Console.ReadLine());

            double distancia = kmFinal - kmInicial;
            double consumoPorKm = consumoCombustivel / distancia;

            Console.WriteLine("O consumo de combustível por km é de " + consumoPorKm.ToString("F2") + " litros.");
        }
    }
}