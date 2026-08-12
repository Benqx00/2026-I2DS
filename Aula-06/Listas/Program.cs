internal class Program
{
    public class Aluno
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Matricula {get; set;}

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("====== Trabalho ======");

        // 1 - iniciar uma nova lista
        List<Aluno> listaAluno = new List<Aluno>();

        Aluno aluno1 = new Aluno{ Id = 1, Nome =  "thomaz", Matricula = "447"};
        Aluno aluno2 = new Aluno{ Id = 2, Nome =  "Maria", Matricula = "2406"};
        Aluno aluno3 = new Aluno{ Id = 3, Nome =  "funny", Matricula = "1991"};

        listaAluno.Add(aluno1);
        listaAluno.Add(aluno2);
        listaAluno.Add(aluno3);

        foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
            
        }

        // alterar o elemento da lista
        listaAluno[1].Matricula = "244";
        listaAluno[2].Nome = "ninacuriosa";

        foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
            
        }

        listaAluno.Remove(aluno3);
        Console.WriteLine();
        foreach(var aluno in listaAluno)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Matricula}");
            
        }

        Console.WriteLine($"quantdade de elementos na lista {listaAluno.Count()}");

        listaAluno.Clear();





        




    }
     
     
}