internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o nome do aluno: ");
        string nome  = Console.ReadLine();
-
        Console.WriteLine("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        double media = calcularMedia(nota1, nota2, nota3);

        Console.WriteLine("Nome do aluno:" + nome);
        Console.WriteLine("Média do aluno: " + media.ToString());

        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if (media <= 5)
        {
            Console.WriteLine("Recuperação");

        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
    static double calcularMedia(double n1, double n2, double n3)
    {
        return (n1 + n2 + n3) / 3;
    }
}