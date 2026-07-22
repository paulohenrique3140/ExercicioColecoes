/*
 ENUNCIADO
 1) Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
 as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
 */

string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

/*
 a) Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
 */

ExibirLista(frutas);
Console.WriteLine($"\n\nTotal de frutas na lista: {frutas.Count()}");

/*
 b) Exiba os nomes da segunda e da penúltima fruta no console
 */

Console.WriteLine($"\nSegunda fruta da lista: {frutas[1]}");
Console.WriteLine($"Penúltima fruta da lista: {frutas[(frutas.Count() - 2)]}");

/*
 c) Altere o nome da terceira fruta para Kiwi e da última fruta para Caqui e exiba o nome de todas as frutas
 */

frutas[2] = "Kiwi";
frutas[9] = "Caqui";
ExibirLista(frutas);

/*
 d) Ordene a coleção de frutas na ordem ascendente
 */

frutas.Sort();
Console.WriteLine("\n\n\t###### ORDEM CRESCENTE ######");
ExibirLista(frutas);

/*
 e) Ordene a coleção de frutas na ordem ascendente
 */

Array.Reverse(frutas);
Console.WriteLine("\n\n\t###### ORDEM DECRESCENTE ######");
ExibirLista(frutas);

Console.ReadKey();

static void ExibirLista(string[] frutas)
{
    Console.WriteLine("\n### LISTA DE FRUTAS ###\n");
    foreach (var fruta in frutas)
    {
        Console.Write($" {fruta} | ");
    }
}