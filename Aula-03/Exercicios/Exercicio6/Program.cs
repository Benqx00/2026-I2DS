using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string resposta = "S";

        while (resposta == "S" || resposta == "s")
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            MostrarTabuada(numero);

            Console.Write("Deseja continuar? (S/N): ");
            resposta = Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine("Programa encerrado.");
    }

    static void MostrarTabuada(int numero)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}