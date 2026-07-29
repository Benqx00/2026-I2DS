using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        // Comentário de linha
        /*
        comentario de bloco
        */

        // Escreve uma linha de texto na tela
        Console.WriteLine("Programação orienta a objeto\n");
        Console.WriteLine("abstração - 1 pilar da poo");
         /* criar uma classe em c#, a classe deve ser declarada fora do bloco de programa */
         /* criar um objeto a paritr de uma classe */

         Pet pet1 = new Pet();

         pet1.nome = "lilica";
         pet1.tipo = "Cachorro";
         pet1.idade = 12;
         pet1.MostrarNome();


         Pet pet2 = new Pet();

         pet2.nome = "thomatinho";
         pet2.tipo = "Gato";
         pet2.idade = 5;
         pet2.MostrarNome();

    }

        
        public class Pet //Nome da classe sempre em letra maiuscula
    {
        // declaração de atributos
        public string nome;
        public string tipo;
        
        public int idade;

        // declaração de métodos
        public void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }
    }
    
}