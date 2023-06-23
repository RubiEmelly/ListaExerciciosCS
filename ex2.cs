MATRIZ -> SOMA DOS ELEMENTOS DA DIAGONAL SECUNDÁRIA

using System.IO.IsolatedStorage;
using System.Runtime.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] mat = new int[5, 5];
        int l, c;
        Console.WriteLine("Informe 25 valores");

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 5; c++)
            {
                Console.WriteLine("Informe o valor do indice" + l + " , " + c);
                mat[l, c] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int media = 0;
        int soma = 0;

        for (l = 0; l < 5; l++)
        {
            for (c = 0; c < 5; c++)
            {
                if ((l + c) == 4)
                {
                    soma = soma + mat[l, c];

                }
            }
        }
        media = soma / 5;
        Console.WriteLine("A media é: " + media);
    }
}