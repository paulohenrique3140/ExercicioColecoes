/*
 ENUNCIADO
 1) Crie um programa C# para armazenar os nomes de 10 frutas em um array unidimensional e a seguir realize
 as seguintes operações : Dados: Maça, Banana, Laranja, Uva, Manga, Pêra, Abacate, Mamão, Pêssego, Amora
 */

string[] frutas = { "Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora" };

/*
 a) Exiba os nomes das frutas no console e a quantidade de elementos do array usando os laços for e foreach
 */

Console.WriteLine("### LISTA DE FRUTAS ###\n");
foreach(var fruta in frutas)
{
    Console.Write($" {fruta} | ");
}
Console.WriteLine($"\n\nTotal de frutas na lista: {frutas.Count()}");
