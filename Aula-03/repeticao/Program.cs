using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Laço for: 1 até 10
        for (int numero = 1; numero <= 10; numero++)
        {
            Console.WriteLine(numero);
        }

        // Laço for: contagem regressiva de 10 até 0
        for (int numero = 10; numero >= 0; numero--)
        {
            Console.WriteLine(numero);
        }

        // Laço while
        int contador = 1;

        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }

        // Senha
        string senha = "";

        while (senha != "2444")
        {
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine()!;
        }

        Console.WriteLine("Acesso permitido! Happy 0_0");


        int num;
        do
        {
            Console.Write("Digite um Numero Positivo: ");
            num = int.Parse(Console.ReadLine());
        }while(num <=0);
    }
}