internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor do saque: ");
        int valor = int.Parse(Console.ReadLine());

        int nota100 = valor / 100;
        valor = valor % 100;

        int nota50 = valor / 50;
        valor = valor % 50;

        int nota20 = valor / 20;
        valor = valor % 20;

        int nota10 = valor / 10;
        valor = valor % 10;

        int nota5 = valor / 5;
        valor = valor % 5;

        int nota2 = valor / 2;
        valor = valor % 2;

        int nota1 = valor;

        Console.WriteLine("Notas entregues: ");
        Console.WriteLine("100: " + nota100);

        Console.WriteLine("50: " + nota50);

        Console.WriteLine("20: " + nota20);

        Console.WriteLine("10: " + nota10);

        Console.WriteLine("5: " + nota5);

        Console.WriteLine("2: " + nota2);

        Console.WriteLine("1: " + nota1);

    

    
    }
}