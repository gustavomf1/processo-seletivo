using System;

class ExerciseString
{
    public static void Exercicio2()
    {
        Console.WriteLine("Informe uma string: ");
        string palavra = Console.ReadLine();

        int count = 0;
        bool encontrou = false;

        foreach (char c in palavra)
        {
            if (c == 'a' || c == 'A')
            {
                encontrou = true;
                count++;
            }
        }

        if (encontrou)
        {
            Console.WriteLine($"A letra 'a' aparece {count} vez(es) na string {palavra}.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não foi encontrada na string.");
        }

    }
}
