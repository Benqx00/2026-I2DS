internal class Program
{
    private static void Main(string[] args)
    {
        double celsius;
        double fahrenheit;
        Console.WriteLine("digite a temperatura em celsius: ");
        celsius = double.Parse(Console.ReadLine());
        fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("a temperatura em fahrenheit é: " + fahrenheit);

    }
}