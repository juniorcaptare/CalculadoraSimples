using System;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = SolicitarNumero("Digite o primeiro número inteiro: ");
            int numero2 = SolicitarNumero("Digite o segundo número inteiro: ");

            System.Console.WriteLine($"Números digitados: {numero1} e {numero2}");

            Console.WriteLine("Selecione a operação desejada:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            System.Console.Write("Operação selecionada: ");

            int operacao = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    if(numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        System.Console.WriteLine("Erro: Divisão por zero não é permitida!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    return;
            }
            Console.WriteLine("Resultado: " + resultado);
        }

        static int SolicitarNumero(string mensagem)
        {
            int numero;

            while(true)
            {
                try
                {
                    Console.Write(mensagem);
                    numero = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(FormatException)
                {
                    System.Console.WriteLine("O valor digitado não é um número inteiro válido. Por favor, tente novamente.");
                }
            }

            return numero;
        }
    }
}