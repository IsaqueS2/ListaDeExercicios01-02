namespace ListaDeExercicios19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta.A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição.
            double peso;
            double altura;
            double imc;

            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            altura = double.Parse(Console.ReadLine());


            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }

            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Você está com peso normal");
            }

            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine("Você está acima do peso");
            }

            else if (imc > 30)
            {
                Console.WriteLine("Você está obeso");
            }

            Console.ReadKey();
        }
    }
}