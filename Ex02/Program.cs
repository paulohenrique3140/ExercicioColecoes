/*
 ENUNCIADO
 2) Crie um programa em C# que sirva para pesquisar um array de valores inteiros . Para fazer isso, siga estas
etapas a seguir
*/

while (true)
{
    /*
 a) Solicite via teclado o número de valores do array (deve ser um número inteiro)
*/
    Console.Write("\nDigite o tamanho que deseja para sua coleção de números (inteiros, positivos e menores que 100): ");
    var num = Convert.ToInt32(Console.ReadLine());

    /*b) Declare e inicialize um array de inteiros com a quantidade de números inteiros informados
     */
    int[] numeros = new int[num];
    Random random = new Random();

    for (int i = 0; i < numeros.Length; i++)
    {
        int numeroAleatorio;
        do
        {
            numeroAleatorio = random.Next(0, 99);
        } while (numeros.Contains(numeroAleatorio));
        numeros[i] = numeroAleatorio;
    }
    Console.WriteLine(" ");
    foreach (var numero in numeros)
    {
        Console.Write($"{numero} | ");
    }
    /* c) Solicite ao usuário um valor de um número inteiro a procurar no array 
    */
    Console.Write("\nDigite o número que deseja pesquisar na lista: ");
    var num2 = Convert.ToInt32(Console.ReadLine());

    /*
    d) Exiba se o número informado existe no array de inteiros ou não
    */
    string msg = numeros.Contains(num2) ? $"O número {num2} está em {numeros.IndexOf(num2) + 1}º lugar na lista" : $"O número {num2} não está na lista";
    Console.WriteLine($"\n{msg}");


    /*e
    --) Repita até que o texto ‘fim’ seja inserido via teclado
     *
     */
    Console.Write("\nDigite 'fim' para encerrar ou enter para continuar: ");
    string? res = Console.ReadLine();
    if (res == "fim")
    {
        Console.WriteLine("Encerrando ... ");
        break;
    }
}