using System;
using System.Net.Http.Headers;
using System.Runtime.Serialization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as suas duas notas escolares: ");
        string[] response = Console.ReadLine().Split(' ');

        float[] numeros = Array.ConvertAll(response, float.Parse);

        float soma = 0;

        foreach (float numero in numeros)
        {
            soma += numero; // Itera o valor da esquerda com o da direita
        }

        float media = soma / numeros.Length;
        Console.WriteLine(media);

        Console.WriteLine($"Sua média é: {media:F1}");

         if (media < 7 && media >= 4)
         {
             Console.WriteLine("Voce esta de prova final!");
         } else if (media >= 7)
         {
             Console.WriteLine("Voce esta aprovado!");

         } else
         {
             Console.WriteLine("Voce esta reprovado!");
         }
    }

    
}
