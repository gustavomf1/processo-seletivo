class ExerciseFibonacci
{
    public static void Exercicio1()
    {
        Console.WriteLine("<<Sequência de Fibonacci>>");
        Console.WriteLine("Informe um número inteiro: ");
        string num = Console.ReadLine();
        int numInt;
        bool sucesso = int.TryParse(num, out numInt);

        if (!sucesso || numInt < 0)
        {
            Console.WriteLine("Número inválido, digite novamente.");
        }
        else
        {
            bool found = false;
            int fibValue;

            for (int i = 0; ; i++)
            {
                fibValue = Fibonacci(i);

                if (fibValue == numInt)
                {
                    found = true;
                    break;
                }

                if (fibValue > numInt)
                {
                    break;
                }
            }

            Console.WriteLine();

            if (found)
            {
                Console.WriteLine($"O número {numInt} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {numInt} não pertence à sequência de Fibonacci.");
            }
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
