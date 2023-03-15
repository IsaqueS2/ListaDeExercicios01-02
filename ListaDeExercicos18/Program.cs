namespace ListaDeExercicos18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.

            int valor1;
            int valor2;
            int valor3;
            int aux = 0;

            valor1 = 10;
            valor2 = 20;
            valor3 = 30;

            if (valor1 > valor2)
            {
                aux = valor1;
                valor1 = valor2;
                valor2 = aux;
            }

            if (valor1 > valor3)
            {
                aux = valor1;
                valor1 = valor3;
                valor3 = aux;
            }

            if (valor2 > valor3)
            {
                aux = valor2;
                valor2 = valor3;
                valor3 = aux;
            }
            Console.WriteLine("Valores ordenados: " + valor1 + ", " + valor2 + ", " + valor3);

            Console.ReadKey();
        }
    }
    }
}