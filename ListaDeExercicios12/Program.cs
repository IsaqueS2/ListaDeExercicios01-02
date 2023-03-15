namespace Questao12.ConsoleApp
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite a largura do terreno em metros:");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terreno em metros:");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine("A área do terreno é de " + area + " metros quadrados.");
        }
    }
}