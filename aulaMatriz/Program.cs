using System;

namespace aulaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int qdtLinhas = 2, qtdColunas = 2;
            string[,] m = new string[qdtLinhas, qtdColunas];

            string conteudo = "";

            for (int i = 0; i < qdtLinhas; i++)
            {
                for (int j = 0; j < qtdColunas; j++)
                {
                    if (j == 0) Console.WriteLine("Informe o nome: ");
                    if (j == 1) Console.WriteLine("Informe o sobrenome: ");

                    m[i, j] = Console.ReadLine();
                    conteudo += m[i, j] + " ";
                }
                conteudo += "\n";
            }
            Console.WriteLine(conteudo);
        }
    }
}
