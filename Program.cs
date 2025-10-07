using System.Security.Authentication;

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

        while (true)
        {

            Console.WriteLine("Qual tarefa foi concluida");
            string input = Console.ReadLine();
            if (input.ToLower() == "sair")
            {
                return;
            }
            int idbusca = int.Parse(input);

            var tarefaConcluida = tarefas.FirstOrDefault(t => t.Id == idbusca);

            if (tarefaConcluida != null)
            {
                if (!tarefaConcluida.Concluida)
                {
                    tarefaConcluida.Concluida = true;
                    Console.WriteLine($"A tarefa {tarefaConcluida.Descricao} foi concluida");
                }
                else
                {
                    Console.WriteLine($"A tarefa {tarefaConcluida.Descricao} ja estava concluida");
                }
            }
        }
    }
}
