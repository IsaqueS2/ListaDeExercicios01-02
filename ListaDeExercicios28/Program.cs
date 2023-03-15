namespace ListaDeExercicios28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Escreva um programa que exiba a tabuada de multiplicação do 1 até o 10. Para isso, o programa deve gerar
             todas as combinações de multiplicação entre 1 e 10, exibindo o resultado de cada operação na tela.
                    a. Desafio: Para cada número, tente separar em colunas.
             */

            for (int i = 1; i <= 10; i++) //multiplicador
            {
                for (int j = 1; j <= 10; j++) //multiplicando
                {
                    Console.Write("{0,3} x {1,-2} = {2,-3}", i, j, i * j);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}