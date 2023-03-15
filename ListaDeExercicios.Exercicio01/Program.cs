using System;

class Program
{
    static void Main(string[] args)
    {
        double comprimento, largura, altura, volume;

        Console.Write("Informe o comprimento da caixa em metros: ");
        comprimento = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a largura da caixa em metros: ");
        largura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Informe a altura da caixa em metros: ");
        altura = Convert.ToDouble(Console.ReadLine());

        volume = comprimento * largura * altura;

        Console.WriteLine("O volume da caixa é: " + volume + " metros cúbicos.");
    }
}
