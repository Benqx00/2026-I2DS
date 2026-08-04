internal class Program
{
    private static void Main(string[] args)
    {
        int num2;
        int num1;

        Console.WriteLine("digite o primeiro numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - soma");
        Console.WriteLine("2 - subtração");
        Console.WriteLine("3 - multiplicação");
        Console.WriteLine("4 - divisão");
        string operacao;
        Console.WriteLine("selecione uma operacao: ");
        operacao = Console.ReadLine();

        switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                break;
            case "3": 
                Console.WriteLine(num1 * num2);
                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                break;
            default:
            Console.WriteLine("operador informado nao é valido!")
                break;
        }

    
    }
}