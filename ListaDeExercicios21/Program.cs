namespace ListaDeExercicios21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B.
            //Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

            int valor1;
            int valor2;
            int resultado;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());

            if (valor1 == valor2)
            {
                resultado = valor1 + valor2;

                Console.WriteLine("A soma dos valores  foi de: " + resultado);
            }

            else if (valor1 != valor2)
            {
                resultado = valor1 * valor2;

                Console.WriteLine("A multiplicação dos valores foi de: " + resultado);
            }

            Console.ReadKey();
        }
    }
}