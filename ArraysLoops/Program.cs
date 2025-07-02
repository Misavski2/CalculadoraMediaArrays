using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite as suas duas notas escolares: ");
        string[] response = Console.ReadLine().Split(' ');

        float[] numeros = Array.ConvertAll(response, float.Parse);

        float soma = numeros[0] + numeros[1];

        float media = soma / numeros.Length;

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