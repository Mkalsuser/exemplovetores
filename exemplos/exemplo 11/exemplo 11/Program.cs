using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int QTD_COL = 3;
            const int QTD_LIN = 5;
            double[,] notas = new double[QTD_LIN, QTD_COL];

            notas = cadastrarNotas (QTD_LIN, QTD_COL);

            Console.WriteLine("\n *** Notas cadastradas na Matriz *** \n");
            exibirDados(notas);
            Console.ReadKey();
        }
        static double[,] cadastrarNotas(int nLin, int nCol)
        {
            double[,] n = new double[nLin, nCol]; 
            for (int i = 0; 1 < nLin; i++)
            {
                Console.WriteLine("\n Notas do {0}° aluno", 1 + 1);
                for (int c = 0; c < nCol; c++)
                {
                    Console.WriteLine(" {0}° nota: ", c + 1);
                    n[1, c] = double.Parse(Console.ReadLine());

                }
            }
            return n;
        }
    
        static void exibirDados(double[,] nt)
        {
            Console.WriteLine("\n Aluno \t \tNotal1 \t \tNota2 \t\tNota3 \n");
            for (int i = 0; i < nt.GetLength(0); i++)
            {
                Console.WriteLine("{0}° Aluno: ", i + 1);
                for (int j = 0; j < nt.GetLength(1); j++)
                {
                    Console.WriteLine("\t {0:N1}\t", nt[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}