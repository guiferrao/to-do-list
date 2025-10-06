# to-do-list
lista de a fazeres em C#
foi utilizado conceitos de C# e POO como classes, lista, foreach e laços de repetição

public class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(int id, string descricao)
    {
        Id = id;
        Descricao = descricao;
        Concluida = false;
    }
}

class Program
{
    static void Main()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas.Add(new Tarefa(id: 1, descricao: "Lavar a louça"));
        tarefas.Add(new Tarefa(id: 2, descricao: "Arrumar o quarto"));
        tarefas.Add(new Tarefa(id: 3, descricao: "Comprar carne"));

        foreach (Tarefa tarefasAFazer in tarefas)
        {
            Console.WriteLine($"Tarefas a fazer: {tarefasAFazer.Descricao}");
        }

        Console.WriteLine("Qual tarefa foi concluida");
        int idbusca = int.Parse(Console.ReadLine());
        bool tarefaEncontrada = false;
        bool jaConcluida = false;

        foreach (Tarefa tarefaFeita in tarefas)
        {
            if (tarefaFeita.Id == idbusca)
            {
                tarefaEncontrada = true;
                if (tarefaFeita.Concluida)
                {
                    jaConcluida = true;
                    Console.WriteLine($"A tarefa {tarefaFeita.Descricao} ja estava concluida");
                }
                else
                {
                    tarefaFeita.Concluida = true;
                    Console.WriteLine($"A tarefa {tarefaFeita.Descricao} agora esta concluida");
                }
                break;
            }
        }
        if (!tarefaEncontrada && !jaConcluida)
        {
            Console.WriteLine("Nao foi encontrada tarefa com este ID por fazer");
        }
    }
}
