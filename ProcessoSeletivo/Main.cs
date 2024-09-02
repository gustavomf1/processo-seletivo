using System;

namespace ProcessoSeletivo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("<< Menu de Opções >>");
                Console.WriteLine("1. Calcular o Fibonacci.");
                Console.WriteLine("2. Verificar existência da letra a.");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Você escolheu a Opção 1.");
                        ExerciseFibonacci.Exercicio1();
                        break;
                    case "2":
                        Console.WriteLine("Você escolheu a Opção 2.");
                        ExerciseString.Exercicio2();
                        break;
                    case "0":
                        continuar = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}

