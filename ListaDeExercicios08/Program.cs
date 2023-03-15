namespace Questao8.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe a altura da lata (em centímetros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o raio da lata (em centímetros): ");
            double raio = double.Parse(Console.ReadLine());

            double volume = Math.PI * raio * raio * altura;

            Console.WriteLine($"O volume da lata é {volume:F2} centímetros cúbicos.");
        }
    }
}
