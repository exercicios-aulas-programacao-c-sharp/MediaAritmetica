using System;
/*
[console: MediaAritmetica] Calcule a média aritmética entre 3 números reais digitados pelo usuário.

Média Aritmética de 3 números

Digite o primeiro número.: 7
Digite o segundo número..: 9
Digite o terceiro número.: 5

Média: 7.0

*/
namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            //string textoNumeroUm;
            string textoNumeroDois, textoNumeroTres;
            decimal numeroUm, numeroDois, numeroTres, mediaAritmetica;

            Console.WriteLine("Média Aritmética de 3 números\n");

            Console.Write("Digite o primeiro número.: ");
            //textoNumeroUm = Console.ReadLine();
            numeroUm = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número..: ");
            textoNumeroDois = Console.ReadLine();

            Console.Write("Digite o terceiro número.: ");
            textoNumeroTres = Console.ReadLine();

            //numeroUm = Convert.ToDecimal(textoNumeroUm);
            numeroDois = Convert.ToDecimal(textoNumeroDois);
            numeroTres = Convert.ToDecimal(textoNumeroTres);

            mediaAritmetica = (numeroUm + numeroDois + numeroTres) / 3;

            Console.WriteLine($"\nMédia: {mediaAritmetica:N1}");

        }
    }
}
