/*
 3) Escreva um programa em C# que solicite ao usuário que informe o valor das notas, do tipo float , para 10
alunos divididos em 2 grupos de 5 alunos cada. Armazene as informações em um array bidimensional e a
seguir exiba no console a média aritmética de cada grupo de alunos (grupo1 e grupo2).
 */

double[,] notas = new double[2,5];

double soma;

for (int i = 0; i < 2; i++)
{
    Console.Write($"\n### ALUNOS DO GRUPO {i + 1} ###\n");
    soma = 0.0;
    for(int j = 0;  j < 5; j++)
    {
        Console.Write($"\nInforme a nota do {j + 1}º aluno: ");
        notas[i,j] = Convert.ToDouble(Console.ReadLine());
        soma += notas[i, j];
    }
    Console.WriteLine($"\n### Média aritimética do GRUPO {i + 1}: {soma / 5} ###");
}

Console.ReadKey();



