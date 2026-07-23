using System.Collections;

ArrayList lista = new ArrayList();

Console.WriteLine("\nInforme o nome e idade de 3 pessoas...\n");
int total = 3;
for (int i = 0; i < total; i++)
{
    Console.Write("\nNome : ");
    string nome = Console.ReadLine();
    Console.Write("Idade : ");
    int idade = int.Parse(Console.ReadLine());

    lista.Add(new Pessoa()
    {
        Nome = nome,
        Idade = idade
    });
}

ListaPessoas(lista);

Console.WriteLine("\nIncluindo mais duas pessoas na lista...");

Pessoa jaime = new Pessoa() { Nome = "Jaime", Idade = 20 };
Pessoa tania = new Pessoa() { Nome = "Tânia", Idade = 18 };

lista.Add(jaime);
lista.Add(tania);

ListaPessoas(lista);

Console.WriteLine("\nRemovendo o último elemento...");
lista.RemoveAt(lista.Count - 1);
ListaPessoas(lista);

Console.ReadLine();

static void ListaPessoas(ArrayList lista)
{
    Console.WriteLine("\nLista de pessoas atual...\n");
    foreach (Pessoa pessoa in lista)
    {
        Console.WriteLine(pessoa.Exibir());
    }
}

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string Exibir()
    {
        return Nome + " - " + Idade;
    }
}